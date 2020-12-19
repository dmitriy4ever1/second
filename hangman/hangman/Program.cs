using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman
{
    class Program
    {
        public static int guess = 0;
        public static int guesses = 9;

        static public bool playing = true;
        static string[] gallows = { "+", "|", "|", "|", "|", "|", "|", "|", "|" };
        static string[] person = { "=", "  |", "  |", "  0", " /|\\", "  |", " / \\", "/   \\" };
        static int i = 0;


        public static void hang(int rope)
        {
             int i = 0;

            foreach (string g in gallows)
            {
                if (i < rope)
                    Console.WriteLine(g + person[i++]);
                else
                    Console.WriteLine(g);

                
            }
          
        }

        public static void grim()
        {

                Console.WriteLine("                                                                 .--.._               ");
                Console.WriteLine("                                                                []      `'--.._       ");
                Console.WriteLine("                                                                || __           `'-,  ");
                Console.WriteLine("                                                               )||_ ```'--..       \\ ");
                Console.WriteLine("                                                               /|//}        ``--._  | ");
                Console.WriteLine("                                       .'` `'.                /////}              \\/ ");
                Console.WriteLine("                                      /  .===\\              //}///                   ");
                Console.WriteLine("                                     /  /_  _`\\            // `||                    ");
                Console.WriteLine("                                     | |(_)(_)||          _//   ||                    ");
                Console.WriteLine("                                     | |  /\\ )|        _///\\  ||                    ");
                Console.WriteLine("                                     | |L====J |       / |/ |   ||                    ");
                Console.WriteLine("                                    /  /'-..-' /    .'`  \\ |   ||                    ");
                Console.WriteLine("                                   /   |  :: | |_.-`      | \\  ||                    ");
                Console.WriteLine("                                  /|  `\\ -::.| |         \\   | ||                    ");
                Console.WriteLine("                                /` `|   /    | |          |   / ||                    ");
                Console.WriteLine("                              |`    \\  |    / /         \\  |  ||                    ");
                Console.WriteLine("                              |     `\\_|    |/      ,.__.\\ |  ||                    ");
                Console.WriteLine("                             /                     /`    `\\||  ||                    ");
                Console.WriteLine("                            |           .         /       \\||  ||                    ");
                Console.WriteLine("                            |                     |         |/  ||                    ");
                Console.WriteLine("                            /         /           |         (   ||                    ");
                Console.WriteLine("                           /          .           /          )  ||                    ");
                Console.WriteLine("                          |           \\          |             ||                    ");
                Console.WriteLine("                         /             |          /             ||                    ");
                Console.WriteLine("                        |\\           /          |              ||                    ");
                Console.WriteLine("                       \\ `-._       |           /              ||                    ");
                Console.WriteLine("                       \\ ,//`\\    /`           |              ||                    ");
                Console.WriteLine("                       ///\\  \\  |             \\              ||                    ");
                Console.WriteLine("                      ||||  )  |__/              |            ||                    ");
                Console.WriteLine("                      ||||     /                 |             ||                    ");
                Console.WriteLine("                      ````   /`                  \\            ||                    ");
                Console.WriteLine("                            /`                   /              ||                    ");
                Console.WriteLine("                           /                     |              ||                    ");
                Console.WriteLine("                          |                     \\              ||                    ");
                Console.WriteLine("                         /                        |             ||                    ");
                Console.WriteLine("                        /`                        \\            ||                    ");
                Console.WriteLine("                      /`                           |            ||                    ");
                Console.WriteLine("                      `-.~,~,~,~,~,~,~,~,~,~,~,~,~,'            ||                    ");
                Console.WriteLine("                               '---'     '----'                 ||                    ");


            }
        
        static void Main(string[] args)
            {
                char[][] words = { "congratulations".ToCharArray(), "blamelessness".ToCharArray(), "bloodthirsty".ToCharArray(),
             "boundlessness".ToCharArray(),"cheerlessness".ToCharArray()};


                Random random = new Random();

                int num = random.Next(1, 6);
                //congratulations
                //blamelessness
                //bloodthirsty
                //boundlessness
                //cheerlessness
                char[] word = { ' ' };

                word = words[num - 1];//picking a word


                char[] hidden = "*************".ToCharArray();

                char enteredLetter = ' ';


                int w = word.Length - 1;

                Console.WriteLine("Welcome to hangman you will have 10 tries to find the 15 letter world");

                while (true)
                {
                if (hidden.Contains('*'))
                    playing = true;

                else
                {
                    playing = false;
                    break;
                }
                //draw();
                    if (guesses <= 0)
                    {
                        break;
                    }//breaking loop if lost
                    Console.WriteLine(hidden);
                    Console.WriteLine(guesses + " left");

                    w = word.Length - 1;

                    enteredLetter = char.Parse(Console.ReadLine());

                    for (int i = 0; i <= word.Length - 1; i++)
                    {

                        if (enteredLetter == word[i])
                        {
                            hidden[i] = word[i];
                        }

                    }//if guessed correct revealing the word


                //breaking loop    
                hang(guess);
                    guesses--;

                guess++;

                }//playing hangman
                if (guesses >0)//if won
                {
                    Console.WriteLine("");
                    Console.WriteLine(word);
                    Console.Write("!!!  Thats the word. Congratulations for finding the word.        Press Enter to quit");
                }
                else
                {
                grim();
                    //  Console.WriteLine("");
                    Console.WriteLine(word);
                    Console.Write("Thats the word. Sorry but you didn't guess that word in time.        Press Enter to quit");
                }

                Console.ReadLine();

            }
        
    }
}
