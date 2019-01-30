using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class BruteForcePlayer : Player
    {
        int letters = 0;
        public override char Guess()
        {
            char[] AtoZ = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            letters++;
            return AtoZ[letters -1];
        }
    }
}
