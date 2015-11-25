using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero myValue = SuperHero.Batman;

            switch (myValue)
            {
                case SuperHero.Batman:
                    break;
                case SuperHero.Superman:
                    break;
                case SuperHero.GreenLantern:
                    break;
                default:
                    break;
            }
        }
    }

    enum SuperHero
    {
        Batman,
        Superman,
        GreenLantern
    }
}
