using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LudoCL
{
    public abstract class Player : IPlayer
    {
        public string Color { get; set; }
        private int PlayerNumber { get; }
        private List<int> StartPositions { get; }
        public List<int> CurrentPositions { get; set; }
        private int FirstPosition { get; }
        public int MakeChoice { get; set; }
        public List<int> FinishedPieces { get; set; }
        public bool IsWinner { get; set; }

        // spiller har fået playernumber, fordi vi skal bruge den til GetPieceInfo,
        // da spilleren ellers ikke ved hvem den selv er
        public Player(string color, int playerNumber, List<int> startPositions, int firstPosition)
        {
            Color = color;
            PlayerNumber = playerNumber;
            BuildPieces(startPositions);
            StartPositions = GetPositions(startPositions);
            CurrentPositions = startPositions;
            FirstPosition = firstPosition;
            MakeChoice = 10;
            FinishedPieces = new List<int>();
            IsWinner = false;
        }

        public List<Piece> playersPieces = new List<Piece>();

        List<int> piecesLocation = new List<int>();

        public List<Piece> BuildPieces(List<int> positions)
        { // alle brikker sættes til false fordi de ikke er aktive før de er ude på brættet
            Piece piece1 = new Piece(false, false);
            Piece piece2 = new Piece(false, false);
            Piece piece3 = new Piece(false, false);
            Piece piece4 = new Piece(false, false);

            playersPieces.Add(piece1);
            playersPieces.Add(piece2);
            playersPieces.Add(piece3);
            playersPieces.Add(piece4);

            return playersPieces;
        }

        public List<int> GetPositions(List<int> positions)
        {
            piecesLocation.Add(positions[0]);
            piecesLocation.Add(positions[1]);
            piecesLocation.Add(positions[2]);
            piecesLocation.Add(positions[3]);

            return piecesLocation;
        }

        public bool IsHome()
        {
            // sammenligner den enkelte spillers brikkers startpositioner med deres nuværende position
            // returneres true er alle brikkerne hjemme
            return StartPositions.SequenceEqual(CurrentPositions);
        }

        public virtual int MovePiece(int numberOfMoves, int pickedPiece)
        {
            // ny bool: isWinner
            // hvis listen af finishedpieces.count = 4, isWinner = true
            
            if (playersPieces[pickedPiece].IsActive)
            {
                if (CurrentPositions[pickedPiece] + numberOfMoves > 71 && CurrentPositions[pickedPiece] + numberOfMoves < 78
                && PlayerNumber != 0)
                {
                    CurrentPositions[pickedPiece] = CurrentPositions[pickedPiece] + numberOfMoves - 56;
                }
                else
                {
                    CurrentPositions[pickedPiece] = CurrentPositions[pickedPiece] + numberOfMoves;
                }
            }
            else
            {
                CurrentPositions[pickedPiece] = FirstPosition;
                playersPieces[pickedPiece].IsActive = true;
            }

            if (FinishedPieces.Count == 4)
            {
                // tjek om spiller har vundet
                IsWinner = true;
            }

            MakeChoice = 10;
            return CurrentPositions[pickedPiece];
        }

        public List<int> GetPieceInfo()
        {
            List<int> PieceInfo = new List<int>();
            PieceInfo.Add(PlayerNumber);
            PieceInfo.Add(MakeChoice);
            return PieceInfo;
        }
    }
}
