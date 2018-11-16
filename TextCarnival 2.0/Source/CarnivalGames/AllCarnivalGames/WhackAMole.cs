using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class WhackAMole : CarnivalGame
    {
        public String q = " ", w = " ", e = " ", r = " ", a = " ", s = " ", d = " ", f = " ", z = " ", x = " ", c = " ", v = " ";
        public static Random rand = new Random();
        public int limit = 1000;
        public int hole;
        public int score = 0;
        public int goal = 15;
        public bool winner = false;
        ConsoleKey input;
        public WhackAMole() : base()
        {

        }

        public override string getName()
        {
            return "Whack-A-Mole";
        }

        public override void play()
        {
            writeOut("Would you like to see the tutorial? yes or no? (If this is your first time, I recommend seeing it.)");
            bool tut = getYesNo();
            if (tut) {
                tutorial();
            }
            writeOut("Start!"); wait(3);
            clear();
            primeBoard();
        }
        public void tutorial()
        {
            clear();
            writeOut("Welcome!"); wait(1);
            writeOut("This is Whack-A-Mole!"); wait(1);
            writeOut("In this game, you..."); dramaticPause(3);
            writeOut("...whack moles!"); wait(1);
            writeOut("The board looks like this:");
            writeLine("+ - +  + - +  + - +  + - +");
            writeLine("- Q -  - W -  - E -  - R -");
            writeLine("+ - +  + - +  + - +  + - +");
            writeLine("                          ");
            writeLine("+ - +  + - +  + - +  + - +");
            writeLine("- A -  - S -  - D -  - F -");
            writeLine("+ - +  + - +  + - +  + - +");
            writeLine("                          ");
            writeLine("+ - +  + - +  + - +  + - +");
            writeLine("- Z -  - X -  - C -  - V -");
            writeLine("+ - +  + - +  + - +  + - +"); wait(3);
            writeOut("It's a 4x3 grid, and you hit a mole by hitting the key shown in the box."); wait(1);
            writeOut("The moles will show up as @ signs in the boxes."); wait(1);
            writeOut("They'll stay on screen until you hit them, but you won't gain points unless you hit them in time."); wait(1);
            writeOut("Simple, isn't it?"); wait(1);
            writeOut("Would you like to see the tutorial again?");
            bool again = getYesNo();

            if (again)
            {
                clear();
                tutorial();
            }
            else
            {
                clear();
                writeOut("Alright!"); wait(1);
            }
        }
        public void primeBoard()
        {
            getMole();
            drawBoard();
        }
        public void blankBoard()
        {
            writeLine("+ - +  + - +  + - +  + - +");
            writeLine("-   -  -   -  -   -  -   -");
            writeLine("+ - +  + - +  + - +  + - +");
            writeLine("                          ");
            writeLine("+ - +  + - +  + - +  + - +");
            writeLine("-   -  -   -  -   -  -   -");
            writeLine("+ - +  + - +  + - +  + - +");
            writeLine("                          ");
            writeLine("+ - +  + - +  + - +  + - +");
            writeLine("-   -  -   -  -   -  -   -");
            writeLine("+ - +  + - +  + - +  + - +");
            writeLine("SCORE: " + score);
            writeLine("GOAL: " + goal);
            writeLine("ESC TO EXIT");
        }
        public void drawBoard()
        {
            if (winner) { return; }
            while (true)
            {
                if (winner) { writeOut("Sending you back to the carnival..."); wait(2); return; }
                blankBoard();
                wait(rand.Next(1, 3));
                clear();
                writeLine("+ - +  + - +  + - +  + - +");
                writeLine("- " + q + " -  - " + w + " -  - " + e + " -  - " + r + " -");
                writeLine("+ - +  + - +  + - +  + - +");
                writeLine("                          ");
                writeLine("+ - +  + - +  + - +  + - +");
                writeLine("- " + a + " -  - " + s + " -  - " + d + " -  - " + f + " -");
                writeLine("+ - +  + - +  + - +  + - +");
                writeLine("                          ");
                writeLine("+ - +  + - +  + - +  + - +");
                writeLine("- " + z + " -  - " + x + " -  - " + c + " -  - " + v + " -");
                writeLine("+ - +  + - +  + - +  + - +");
                writeLine("SCORE: " + score);
                writeLine("GOAL: " + goal);
                writeLine("ESC TO EXIT");
                hitMole();
                clear();
                if(score==goal)
                {
                    winner = true;
                    writeOut("You win!"); wait(1);
                    return;
                }
                clearHoles();
                getMole();
                drawBoard();
            }
        }
        public void clearHoles()
        {
            q = " "; w = " "; e = " "; r = " "; a = " "; s = " "; d = " "; f = " "; z = " "; x = " "; c = " "; v = " ";
        }
        public void getMole()
        {
            hole = rand.Next(1, 12);
            if (hole == 1)
                q = "@";
            else if (hole == 2)
                w = "@";
            else if (hole == 3)
                e = "@";
            else if (hole == 4)
                r = "@";
            else if (hole == 5)
                a = "@";
            else if (hole == 6)
                s = "@";
            else if (hole == 7)
                d = "@";
            else if (hole == 8)
                f = "@";
            else if (hole == 9)
                z = "@";
            else if (hole == 10)
                x = "@";
            else if (hole == 11)
                c = "@";
            else if (hole == 12)
                v = "@";
        }
        public void hitMole()
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            input = getKey();
            time.Stop();
            if(time.ElapsedMilliseconds>limit)
                return;
            if (input == ConsoleKey.Q && hole == 1)
                score++;
            if (input == ConsoleKey.W && hole == 2)
                score++;
            if (input == ConsoleKey.E && hole == 3)
                score++;
            if (input == ConsoleKey.R && hole == 4)
                score++;
            if (input == ConsoleKey.A && hole == 5)
                score++;
            if (input == ConsoleKey.S && hole == 6)
                score++;
            if (input == ConsoleKey.D && hole == 7)
                score++;
            if (input == ConsoleKey.F && hole == 8)
                score++;
            if (input == ConsoleKey.Z && hole == 9)
                score++;
            if (input == ConsoleKey.X && hole == 10)
                score++;
            if (input == ConsoleKey.C && hole == 11)
                score++;
            if (input == ConsoleKey.V && hole == 12)
                score++;
            if (input == ConsoleKey.Escape)
                winner = true;
        }
    }
}
