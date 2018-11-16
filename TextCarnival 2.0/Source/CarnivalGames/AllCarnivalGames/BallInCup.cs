using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class BallInCup : CarnivalGame
    {
        public override string getName()
        {
            return "Ball In Cup";
        }

        public override void play()
        {
            clear();
            showTitle("Ball In Cup Game");


            int round = 1;
            while (true)
            {
                clear();
                Random rand = new Random();
                writeLine("Choose difficulty: (1, 2, 3, 4, or 5)");
                int cups = getInput();
                if ( cups <= 0 )
                {
                    break;
                }
                int cor = rand.Next(0, cups);
                writeLine("Round " + round);
                for ( int i = 1; i <= cups; i++ )
                {
                    writeLine("  ___  \n  /   \  \n /     \ \n    " + i);
                }
                writeLine("Pick a cup");
                int ans = getInput();
                if ( ans == cor )
                {
                    writeLine("  ___  \n  /   \  \n /     \ \n    O");
                    wait(2);
                    writeLine("Lucky Guess...");
                }
                else
                {
                    writeLine("  ___  \n  /   \  \n /     \ ");
                    wait(1);
                    writeLine("WRONG");
                }

                writeOut("Play Again? (Y/N)");
                string input = getInput();
                if ( input.Contains("Y"))
                {

                }
                else
                {
                    break;
                }
                round++;
            }
        }
    }
}
