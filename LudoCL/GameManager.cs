using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LudoCL
{
    public class GameManager
    {
        public int ActivePlayer { get; set; }
        private int RetryCount { get; set; }

        public List<Player> AllPlayers = new List<Player>();

        public GameManager(int amountOfPlayers)
        {
            new Board();

            BuildPlayers(amountOfPlayers);

            ActivePlayer = 0; // vores aktive spillere er defineret efter indexet i listen, så spiller 1 = index 0

            RetryCount = 0; // for at holde styr på hvor mange gange en spiller har slået i første runde for at få en brik ud
        }

        public List<Player> BuildPlayers(int amountOfPlayers)
        {
            AllPlayers.Add(new PlayerRed("RedPiece", 0, new List<int>() {1, 2, 3, 4}, 17));
            AllPlayers.Add(new PlayerTurquoise("TurPiece", 1, new List<int>() { 5, 6, 7, 8 }, 31));
            AllPlayers.Add(new PlayerPurple("PurPiece", 2, new List<int>() { 9, 10, 11, 12 }, 59));
            AllPlayers.Add(new PlayerYellow("YelPiece", 3, new List<int>() { 13, 14, 15, 16 }, 45));

            switch (amountOfPlayers)
            {
                case 1:
                    AllPlayers.RemoveRange(1, 3);
                    break;
                case 2:
                    AllPlayers.RemoveRange(2, 2);
                    break;
                case 3:
                    AllPlayers.RemoveRange(3, 1);
                    break;
                case 4:
                    break;
            }
            return AllPlayers;
        }

        public void NextPlayer()
        {
            ActivePlayer++;
            if (AllPlayers.Count == ActivePlayer)
            {
                ActivePlayer = 0;
            }
        }


        // RULE LOGIC
        public List<int> RollDie(int finalNumberOfEyes)
        {
            List<int> PlayerPieceInfo = AllPlayers[ActivePlayer].GetPieceInfo();

            // Først vil vi gerne tjekke om alle brikker er hjemme
            if (AllPlayers[ActivePlayer].IsHome())
            {
                if (finalNumberOfEyes == 6)
                {
                    RetryCount = 0;
                    if (AllPlayers[ActivePlayer].MakeChoice == 10)
                    {
                        //hvis makechoice = 10 er der endnu ikke foretaget et valg
                        PlayerPieceInfo.Add(1); // som indikerer at her skal foretages et valg
                    }

                    return PlayerPieceInfo;
                }
                else
                {
                    if (RetryCount < 2)
                    {
                        RetryCount++;
                    }
                    else
                    {
                        RetryCount = 0;
                        NextPlayer();
                    }

                    return null;
                }
            }
            else // her er ikke alle brikker hjemme
            {
                // I begge tilfælde SKAL man foretage et valg, derfor:
                if (AllPlayers[ActivePlayer].MakeChoice == 10)
                {
                    //hvis makechoice = 10 er der endnu ikke foretaget et valg
                    PlayerPieceInfo.Add(1); // som indikerer at her skal foretages et valg
                }

                return PlayerPieceInfo;
            }
        }

    }
}
