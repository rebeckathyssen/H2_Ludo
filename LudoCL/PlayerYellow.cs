using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoCL
{
    public class PlayerYellow : Player
    {
        public PlayerYellow(string color, int playerNumber, List<int> startPositions, int firstPosition) :
            base ( color, playerNumber, startPositions, firstPosition )
        {

        }
        public override int MovePiece(int numberOfMoves, int pickedPiece)
        {
            if (CurrentPositions[pickedPiece] < 43)
            {
                if (CurrentPositions[pickedPiece] + numberOfMoves >= 43)
                {
                    CurrentPositions[pickedPiece] = 84;
                    MakeChoice = 10;
                    return CurrentPositions[pickedPiece];
                }
            }

            if (CurrentPositions[pickedPiece] + numberOfMoves > 89)
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
