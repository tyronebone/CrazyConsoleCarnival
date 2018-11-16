using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class AdvGame : CarnivalGame
    {
        public override string getName()
        {
            return "Tell your Tale Game";
        }

        public override void play()
        {
            showTitle("Welcome this Choice based Adventure Game");
            writeOut("This is a text based game where your fate will be decided by you");
            writeOut("The choices you make will change what happens next in the story, and ultimately the path you go down.");
            writeOut("Your attitude with certain characters will change depending on how you intereact with them");
            wait(2);
            writeOut("There is also a personality score, the more rebellious options you choose the lower your score goes");
            wait(2);
            writeOut("The less rebellious options you choose the higher your score goes.");
            wait(2);
            writeOut("some choices can only be accessed with a very high or low score");
            wait(2);
            writeOut("Are you a [boy] or a [girl]");
            String gender = getOption("boy", "girl");

            if (gender == "boy")
            {
                writeOut("hi");
                String pronoun = "he";
            }
            if (gender == "girl")
            {
                writeOut("hi");
                String pronoun = "she";
            }

            writeOut("What is your name?");
            String name = getInput();
            int money = 0;
            int meter = 0;
            writeOut("Welcome to the game, " + name);
            wait(2);
            writeOut("You are in a world where AI is the dominant existence in the universe");
            wait(2);
            writeOut("Humans are outnumbered by the androids existence 10 to 1");
            wait(2);
            writeOut(name + ", you are part of the 10%");
            wait(2);
            writeOut("Humans do what they can to survive in this world");
            wait(2);
            writeOut("You work in a small human bar.");
            wait(2);
            writeOut("You're required by law to also have oil products for any robots");
            wait(2);
            writeOut("It's friday night. Your shift has just ended, but your boss tells you he needs some extra hands tonight, and will pay you overtime");
            wait(2);
            writeOut("Do you [work] or [leave]");
            String opt1 = getOption("work", "leave");

            if (opt1 == "work")
            {
                writeLine("|e0You decided to work longer|");
                wait(2);
                money = +200;
                writeOut("You now have " + money + " dollars");
                wait(2);
                writeOut("A new face, Roger, walks in and asks for some beer");
                wait(2);
                writeOut("Turns out he's new in the area. He doesn't particularly like drinking, but it's a good way to meet some fellow humans.");
                wait(2);
                writeOut("He's a tall and muscular man");
                wait(2);
                writeOut("He says he works in construction, slaving away for the benefit of the androids with nothing in return.");
                wait(2);
                writeOut("Not that any human has the benefit of making some decent money, but you are thankful to, for the most part, have a comfortable and calm job.");
                wait(2);
                writeOut("On his way out he hands you a card with a number on it. \"The new leaders of Ruckersburg\" it says.");
                wait(2);
                writeOut("You've heard of this group, they are a rebellion group trying to restore humans to there former glory");
                wait(2);
                writeOut("You are not particularly convinced by any rebellion groups, but you take the card, serve a few more people, and before you know it the shift is over.");
                int rogera = +3;
                wait(2);

                writeOut("Your attitude with Roger is now " + rogera);
                wait(2);
                writeOut("|e0You got $" + money + " for the night|");

                wait(2);
                writeOut("While at home, the card is taunting you, asking you to call the number");
                wait(2);


                writeOut("Do you [call] or [ignore]");
                wait(2);
                String opt2 = getOption("call", "ignore");
                if (opt2 == "call")
                {
                    meter =+ -3;
                    writeOut("Your personality score is now " + meter);
                    wait(2);
                    writeOut("A deep voiced man picks up the phone");
                    wait(2);
                    writeOut("\"Who gave you this number\" asked the man");
                    wait(2);
                    writeOut("Do you [tell] or [avoid]");
                    String opt3 = getOption("tell", "avoid");
                    if (opt3 == "tell")
                    {
                        writeOut("The man tells you he will be contacting you from this number tonight at 11pm");
                        wait(2);
                        writeOut("the line goes dead");
                        
                        wait(2);
                        writeOut("You can't get that call out of your head");
                        wait(2);
                        writeOut("You spend the evening waiting by your phone");
                        wait(2);
                        writeOut("9:30, 10:00, 10:30, time feels like it has slowed down");
                        wait(2);
                        writeOut("finally, 11:00");
                        wait(2);
                        writeOut("the phone rings and all you here is \"Bigslice park\"");
                        wait(2);
                        writeOut("You know exactly where that is. it's just a couple minute drive from here");
                        wait(2);
                        writeOut("Do you [go] or [stay]");
                        String opt4 = getOption("go", "stay");
                        if (opt4 == "go")

                        {
                            writeOut("You see a hooded man dressed in all black. You can just barely make out his face as Rob");
                            wait(2);
                            writeOut("Rob walks over to you");
                            wait(2);
                            writeOut("\"I knew you had it in you\"");
                            wait(2);
                            writeOut("He tells you to come to his house tommorow morning if you are willing to join the leaders of Ruckersburg");
                            wait(2);
                            writeOut("You head home conflicted on if you should go to that meeting tommorow.");
                            wait(2);
                            writeOut("The night passes by uneventfully as you are able to get a long rest");
                            wait(2);
                            writeOut("You wake up on a Saturday morning with no plans");
                            wait(2);
                            writeLine("You can go to the [park], stay [home], or |e0[meet] with the leaders of Ruckersburg|");
                            wait(2);
                            String optE = getOption("park", "home", "meet");
                            if (optE == "park")
                            {
                                writeOut("|e0You decided to go to Bigslice park|");
                                wait(2);
                                writeOut("There are a few people around, but it's mostly empty");
                                wait(2);
                                writeOut("You spend the day relaxing in the shade with birds chirping above");
                                wait(2);
                                writeOut("On your way home there seems to be some sort of commotion on the street.");
                                wait(2);
                                writeOut("There is a dog riding a bike around town");
                                wait(2);
                                writeOut("You push your way through the crowd to get to the front and there stands an older woman and her dog");
                                wait(2);
                                writeOut("People and robots alike are just throwing money at them");
                                wait(2);
                                writeOut("They are amazed at what this dog can do");
                                wait(2);
                                writeOut("Do you want to donate some money, [yes] or [no]");
                                wait(2);
                                String optF = getOption("yes", "no");
                                if (optF == "yes")
                                {
                                    if (money > 0)
                                    {
                                        money = +-5;
                                        writeOut("You give her 5 dollars");
                                        wait(2);
                                        writeOut("You now have" + money + "dollars");
                                        writeOut("She stops you as you go to walk away");
                                        wait(2);
                                        writeOut(name + "? Is that you?");
                                        wait(2);
                                        writeOut("She says her name is Grace and she worked with your mother");
                                        wait(2);
                                        writeOut("You haven't seen your mother since you were a kid");
                                        wait(2);
                                        writeOut("She has work to do, but she would be happy talking to you later.");
                                        wait(2);
                                        writeOut("She hands you her business card which includes her name, number, and occupation: \"clown\"");
                                        wait(2);
                                        writeOut("When you get home you drop your stuff on the couch, put the business card on the table, and head straight to sleep.");
                                        wait(2);
                                        meter = +2;
                                        writeOut("Your personality meter is now" + meter);
                                    }
                                    else
                                    {
                                        writeOut("You are broke");
                                        writeOut("You now have" + money + "dollars");
                                        wait(2);
                                        writeOut("When you get home you drop your stuff on the couch, put the business card on the table, and head straight to sleep.");
                                        wait(2);
                                        writeLine("|e0You need the first DLC Pack to Continue|");
                                        wait(2);
                                        writeLine("|e0$10 to purchase DLC Pack 1, Comes with dozens of new choices and endings!|");
                                        wait(2);
                                    }

                                    wait(2);
                                }
                                if (optF == "no")
                                {
                                    if (meter > 0)
                                    {
                                        writeOut("Your personality meter is too high for this");
                                        wait(2);
                                        money = +-5;
                                        writeOut("You give her 5 dollars");
                                        wait(2);
                                        writeOut("You now have" + money + "dollars");
                                        writeOut("She stops you as you go to walk away");
                                        wait(2);
                                        writeOut(name + "? Is that you?");
                                        wait(2);
                                        writeOut("She says her name is Grace and she worked with your mother");
                                        wait(2);
                                        writeOut("You haven't seen your mother since you were a kid");
                                        wait(2);
                                        writeOut("She has work to do, but she would be happy talking to you later.");
                                        wait(2);
                                        writeOut("She hands you her business card which includes her name, number, and occupation: \"clown\"");
                                        wait(2);
                                        writeOut("When you get home you drop your stuff on the couch, put the business card on the table, and head straight to sleep.");
                                        wait(2);
                                        writeLine("|e0You need the first DLC Pack to Continue|");
                                        wait(2);
                                        writeLine("|e0$10 to purchase DLC Pack 1, Comes with dozens of new choices and endings!|");
                                        wait(2);
                                    }
                                    else
                                    {
                                        writeOut("You are heartless.");
                                        wait(2);
                                        writeOut("You continue on your way a richer, but lonelier person");
                                        wait(2);
                                        writeOut("When you get home you drop your stuff on the couch, and head straight to sleep.");
                                        wait(2);
                                        writeLine("|e0You need the first DLC Pack to Continue|");
                                        wait(2);
                                        writeLine("|e0$10 to purchase DLC Pack 1, Comes with dozens of new choices and endings!|");
                                        wait(2);
                                    }
                                }

                            }
                            if (optE == "home")
                            {
                                writeOut("You sit at home");
                                wait(2);
                                writeOut("You always sit at home");
                                wait(2);
                                writeOut("You end up having a very boring life doing nothing");
                                wait(2);
                                writeOut("GAME OVER");
                                wait(2);
                                writeOut("INSERT $5 TO REVIVE");
                                wait(2);

                            }
                            if(optE == "meet")
                            {
                                writeLine("|e0You decided to head to the Leaders of Ruckersburg meeting.|");
                                wait(2);
                                writeOut("When you get to Rob's house there are some familiar faces surprisingly");
                                wait(2);
                                writeOut("You see some of your friends from highschool and some regulars at the bar");
                                wait(2);
                                writeOut("from the side of a room you here a voice call to you");
                                wait(2);
                                writeOut(name + "? Is that you?");
                                wait(2);
                                writeOut("She says her name is Grace and she worked with your mother");
                                wait(2);
                                writeOut("You haven't seen your mother since you were a kid");
                                wait(2);
                                writeLine("|e0You need the first DLC Pack to Continue, and find out what happened to your mother!|");
                                wait(2);
                                writeLine("|e0$10 to purchase DLC Pack 1, Comes with dozens of new choices and endings!|");
                                wait(2);

                            }


                        }
                        if (opt4 == "stay")
                        {
                            writeLine("|e0You decide not to go");
                            wait(2);
                            writeLine("You don't wake up the next day");
                            wait(2);
                            writeLine("GAME OVER");
                            wait(2);
                            writeOut("INSERT $5 TO REVIVE");
                            wait(2);

                        }
                    }
                    if (opt3 == "avoid")
                    {
                        //same as ignore path
                        writeOut("the line goes dead");
                        wait(2);
                        writeOut("you call back multiple times, but nobody ever picks up");
                        wait(2);
                        writeOut("You don't wake up the next day");
                        wait(2);
                        writeOut("GAME OVER");
                        wait(2);
                        writeOut("INSERT $5 TO REVIVE");
                        wait(2);
                    }

                }
                if (opt2 == "ignore")
                {
                    meter = +3;
                    writeLine("|e0Your personality score is now " + meter);
                    wait(2);
                    writeOut("You never see Rob again");
                    wait(2);
                    writeOut("You wake up on a Saturday morning with no plans");
                    wait(2);
                    writeOut("You can go to the [park] or stay [home]");
                    wait(2);
                    String optE = getOption("park", "home");
                    if (optE == "park")
                    {
                        writeOut("|e0You decided to go to Bigslice park|");
                        wait(2);
                        writeOut("There are a few people around, but it's mostly empty");
                        wait(2);
                        writeOut("You spend the day relaxing in the shade with birds chirping above");
                        wait(2);
                        writeOut("On your way home there seems to be some sort of commotion on the street.");
                        wait(2);
                        writeOut("There is a dog riding a bike around town");
                        wait(2);
                        writeOut("You push your way through the crowd to get to the front and there stands an older woman and her dog");
                        wait(2);
                        writeOut("People and robots alike are just throwing money at them");
                        wait(2);
                        writeOut("They are amazed at what this dog can do");
                        wait(2);
                        writeOut("Do you want to donate some money, [yes] or [no]");
                        wait(2);
                        String optF = getOption("yes", "no");
                        if (optF == "yes")
                        {
                            if (money > 0)
                            {
                                money = +-5;
                                writeOut("You give her 5 dollars");
                                wait(2);
                                writeOut("You now have" + money + "dollars");
                                writeOut("She stops you as you go to walk away");
                                wait(2);
                                writeOut(name + "? Is that you?");
                                wait(2);
                                writeOut("She says her name is Grace and she worked with your mother");
                                wait(2);
                                writeOut("You haven't seen your mother since you were a kid");
                                wait(2);
                                writeOut("She has work to do, but she would be happy talking to you later.");
                                wait(2);
                                writeOut("She hands you her business card which includes her name, number, and occupation: \"clown\"");
                                wait(2);
                                writeOut("When you get home you drop your stuff on the couch, put the business card on the table, and head straight to sleep.");
                                wait(2);
                                meter = +2;
                                writeOut("Your personality meter is now" + meter);
                                writeLine("|e0You need the first DLC Pack to Continue|");
                                wait(2);
                                writeLine("|e0$10 to purchase DLC Pack 1, Comes with dozens of new choices and endings!|");
                                wait(2);
                            }
                            else
                            {
                                writeOut("You are broke");
                                writeOut("You now have" + money + "dollars");
                                wait(2);
                                writeOut("When you get home you drop your stuff on the couch, put the business card on the table, and head straight to sleep.");
                                wait(2);
                                writeLine("|e0You need the first DLC Pack to Continue|");
                                wait(2);
                                writeLine("|e0$10 to purchase DLC Pack 1, Comes with dozens of new choices and endings!|");
                                wait(2);
                            }

                            wait(2);
                        }
                        if (optF == "no")
                        {
                            if (meter > 0)
                            {
                                writeOut("Your personality meter is too high for this");
                                wait(2);
                                money = +-5;
                                writeOut("You give her 5 dollars");
                                wait(2);
                                writeOut("You now have" + money + "dollars");
                                writeOut("She stops you as you go to walk away");
                                wait(2);
                                writeOut(name + "? Is that you?");
                                wait(2);
                                writeOut("She says her name is Grace and she worked with your mother");
                                wait(2);
                                writeOut("You haven't seen your mother since you were a kid");
                                wait(2);
                                writeOut("She has work to do, but she would be happy talking to you later.");
                                wait(2);
                                writeOut("She hands you her business card which includes her name, number, and occupation: \"clown\"");
                                wait(2);
                                writeOut("When you get home you drop your stuff on the couch, put the business card on the table, and head straight to sleep.");
                                wait(2);
                                writeLine("|e0You need the first DLC Pack to Continue|");
                                wait(2);
                                writeLine("|e0$10 to purchase DLC Pack 1, Comes with dozens of new choices and endings!|");
                                wait(2);
                            }
                            else
                            {
                                writeOut("You are heartless.");
                                wait(2);
                                writeOut("You continue on your way a richer, but lonelier person");
                                wait(2);
                                writeOut("When you get home you drop your stuff on the couch, and head straight to sleep.");
                                wait(2);
                                writeLine("|e0You need the first DLC Pack to Continue|");
                                wait(2);
                                writeLine("|e0$10 to purchase DLC Pack 1, Comes with dozens of new choices and endings!|");
                                wait(2);
                            }
                        }

                    }
                    if (optE == "home")
                    {
                        writeOut("You sit at home");
                        wait(2);
                        writeOut("You always sit at home");
                        wait(2);
                        writeOut("You end up having a very boring life doing nothing");
                        wait(2);
                        writeOut("GAME OVER");
                        wait(2);
                        writeOut("INSERT $5 TO REVIVE");
                        wait(2);

                    }
                }
            }
            if (opt1 == "leave")
            {
                writeLine("|e0You decided to leave");
                money = +150;
                writeOut("You got $" + money + " for the night");
                wait(2);
                writeOut("On your way home you hear someone calling for you from down the dark alley");
                wait(2);
                writeOut("Do you want to [follow] the voice or [ignore] it?");
                String optA = getOption("follow", "ignore");
                if (optA == "follow")
                {
                    wait(2);
                    writeOut("On your way to investigating the sound you notice an open door with a bit of light creeping out");
                    wait(2);
                    writeOut("you walk in");
                    wait(2);
                    writeOut("There is a small persian cat sleeping in the middle of the room");
                    wait(2);
                    writeOut("There is an old woman rocking back and forth and she jumps when she notices you.");
                    wait(2);
                    writeOut("How did you get in here, she says.");
                    wait(2);
                    writeOut("I heard a voice and the door was wide open. It looked like this building was deserted");
                    wait(2);
                    writeOut("As soon as she hears that she hurries to close the door, ignoring you for the moment.");
                    wait(2);
                    writeOut("one her way to the door you hear the voice again.");
                    wait(2);
                    writeOut("it sounds angrier and louder. It's like the person is trying to taunt you.");
                    wait(2);
                    writeOut("The woman seems to hear this as well and instantly slams the door shuts and locks it.");
                    wait(2);
                    writeOut("The cat jumps up, now awake.");
                    wait(2);
                    writeOut("You cannot leave anymore, she says.");
                    wait(2);
                    writeOut("You try to question her, but she refuses to say anything.");
                    wait(2);
                    writeOut("minutes pass and you begin thinking about leaving");
                    wait(2);
                    writeOut("On your way out the old lady tries to stand");

                    wait(2);
                    writeOut("She collapses onto the ground and begs you not to leave.");
                    wait(2);
                    writeOut("do you [leave] or [question] her further");
                    String optB = getOption("leave", "question");
                    if (optB == "leave")
                    {
                        writeOut("You ignore her pleas and open the door.");
                        wait(2);
                        writeOut("As you walk out of the alley you hear the cries of desperation form the old lady.");
                        wait(2);
                        writeOut("A bullet flies past you and as you turn your head to look what just happened you see two large robots sprinting at you.");
                        wait(2);
                        writeOut("You run as fast as your legs can carry you, but when you look back there is nothing.");
                        wait(2);
                        writeOut("in the distance you hear a gunshot");
                        wait(2);
                        writeOut("then the screech of a cat");
                        wait(2);
                        writeOut("then another gunshot");
                        wait(2);
                        writeOut("Congratulations, you're a monster");
                        wait(2);
                        meter = +-10;
                        writeOut("|e0Your personality score is now|" + meter);
                        writeLine("|e0You need the first DLC Pack to Continue|");
                        wait(2);
                        writeLine("|e0$10 to purchase DLC Pack 1, Comes with dozens of new choices and endings!|");
                        wait(2);

                    }
                    if (optB == "question")
                    {
                        writeOut("|e0You continue to press her for answers|");
                        wait(2);
                        writeOut("She finally gives in and tells you what's happening");
                        wait(2);
                        writeOut("There is a group robots that believe they are superior over any other species, including human");
                        wait(2);
                        writeOut("Some of them get very extreme even going as far to kill any humans they can find");
                        wait(2);
                        writeOut("There are rumors that there is a group in the city right now actively seeking out people they can exterminate");
                        wait(2);
                        writeOut("They're very careful and coordinated and will even set up traps to lure others out.");
                        wait(2);
                        writeOut("She has been hiding in her house once the sun falls as to protect herself.");
                        wait(2);
                        writeOut("She says you cannot leave for tonight and offers you a room to stay in.");
                        wait(2);
                        writeOut("do you [leave] right now or [stay] for the night");
                        String optC = getOption("leave", "stay");
                        if (optC == "leave")
                        {
                            writeOut("|e0You decide to leave against the advice of the old lady|");
                            wait(2);
                            writeOut("She can't force you to stay, so she just makes sure to lock the door on your way out");
                            wait(2);
                            writeOut("On your way out of the alley a pair of guys approach you with hoods covering their face.");
                            wait(2);
                            writeOut("You notice they both have their hands on guns in their pocket.");
                            wait(2);
                            writeOut("You decide to duck behind the corner of the alley");
                            wait(2);
                            writeOut("A bullet flies past you and as you turn your head to look what just happened you see two large robots sprinting at you.");
                            wait(2);
                            writeOut("You run as fast as your legs can carry you, but when you look back there is nothing.");
                            wait(2);
                            writeOut("They didn't seem to want to wander too far from that area.");
                            wait(2);
                            writeOut("On your way back home you wonder what happened to that old lady");
                            wait(2);
                            writeOut("It's saturday, so there is no work to do.");
                            wait(2);


                        }
                        if (optC == "stay")
                        {
                            writeOut("You stay in the old lady's house for the night");
                            wait(2);
                            writeOut("It's a peaceful place, but with not much going on. No internet. No TV. Nothing to do");
                            wait(2);
                            writeOut("You head to sleep early");
                            wait(2);
                            writeOut("You wake up to loud banging outside on the door");
                            wait(2);
                            writeOut("You hear from the outside \"I can see the lights on\"");
                            wait(2);
                            writeOut("Do you [open] the door or [ignore] the man");
                            wait(2);
                            String optD = getOption("open", "ignore");
                            if (optD == "open")
                            {
                                writeOut("There is a gunshot and your vision goes black");
                                wait(2);
                                writeOut("GAME OVER");
                                wait(2);
                                writeOut("INSERT $5 TO REVIVE");
                                wait(2);

                            }
                            if (optD == "ignore")
                            {
                                writeOut("You ignore what the man says for the time being");
                                wait(2);
                                writeOut("A few hours pass");
                                wait(2);
                                writeOut("You share some parting words with the old lady and get on your way.");
                                wait(2);
                                meter = +10;
                                writeOut("Your personality score is now " + meter);
                                wait(2);
                                writeOut("It's saturday, so there is no work to do.");
                                wait(2);
                                writeOut("You can go to the [park] or stay [home]");
                                wait(2);
                                String optE = getOption("park", "home");
                                if (optE == "park")
                                {
                                    writeOut("|e0You decided to go to Bigslice park|");
                                    wait(2);
                                    writeOut("There are a few people around, but it's mostly empty");
                                    wait(2);
                                    writeOut("You spend the day relaxing in the shade with birds chirping above");
                                    wait(2);
                                    writeOut("On your way home there seems to be some sort of commotion on the street.");
                                    wait(2);
                                    writeOut("There is a dog riding a bike around town");
                                    wait(2);
                                    writeOut("You push your way through the crowd to get to the front and there stands an older woman and her dog");
                                    wait(2);
                                    writeOut("People and robots alike are just throwing money at them");
                                    wait(2);
                                    writeOut("They are amazed at what this dog can do");
                                    wait(2);
                                    writeOut("Do you want to donate some money, [yes] or [no]");
                                    wait(2);
                                    String optF = getOption("yes", "no");
                                    if (optF == "yes")
                                    {
                                        if (money > 0)
                                        {
                                            money = +-5;
                                            writeOut("You give her 5 dollars");
                                            wait(2);
                                            writeOut("You now have" + money + "dollars");
                                            writeOut("She stops you as you go to walk away");
                                            wait(2);
                                            writeOut(name + "? Is that you?");
                                            wait(2);
                                            writeOut("She says her name is Grace and she worked with your mother");
                                            wait(2);
                                            writeOut("You haven't seen your mother since you were a kid");
                                            wait(2);
                                            writeOut("She has work to do, but she would be happy talking to you later.");
                                            wait(2);
                                            writeOut("She hands you her business card which includes her name, number, and occupation: \"clown\"");
                                            wait(2);
                                            writeOut("When you get home you drop your stuff on the couch, put the business card on the table, and head straight to sleep.");
                                            wait(2);
                                            meter = +2;
                                            writeOut("Your personality meter is now" + meter);
                                            writeLine("|e0You need the first DLC Pack to Continue|");
                                            wait(2);
                                            writeLine("|e0$10 to purchase DLC Pack 1, Comes with dozens of new choices and endings!|");
                                            wait(2);
                                        }
                                        else
                                        {
                                            writeOut("You are broke");
                                            writeOut("You now have" + money + "dollars");
                                            wait(2);
                                            writeOut("When you get home you drop your stuff on the couch, and head straight to sleep.");
                                            wait(2);
                                            writeLine("|e0You need the first DLC Pack to Continue|");
                                            wait(2);
                                            writeLine("|e0$10 to purchase DLC Pack 1, Comes with dozens of new choices and endings!|");
                                            wait(2);
                                        }

                                        wait(2);
                                    }
                                    if (optF == "no")
                                    {
                                        if (meter > 0)
                                        {
                                            writeOut("Your personality meter is too high for this");
                                            wait(2);
                                            money = +-5;
                                            writeOut("You give her 5 dollars");
                                            wait(2);
                                            writeOut("You now have" + money + "dollars");
                                            writeOut("She stops you as you go to walk away");
                                            wait(2);
                                            writeOut(name + "? Is that you?");
                                            wait(2);
                                            writeOut("She says her name is Grace and she worked with your mother");
                                            wait(2);
                                            writeOut("You haven't seen your mother since you were a kid");
                                            wait(2);
                                            writeOut("She has work to do, but she would be happy talking to you later.");
                                            wait(2);
                                            writeOut("She hands you her business card which includes her name, number, and occupation: \"clown\"");
                                            wait(2);
                                            writeOut("When you get home you drop your stuff on the couch, put the business card on the table, and head straight to sleep.");
                                            wait(2);
                                            writeLine("|e0You need the first DLC Pack to Continue|");
                                            wait(2);
                                            writeLine("|e0$10 to purchase DLC Pack 1, Comes with dozens of new choices and endings!|");
                                            wait(2);

                                        }
                                        else
                                        {
                                            writeOut("You are heartless.");
                                            wait(2);
                                            writeOut("You continue on your way a richer, but lonelier person");
                                            wait(2);
                                            writeOut("When you get home you drop your stuff on the couch, and head straight to sleep.");
                                            wait(2);
                                            writeLine("|e0You need the first DLC Pack to Continue|");
                                            wait(2);
                                            writeLine("|e0$10 to purchase DLC Pack 1, Comes with dozens of new choices and endings!|");
                                            wait(2);
                                        }
                                    }

                                }
                                if (optE == "home")
                                {
                                    writeOut("You sit at home");
                                    wait(2);
                                    writeOut("You always sit at home");
                                    wait(2);
                                    writeOut("You end up having a very boring life doing nothing");
                                    wait(2);
                                    writeOut("GAME OVER");
                                    wait(2);
                                    writeOut("INSERT $5 TO REVIVE");
                                    wait(2);

                                }


                            }

                        }
                    }


                }
                if (optA == "ignore")
                {
                    writeOut("You decide to ignore the noises and continue on your way.");
                    wait(2);
                    
                    writeOut("You wake up on a Saturday morning with no plans");
                    wait(2);
                    writeOut("You can go to the [park] or stay [home]");
                    wait(2);
                    String optE = getOption("park", "home");
                    if (optE == "park")
                    {
                        writeOut("|e0You decided to go to Bigslice park|");
                        wait(2);
                        writeOut("There are a few people around, but it's mostly empty");
                        wait(2);
                        writeOut("You spend the day relaxing in the shade with birds chirping above");
                        wait(2);
                        writeOut("On your way home there seems to be some sort of commotion on the street.");
                        wait(2);
                        writeOut("There is a dog riding a bike around town");
                        wait(2);
                        writeOut("You push your way through the crowd to get to the front and there stands an older woman and her dog");
                        wait(2);
                        writeOut("People and robots alike are just throwing money at them");
                        wait(2);
                        writeOut("They are amazed at what this dog can do");
                        wait(2);
                        writeOut("Do you want to donate some money, [yes] or [no]");
                        wait(2);
                        String optF = getOption("yes", "no");
                        if (optF == "yes")
                        {
                            if (money > 0)
                            {
                                money = +-5;
                                writeOut("You give her 5 dollars");
                                wait(2);
                                writeOut("You now have" + money + "dollars");
                                writeOut("She stops you as you go to walk away");
                                wait(2);
                                writeOut(name + "? Is that you?");
                                wait(2);
                                writeOut("She says her name is Grace and she worked with your mother");
                                wait(2);
                                writeOut("You haven't seen your mother since you were a kid");
                                wait(2);
                                writeOut("She has work to do, but she would be happy talking to you later.");
                                wait(2);
                                writeOut("She hands you her business card which includes her name, number, and occupation: \"clown\"");
                                wait(2);
                                writeOut("When you get home you drop your stuff on the couch, put the business card on the table, and head straight to sleep.");
                                wait(2);
                                meter = +2;
                                writeOut("Your personality meter is now" + meter);
                                writeLine("|e0You need the first DLC Pack to Continue|");
                                wait(2);
                                writeLine("|e0$10 to purchase DLC Pack 1, Comes with dozens of new choices and endings!|");
                                wait(2);
                            }
                            else
                            {
                                writeOut("You are broke");
                                writeOut("You now have" + money + "dollars");
                                wait(2);
                                writeOut("When you get home you drop your stuff on the couch, and head straight to sleep.");
                                wait(2);
                                writeLine("|e0You need the first DLC Pack to Continue|");
                                wait(2);
                                writeLine("|e0$10 to purchase DLC Pack 1, Comes with dozens of new choices and endings!|");
                                wait(2);
                            }

                            wait(2);
                        }
                        if (optF == "no")
                        {
                            if (meter > 0)
                            {
                                writeOut("Your personality meter is too high for this");
                                wait(2);
                                money = +-5;
                                writeOut("You give her 5 dollars");
                                wait(2);
                                writeOut("You now have" + money + "dollars");
                                writeOut("She stops you as you go to walk away");
                                wait(2);
                                writeOut(name + "? Is that you?");
                                wait(2);
                                writeOut("She says her name is Grace and she worked with your mother");
                                wait(2);
                                writeOut("You haven't seen your mother since you were a kid");
                                wait(2);
                                writeOut("She has work to do, but she would be happy talking to you later.");
                                wait(2);
                                writeOut("She hands you her business card which includes her name, number, and occupation: \"clown\"");
                                wait(2);
                                writeOut("When you get home you drop your stuff on the couch, put the business card on the table, and head straight to sleep.");
                                wait(2);
                                writeLine("|e0You need the first DLC Pack to Continue|");
                                wait(2);
                                writeLine("|e0$10 to purchase DLC Pack 1, Comes with dozens of new choices and endings!|");
                                wait(2);

                            }
                            else
                            {
                                writeOut("You are heartless.");
                                wait(2);
                                writeOut("You continue on your way a richer, but lonelier person");
                                wait(2);
                                writeOut("When you get home you drop your stuff on the couch, and head straight to sleep.");
                                wait(2);
                                writeLine("|e0You need the first DLC Pack to Continue|");
                                wait(2);
                                writeLine("|e0$10 to purchase DLC Pack 1, Comes with dozens of new choices and endings!|");
                                wait(2);
                            }
                        }

                    }
                    if (optE == "home")
                    {
                        writeOut("You sit at home");
                        wait(2);
                        writeOut("You always sit at home");
                        wait(2);
                        writeOut("You end up having a very boring life doing nothing");
                        wait(2);
                        writeOut("GAME OVER");
                        wait(2);
                        writeOut("INSERT $5 TO REVIVE");
                        wait(2);

                    }

                }

            }


        }
    }
}
