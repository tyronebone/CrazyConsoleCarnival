using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class MadLibs : CarnivalGame
    {
        public MadLibs() : base()
        {

        }

        public override string getName()
        {
            return "MadLibs";
        }

        public override void play()
        {
            //Shows the green title text
            showTitle("|20WELCOME TO THE HALLOWEEN MADLIB!");

            writeLine("|50This is a  phrasal template word game in which I will prompt you for a list of words to substitute for blanks in a story.");
            writeLine("|20Once you're done, you can read your final story!");
            writeLine("|50Are you ready to begin?");

            bool getsIt = getYesNo();

            if (getsIt)
                writeLine("|20Great.");
            else
                writeLine("|20Try it anyways.");
            wait(1.5);
            clear();
   
            showSeperator(30, "|20", "|50");

            String Adjective1;
            String FirstName1;
            String Adjective2;
            String Noun1;
            String Verb;
            String Animal;
            String VerbIng1;
            String Adverb;
            String Adjective3;
            String FirstName2;
            String Adjective4;
            String Noun2;
            String VerbIng2;
            String PluralNoun;
            String VerbIng3;

            writeOut("Enter your first adjective: ");
            Adjective1 = Console.ReadLine();

            writeOut("Enter a name: ");
            FirstName1 = Console.ReadLine();

            writeOut("Enter a second adjective: ");
            Adjective2 = Console.ReadLine();

            writeOut("Enter a noun: ");
            Noun1 = Console.ReadLine();

            writeOut("Enter a verb: ");
            Verb = Console.ReadLine();

            writeOut("Enter an animal: ");
            Animal = Console.ReadLine();

            writeOut("Enter a verb ending in -ing: ");
            VerbIng1 = Console.ReadLine();

            writeOut("Enter an adverb: ");
            Adverb = Console.ReadLine();

            writeOut("Enter your third adjective: ");
            Adjective3 = Console.ReadLine();

            writeOut("Enter another name: ");
            FirstName2 = Console.ReadLine();

            writeOut("Enter another adjective: ");
            Adjective4 = Console.ReadLine();

            writeOut("Enter another noun: ");
            Noun2 = Console.ReadLine();

            writeOut("Enter a verb ending in -ing: ");
            VerbIng2 = Console.ReadLine();

            writeOut("Enter a plural noun: ");
            PluralNoun = Console.ReadLine();

            writeOut(".........................");
            wait(1);

            writeLine("\t");

            writeOut("Finally, enter your last verb ending in -ing: ");
            VerbIng3 = Console.ReadLine();

            typeWriter("...Creating your story...");
            wait(3.0);

            showSeperator(30, "|20", "|50");


            writeOut("They say my school is haunted. My " + Adjective1 + " friend " + FirstName1 + " says they saw a " + Adjective2
            + " " + Noun1 + " floating at the end of the hall near the cafeteria. Some say if you "
            + Verb + " down the hallway at night, you'll hear a " + Animal + " " + VerbIng1 + " " + Adverb + ". My "
            + Adjective3 + " friend " + FirstName2 + " saw a " + Adjective4 + " " + Noun2 + " " + VerbIng2 +
            " under one of the tables once. I hope I never see any " + PluralNoun + " " + VerbIng3 + " ; eating lunch there is scary enough!");  

        }

    }
}