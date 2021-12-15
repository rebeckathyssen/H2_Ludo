using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoCL
{
    public static class Die
    {
        public static int ThrowDie()
        {
            Random r = new Random();
            int numberOfEyes = r.Next(1,7);
            return numberOfEyes;
        }
    }
}
