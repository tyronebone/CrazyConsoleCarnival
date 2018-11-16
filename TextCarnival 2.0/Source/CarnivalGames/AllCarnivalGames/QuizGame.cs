using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class QuizGame : CarnivalGame
    {
        public QuizGame() : base()
        {
            
        }

        public override string getName()
        {
            return "The Sports Quiz Game";
        }

        public override void play()
        {
            writeOut("Welcome to the Ultimate Sports Trivia !");
            writeOut("What is your name ?");
            String name = getInput();
            writeOut("Oh Hello " + name + " are you ready to test your knowledge");
            bool getsIt = getYesNo();

            if (getsIt)
                writeLine("Great! Best of luck to you");
            else
                writeLine("Well looks like your doing it anyway, I bet you fail");
            wait(3);
            clear();
            writeLine("|50---------------------------------------------");
            writeLine("|b0                Directions                   ");
            writeLine("|50---------------------------------------------");
            wait(0.5);
            writeLine("In this game you will be given a series of 15 sports trivia question, answered by multiple choice.");
            wait(2);
            writeLine("|0cBE SURE TO TYPE A LETTER THAT CORRESPINDS, ANYTHING ELSE WILL BE WRONG");
            wait(1);
            writeOut("Ready to start? ");
            bool start = getYesNo();
            if (start)
            {
                writeLine("Great! Starting now");
                wait(1);
            }

            else
            {
                writeLine("Okay, 10 more seconds");
                wait(10);
            }
            clear();
            int score = 0;

            writeLine("Question 1: What NFL team currently holds the most superbowl wins?");
            wait(1);
            writeLine("[A] Cowboys");
            wait(.5);
            writeLine("[B] Steelers");
            wait(.5);
            writeLine("[C] Patriots");
            wait(.5);
            writeLine("[D] 49ers");
            wait(.5);
            writeLine("Answere: ");
            String qes1 = getInput();
            if (qes1 == "b" || qes1 == "B") 
            {
                beep(9000, 0.5f);
                writeLine("|0aCORRECT");
             
                score++;
            }
            else
            {
                beep(900, 0.5f);
                writeLine("|04INCORRECT");
            }
            wait(1);
            writeLine("|80Your current score is: " + score);
            wait(3);
            clear();

            writeLine("Question 2: What was the first national team to win the FIFA World Cup?");
            wait(1);
            writeLine("[A] Uraguay");
            wait(.5);
            writeLine("[B] England");
            wait(.5);
            writeLine("[C] France");
            wait(.5);
            writeLine("[D] Scottland");
            wait(.5);
            writeLine("Answere: ");
            String qes2 = getInput();
            if (qes2 == "a" || qes2 == "A")
            {
                beep(9000, 0.5f);
                writeLine("|0aCORRECT");
                score++;
            }
            else
            {
                beep(900, 0.5f);
                writeLine("|04INCORRECT");
            }
            wait(1);
            writeLine("|80Your current score is: " + score);
            wait(3);
            clear();

            writeLine("Question 3: What Olympic Athlete holds the most gold medals");
            wait(1);
            writeLine("[A] Larisa Latynina");
            wait(.5);
            writeLine("[B] Usain Bolt");
            wait(.5);
            writeLine("[C] Micheal Phelps");
            wait(.5);
            writeLine("[D] Bjørn Dæhlie");
            wait(.5);
            writeLine("Answere: ");
            String qes3 = getInput();
            if (qes3 == "c" || qes3 == "C")
            {
                beep(9000, 0.5f);
                writeLine("|0aCORRECT");
                score++;
            }
            else
            {
                beep(900, 0.5f);
                writeLine("|04INCORRECT");
            }
            wait(1);
            writeLine("|80Your current score is: " + score);
            wait(3);
            clear();



            writeLine("Question 4: Who was the last non quarterback to win NFL MVP?");
            wait(1);
            writeLine("[A] Reggie Bush");
            wait(.5);
            writeLine("[B] Adrian Peterson");
            wait(.5);
            writeLine("[C] Todd Gurley III");
            wait(.5);
            writeLine("[D] Jerry Rice");
            wait(.5);
            writeLine("Answere: ");
            String qes4 = getInput();
            if (qes4 == "B" || qes4 == "b")
            {
                beep(9000, 0.5f);
                writeLine("|0aCORRECT");
                score++;
            }
            else
            {
                beep(900, 0.5f);
                writeLine("|04INCORRECT");
            }
            wait(1);
            writeLine("|80Your current score is: " + score);
            wait(3);
            clear();


            writeLine("Question 5: What player scored the goal to win the Premeir League for Mancheser City in 2012");
            wait(1);
            writeLine("[A] David Silva");
            wait(.5);
            writeLine("[B] Raheem Sterling");
            wait(.5);
            writeLine("[C] Kevin De Bruyne");
            wait(.5);
            writeLine("[D] Sergio Aguero");
            wait(.5);
            writeLine("Answere: ");
            String qes5 = getInput();
            if (qes5 == "D" || qes5 == "d")
            {
                beep(9000, 0.5f);
                writeLine("|0aCORRECT");
                score++;
            }
            else
            {
                beep(900, 0.5f);
                writeLine("|04INCORRECT");
            }
            wait(1);
            writeLine("|80Your current score is: " + score);
            wait(3);
            clear();


            writeLine("Question 6: Which type of ball was basketball played with until 1929?");
            wait(1);
            writeLine("[A] Rubber dodgeball");
            wait(.5);
            writeLine("[B] Soccer ball");
            wait(.5);
            writeLine("[C] Leather ball");
            wait(.5);
            writeLine("[D] Basketball, trick question");
            wait(.5);
            writeLine("Answere: ");
            String qes6 = getInput();
            if (qes6 == "B" || qes6 == "b")
            {
                beep(9000, 0.5f);
                writeLine("|0aCORRECT");
                score++;
            }
            else
            {
                beep(900, 0.5f);
                writeLine("|04INCORRECT");
            }
            wait(1);
            writeLine("|80Your current score is: " + score);
            wait(3);
            clear();


            writeLine("Question 7: Who is the only tennis player to have won each of the four grand slam events at least four times");
            wait(1);
            writeLine("[A] Serena Williams");
            wait(.5);
            writeLine("[B] Steffi Graf");
            wait(.5);
            writeLine("[C] Rodger Federer");
            wait(.5);
            writeLine("[D] Venus Williams");
            wait(.5);
            writeLine("Answere: ");
            String qes7 = getInput();
            if (qes7 == "B" || qes7 == "b")
            {
                beep(9000, 0.5f);
                writeLine("|0aCORRECT");
                score++;
            }
            else
            {
                beep(900, 0.5f);
                writeLine("|04INCORRECT");
            }
            wait(1);
            writeLine("|80Your current score is: " + score);
            wait(3);
            clear();


            writeLine("Question 8:  How many players, including the goaltender, make up an ice hockey team?");
            wait(1);
            writeLine("[A] 1");
            wait(.5);
            writeLine("[B] 7");
            wait(.5);
            writeLine("[C] 8");
            wait(.5);
            writeLine("[D] 6");
            wait(.5);
            writeLine("Answere: ");
            String qes8 = getInput();
            if (qes8 == "d" || qes8 == "D")
            {
                beep(9000, 0.5f);
                writeLine("|0aCORRECT");
                score++;
            }
            else
            {
                beep(900, 0.5f);
                writeLine("|04INCORRECT");
            }
            wait(1);
            writeLine("|80Your current score is: " + score);
            wait(3);
            clear();

            writeLine("Question 9:  In the 1995–96 season, who scored 114 goals in 29 games for Everton’s under-10s and 11s? ");
            wait(1);
            writeLine("[A] Christiano Ronaldo");
            wait(.5);
            writeLine("[B] Lionel Messi");
            wait(.5);
            writeLine("[C] Harry Kane");
            wait(.5);
            writeLine("[D] Wayne Rooney");
            wait(.5);
            writeLine("Answere: ");
            String qes9 = getInput();
            if (qes9 == "d" || qes9 == "D")
            {
                beep(9000, 0.5f);
                writeLine("|0aCORRECT");
                score++;
            }
            else
            {
                beep(900, 0.5f);
                writeLine("|04INCORRECT");
            }
            wait(1);
            writeLine("|80Your current score is: " + score);
            wait(3);
            clear();

            writeLine("Question 10:  After retiring as a player, with which team did baseball great Babe Ruth spend one year as a coach?");
            wait(1);
            writeLine("[A] Dodgers");
            wait(.5);
            writeLine("[B] Yankees");
            wait(.5);
            writeLine("[C] Red Sox");
            wait(.5);
            writeLine("[D] Twins");
            wait(.5);
            writeLine("Answere: ");
            String qes10 = getInput();
            if (qes10 == "a" || qes10 == "A")
            {
                beep(9000, 0.5f);
                writeLine("|0aCORRECT");
                score++;
            }
            else
            {
                beep(900, 0.5f);
                writeLine("|04INCORRECT");
            }
            wait(1);
            writeLine("|80Your current score is: " + score);
            wait(3);
            clear();


            writeLine("Question 11:  What number did NBA star Kobe Bryant wear?");
            wait(1);
            writeLine("[A] 24");
            wait(.5);
            writeLine("[B] 7");
            wait(.5);
            writeLine("[C] 24 and 8");
            wait(.5);
            writeLine("[D] 8");
            wait(.5);
            writeLine("Answere: ");
            String qes11 = getInput();
            if (qes11 == "c" || qes11 == "C")
            {
                beep(9000, 0.5f);
                writeLine("|0aCORRECT");
                score++;
            }
            else
            {
                beep(900, 0.5f);
                writeLine("|04INCORRECT");
            }
            wait(1);
            writeLine("|80Your current score is: " + score);
            wait(3);
            clear();

            writeLine("Question 12:  Who won the most recent MLB World Series");
            wait(1);
            writeLine("[A] Dodgers");
            wait(.5);
            writeLine("[B] Yankees");
            wait(.5);
            writeLine("[C] Red Sox");
            wait(.5);
            writeLine("[D] Twins");
            wait(.5);
            writeLine("Answere: ");
            String qes12 = getInput();
            if (qes12 == "c" || qes12 == "C")
            {
                beep(9000, 0.5f);
                writeLine("|0aCORRECT");
                score++;
            }
            else
            {
                beep(900, 0.5f);
                writeLine("|04INCORRECT");
            }
            wait(1);
            writeLine("|80Your current score is: " + score);
            wait(3);
            clear();


            writeLine("Question 13:  Jan-Ove Waldner, Zhang Jike and Deng Yaping have been noteable players in which sport? ");
            wait(1);
            writeLine("[A] Soccer");
            wait(.5);
            writeLine("[B] Tennis");
            wait(.5);
            writeLine("[C] golf ");
            wait(.5);
            writeLine("[D] Table Tennis");
            wait(.5);
            writeLine("Answere: ");
            String qes13 = getInput();
            if (qes13 == "d" || qes13 == "D")
            {
                beep(9000, 0.5f);
                writeLine("|0aCORRECT");
                score++;
            }
            else
            {
                beep(900, 0.5f);
                writeLine("|04INCORRECT");
            }
            wait(1);
            writeLine("|80Your current score is: " + score);
            wait(3);
            clear();


            writeLine("Question 14:  What is El Clasico?");
            wait(1);
            writeLine("[A] Game between Manchester City and Manchester United");
            wait(.5);
            writeLine("[B] Game between Real Madrid and Barcelona");
            wait(.5);
            writeLine("[C] Tennis tournament ");
            wait(.5);
            writeLine("[D] Bowling match with high prize money");
            wait(.5);
            writeLine("Answere: ");
            String qes14 = getInput();
            if (qes14 == "b" || qes14 == "B")
            {
                beep(9000, 0.5f);
                writeLine("|0aCORRECT");
                score++;
            }
            else
            {
                beep(900, 0.5f);
                writeLine("|04INCORRECT");
            }
            wait(1);
            writeLine("|80Your current score is: " + score);
            wait(3);
            clear();

            writeLine("Question 15:  What is the most popular sport");
            wait(1);
            writeLine("[A] Baseball");
            wait(.5);
            writeLine("[B] Soccer");
            wait(.5);
            writeLine("[C] Cricket");
            wait(.5);
            writeLine("[D] Racing");
            wait(.5);
            writeLine("Answere: ");
            String qes15 = getInput();
            if (qes15 == "b" || qes15 == "B")
            {
                beep(9000, 0.5f);
                writeLine("|0aCORRECT");
                score++;
            }
            else
            {
                beep(900, 0.5f);
                writeLine("|04INCORRECT");
            }
            wait(1);
            writeLine("|80Your current score is: " + score);
            wait(3);
            clear();

            writeLine("Congradulations on finishing the sports trivia !");
            wait(.5);
            writeLine("Your final score was ");
            wait(.5);
            writeLine(".");
            wait(.5);
            writeLine(".");
            wait(.5);
            writeLine(".");
            wait(.5);
            writeLine(score + " out of 15" );
            wait(1);
            if(score == 15)
            {
                writeLine("WOW, PERFECT SCORE");
                
            }
            else if (score >= 10 &&  score <= 14)
            {
                writeLine("Thats pretty good, you know your stuff");
            }
            else if (score > 5 && score <= 9)
            {
                writeLine("Thats okay, could improve");
            }
            else if (score <= 5)
            {
                writeLine("Come on, did you even try??");
            }
            wait(2);
            writeLine("|b0THANKS FOR PLAYING");
            wait(2);

            
        }

    }
}
