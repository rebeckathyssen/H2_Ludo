using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LudoCL;

namespace LudoGame
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            SetPieces();
        }



        private GameManager newGame = new LudoCL.GameManager(/* antal spillere her */4);

        public List<int> PlayerInfoCopy = new List<int>();

        #region MenuButtons
        // "Om Ludo..."
        private void omLudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nogle Ludo regler her...");
        }

        // "Luk spillet"
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


        #region Die
        // When the Die is clicked, we want to make a roll-effect. This is done by setting a timer with
        // an interval of 150 ms:
        private void VisibleDie_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int numberOfTicks;

        int numberOfEyes;

        // Once the timer has been started, we call our Die-object from our backend class library.
        // This object has a method which will generate a random number between 1 and 6 and return the
        // result. We grab the result and switch it, setting the image of the die to the corresponding
        // integer.

        private void timer1_Tick(object sender, EventArgs e)
        {
            numberOfEyes = Die.ThrowDie();

            switch (numberOfEyes)
            {
                case 1:
                    SwitchInt(InvisibleDie1.Image);
                    break;

                case 2:
                    SwitchInt(InvisibleDie2.Image);
                    break;

                case 3:
                    SwitchInt(InvisibleDie3.Image);
                    break;

                case 4:
                    SwitchInt(InvisibleDie4.Image);
                    break;

                case 5:
                    SwitchInt(InvisibleDie5.Image);
                    break;

                case 6:
                    SwitchInt(InvisibleDie6.Image);
                    break;

                default:
                    MessageBox.Show("Something went wrong!");
                    break;
            }

            if (numberOfTicks == 5)
            {
                timer1.Stop();
                numberOfTicks = 0;

                
                List<int> PlayerPieceInfo = newGame.RollDie(numberOfEyes);
                SetPlayerLabel(newGame.ActivePlayer);
                PlayerInfoCopy = PlayerPieceInfo;
                if (PlayerInfoCopy != null && PlayerInfoCopy.Count == 3)
                {
                    ChoiceLabel.Visible = true;
                }
            }


        }

        // Switch billede for at sørge for at den samme side af terningen ikke
        // vises 2 gange i træk
        private void SwitchInt(Image picture)
        {
            if (VisibleDie.Image != picture)
            {
                VisibleDie.Image = picture;
                numberOfTicks = numberOfTicks + 1;
            }
        }

        private void MovePiece(List<int> PlayerPieceInfo)
        {
            if (PlayerPieceInfo != null)
            {
                
                Player activePlayer = newGame.AllPlayers[PlayerPieceInfo[0]];
                if (activePlayer.playersPieces[PlayerPieceInfo[1]].IsDone)
                {
                    // Gør brik usynlig hvis den er færdig
                    this.Controls.Find(activePlayer.Color + PlayerPieceInfo[1], true)[0].Visible = false;
                }

                if (activePlayer.IsWinner)
                {
                    MessageBox.Show("Nogen har vundet...");
                }
                SetPiecesHelper((PictureBox)this.Controls.Find(activePlayer.Color + PlayerPieceInfo[1], true)[0],
                    PlayerPieceInfo[2]);
            }
            
        }

        private void SetPlayerLabel(int player)
        {
            label1.Text = "Spiller " + player + "'s tur!";
            switch (player)
            {
                case 0:
                    label1.BackColor = Color.Crimson;
                    label1.Location = new Point(137, 55);
                    break;

                case 1:
                    label1.BackColor = Color.Aqua;
                    label1.Location = new Point(516, 55);
                    break;

                case 2:
                    label1.BackColor = Color.Fuchsia;
                    label1.Location = new Point(137, 448);
                    break;

                case 3:
                    label1.BackColor = Color.Gold;
                    label1.Location = new Point(516, 448);
                    break;

                default:
                    MessageBox.Show("Noget gik galt!");
                    break;
            }

        }

        private void SetPieces()
        {
            int pieceIndex = 0;
            foreach (Player player in newGame.AllPlayers)
            {

                for (int i = 0; i < 4; i++)
                {
                    SetPiecesHelper((PictureBox)this.Controls.Find(player.Color + i, true)[0], pieceIndex);
                    pieceIndex++;
                }
            }

        }

        private void SetPiecesHelper(PictureBox pieceName, int elementAt)
        {
            Dictionary dict = new Dictionary();
            pieceName.Location =
                new Point(dict.Map[elementAt].ElementAt(0),
                    dict.Map[elementAt].ElementAt(1));
        }

        #endregion

        #region PickAmountOfPlayers
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void PickPiece(int player, int piece)
        {
            if (PlayerInfoCopy == null)
            {
                MessageBox.Show("Hov hov du!");
                return;
            }

            if (PlayerInfoCopy[0] != player)
            {
                MessageBox.Show("Du kan kun flytte med dine egne brikker!");
                return;
            }

            newGame.AllPlayers[player].MakeChoice = piece;
            PlayerInfoCopy[1] = piece;
            // Før kunne backend ikke give os position på den brik vi gerne ville flytte, fordi den var afhængig
            // af det valg vi endnu ikke havde taget. Hvis vi derimod kalder MovePiece herunder, kan den give
            // os de oplysninger vi har brug for for at flytte brikken, plus at den opdaterer position på spillerens valgte brik

            PlayerInfoCopy.RemoveAt(2);
            // Vi kender ikke positionen på brikken, den vil vi gerne have ind i vores liste, så den tilføjer vi her:
            PlayerInfoCopy.Add(newGame.AllPlayers[player].MovePiece(numberOfEyes, piece));
            MovePiece(PlayerInfoCopy);
            if (numberOfEyes != 6)
            {
                newGame.NextPlayer();
                SetPlayerLabel(newGame.ActivePlayer);
            }

            ChoiceLabel.Visible = false;

        }
        private void RedPiece0_Click(object sender, EventArgs e)
        {
            PickPiece(0, 0);
        }

        private void RedPiece1_Click(object sender, EventArgs e)
        {
            PickPiece(0, 1);
        }

        private void RedPiece2_Click(object sender, EventArgs e)
        {
            PickPiece(0, 2);
        }

        private void RedPiece3_Click(object sender, EventArgs e)
        {
            PickPiece(0, 3);
        }

        private void TurPiece0_Click(object sender, EventArgs e)
        {
            PickPiece(1, 0);
        }

        private void TurPiece1_Click(object sender, EventArgs e)
        {
            PickPiece(1, 1);
        }

        private void TurPiece2_Click(object sender, EventArgs e)
        {
            PickPiece(1, 2);
        }

        private void TurPiece3_Click(object sender, EventArgs e)
        {
            PickPiece(1, 3);
        }

        private void PurPiece0_Click(object sender, EventArgs e)
        {
            PickPiece(2, 0);
        }

        private void PurPiece1_Click(object sender, EventArgs e)
        {
            PickPiece(2, 1);
        }

        private void PurPiece2_Click(object sender, EventArgs e)
        {
            PickPiece(2, 2);
        }

        private void PurPiece3_Click(object sender, EventArgs e)
        {
            PickPiece(2, 3);
        }

        private void YelPiece0_Click(object sender, EventArgs e)
        {
            PickPiece(3, 0);
        }

        private void YelPiece1_Click(object sender, EventArgs e)
        {
            PickPiece(3, 1);
        }

        private void YelPiece2_Click(object sender, EventArgs e)
        {
            PickPiece(3, 2);
        }

        private void YelPiece3_Click(object sender, EventArgs e)
        {
            PickPiece(3, 3);
        }
    }
}
