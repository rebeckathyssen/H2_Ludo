using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoCL
{
    public class Piece
    {
        public bool IsActive { get; set; } // True = på brættet, false = stadig hjemme
        public bool IsDone { get; set; } // True = har gået hele banen rundt

        public Piece(bool state, bool isDone)
        {
            IsActive = state;
            IsDone = isDone;
        }
    }
}
