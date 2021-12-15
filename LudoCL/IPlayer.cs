using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoCL
{
    public interface IPlayer
    {
        List<Piece> BuildPieces(List<int> positions);
        List<int> GetPositions(List<int> positions);
        bool IsHome();
        int MovePiece(int numberOfMoves, int pickedPiece);
        List<int> GetPieceInfo();
    }
}
