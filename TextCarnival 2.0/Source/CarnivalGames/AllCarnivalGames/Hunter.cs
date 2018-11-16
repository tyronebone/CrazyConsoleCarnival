using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class Hunter : CarnivalGame
    {
        public Hunter() : base()
        {
            
        }

        public override string getName()
        {
            return "Ghoul House";
        }
        
        public override void play()
        {
            showTitle("BEWARE FOR YOU HAVE ENTERED THE HOUSE OF THE GHOUL");
            writeLine("to make choices, press the number key corresponding to your choice.");
            writeLine("press spacebar to begin");

            //put wait()'s inbetween all lines?
            if (getKey() == ConsoleKey.Spacebar)
            {
                clear();
                writeLine("You're going Trick-or-Treating with a friend, Carl");
                writeLine("Being the dare-devil that he is, he suggests going to Old Man Jenkins' house at the end of the block.");
                writeLine("[You say...]");
                writeLine("1. I don't know, that house gives me a bad feeling.");
                writeLine("2. Let's go! I haven't seen him in forever, do you think he's still alive?");
                if (getKey() == ConsoleKey.D1)
                {
                    clear();
                    writeLine("Carl - Come on, man. Don't wuss out on me like that.");
                    writeLine("Carl - Worst case scenario, he shakes his fist at us as we walk away.");
                    writeLine("You reluctantly accept, starting your walk towards the house.");
                    //wait()
                    writeLine("Carl opens the front door of Old Man Jenkins' house and you both walk in together.");
                    writeLine("The house appears as though it hasn't been inhabited in decades.");
                    writeLine("Everything is covered in a thick layer of dust and cobwebs.");
                    writeLine("Carl - Let's go find Old Man Jenkins!");
                    writeLine("Carl sprints up a staircase and zips out of sight.");
                    writeLine("You weren't that interested to begin with so you just walk after him.");
                    writeLine("Walking up the stairs, you notice old portraits of family hanging on the walls.");
                    writeLine("You reach the top of the stair case and arrive at a long hallway.");
                    writeLine("It's so dark that you can't see the end of the hallway");
                    writeLine("All of a sudden, a blood curdling scream eminates from the end of the hallway.");
                    writeLine("You...");
                    writeLine("1. Run towards the scream to help your friend.");
                    writeLine("2. Turn around and walk away. You didn't like Carl that much anyways.");
                    if (getKey() == ConsoleKey.D1)
                    {
                        clear();
                        writeLine("You rush down to the end of the hallway and hurredly pull open a large wooden door.");
                        writeLine("As the door swings open, the smell of iron fills your lungs and you find your friend on the floor in a pool of blood.");
                        writeLine("A pale, skeleton-like figure is standing over your aquaintence's corpse, eating.");
                        writeLine("Your breath becomes heavy as the figure begins to peer over it's shoulder at you.");
                        writeLine("Immediately, you quickly run back through the hallway and down the stairs, with the light, ghostly footsteps following you.");
                        writeLine("You grab the handle of the front door, but the ghoul grabs your feet and drags you back in.");
                        writeLine("The monster sinks it's teeth into you and tears your flesh from your body.");
                        writeLine("Your vision fades. You have died.");
                        writeLine("GAME OVER");
                        wait(30);
                    }
                    else
                    {
                        clear();
                        writeLine("You start down the stairs, but you hear heavy footsteps coming quickly down the hallway.");
                        writeLine("You quicken your pace and head for the door.");
                        writeLine("You make it to the door, but the handle won't budge. You're trapped.");
                        writeLine("You turn around to find Carl right infront of you holding a large knife.");
                        writeLine("His eyes are rolled back so only the white show, and his neck is red and bloody.");
                        writeLine("Carl plunges his knife deep into your chest without warning.");
                        writeLine("Your vision fades. You have died.");
                        writeLine("GAME OVER");
                        wait(30);
                    }
                }
                else
                {
                    clear();
                    writeLine("Carl - Let's go find out!");
                    writeLine("You both jog down to the end of the block, where Old Man Jenkins' house lies.");
                    writeLine("Carl opens the front door of Old Man Jenkins' house and you both walk in together.");
                    writeLine("As you both walk through, a strong, cold wind hits you coming from the house.");
                    writeLine("The house appears as though it hasn't been inhabited in decades.");
                    writeLine("Everything is covered in a thick layer of dust and cobwebs.");
                    writeLine("Carl walks immediately to the right and opens a door, revealing a staircase to the basement.");
                    writeLine("Carl - Let's see what's down here.");
                    writeLine("You say...");
                    writeLine("1. I don't know, that's actually kinda creepy.");
                    writeLine("2. There's probably some cool old antique stuff down there!");
                    if (getKey() == ConsoleKey.D1)
                    {
                        clear();
                        writeLine("You - I think I'd rather just go home for tonight.");
                        writeLine("Carl - Come on, man.");
                        //wait()
                        writeLine("Carl - Alright, fine. You can go, I'll let you know if I find anything cool tomorrow.");
                        writeLine("You walk out the front door of the house, but before you get a chance to close the door, it slams itself shut.");
                        writeLine("You walk home, but can't help but to feel that something was wrong.");
                        writeLine("You wake up the next morning and go to school");
                        writeLine("Your friends tell you that Carl went missing last night and that nobody can find him.");
                        writeLine("You walk back home after school past Old Man Jenkins' house and it feels like the windows of the house are watching you.");
                        writeLine("Congratulations, you have survived.");
                        writeLine("GAME OVER");
                        wait(30);
                    }
                    else
                    {
                        clear();
                        writeLine("You both descend to the basement.");
                        writeLine("You turn on a hanging lightbulb to discover a small room filled with old furniture, decorations, and toys.");
                        writeLine("Out of nowhere, you hear footsteps coming down the stairs.");
                        writeLine("Thinking that old Man Jenkins is about to catch you, you turn off the light, making it pitch black, and both of you hide behind different furniture.");
                        writeLine("However, as the footsteps reach the bottom, you relize that it's not Old Man Jenkins.");
                        writeLine("The footsteps are heavy and there is a loud, gurgling breathing.");
                        writeLine("As this monster walks into the center of the basement, the sound of its steps and breathing gets quieter and quieter until there's nothing.");
                        //wait()
                        writeLine("*silence*");
                        //wait()
                        writeLine("All of a sudden, you hear Carl getting dragged and scream.");
                        writeLine("His voice dies out quickly as his neck is snapped by this monster and all you can hear in the silence is the sound of an animal eating.");
                        //wait()
                        writeLine("The sound of the monster eating soon fades out as well.");
                        //wait()
                        writeLine("*silence*");
                        //wait()
                        writeLine("You feel a heavy breath over the back of your neck.");
                        writeLine("Befor eyou get a chance to react, you feel your neck snap.");
                        writeLine("You have died.");
                        writeLine("GAME OVER");
                        wait(45);
                    }
                }
            }
        }
    }
}
