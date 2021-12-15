using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LudoCL
{
    public class PlayerRed : Player
    {
        public PlayerRed(string color, int playerNumber, List<int> startPositions, int firstPosition) :
            base ( color, playerNumber, startPositions, firstPosition )
        {
        }

        public override int MovePiece(int numberOfMoves, int pickedPiece)
        {
            if (CurrentPositions[pickedPiece] + numberOfMoves > 77)
            {
                playersPieces[pickedPiece].IsDone = true;
                FinishedPieces.Add(pickedPiece);
                MakeChoice = 10;
                return CurrentPositions[pickedPiece];
            }
            return base.MovePiece(numberOfMoves, pickedPiece);
        }
    }
}
