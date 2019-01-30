using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class SmartPlayer : Player
    {
        int letters = 0;
        public override char Guess()
        {
            char[] AtoZ = { 'e', 'a', 'o', 'i', 'u', 't', 'n', 's', 'r', 'h', 'l', 'd', 'c', 'm', 'f', 'p', 'g', 'w', 'y', 'b', 'v', 'k', 'x', 'j', 'q', 'z' };
            letters++;
            return AtoZ[letters - 1];

        }
    }
}
