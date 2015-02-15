using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SequenceSolver
{

    class Program
    {
        static void Main(string[] args)
        {
            //Preserve current console text color
            ConsoleColor oldColor = Console.ForegroundColor;

            title();
            Console.WriteLine(" ");

            while(true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter the first term of your sequence: ");

                int a = SequenceObjObtain();

                //Check the user has completed an input
                //if (a == null)
                //{
                //    Console.WriteLine("You need to type in a number");
                //    continue;
                //}

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter the second term of your sequence: ");

                int U2 = SequenceObjObtain();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter the third term of your sequence: ");

                int U3 = SequenceObjObtain();

                int d = U2 - a;
                int U0 = a - d;

                if(U3-U2 == d)
                {
                    string equation = String.Format("{0}n + {1}", d, U0);
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("The equation for this sequence is: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(equation);
                    Console.ForegroundColor = ConsoleColor.DarkGray;

                    Console.WriteLine("Do you want to solve another sequence? Yes or No?");
                    string replay = AnswerObtain();

                    if (replay.ToLower() == "yes")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("That is a not an arithmetic sequence, please enter an arithmetic sequence");

                }

                
            }
            //Cleanup
            Console.ForegroundColor = oldColor;
        }

        /// <summary>
        /// Will print name of program and creator to console
        /// </summary>
        static void title()
        {
            //Change console text color
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Algorithmic Sequence Solver (by: Mayank)");
        }

        //This function will return text of user
        static int SequenceObjObtain()
        {
            // This block of code will ask the user for a question
            // and store the question text in questionString variable
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int sequenceobj = int.Parse(Console.ReadLine());
            
            return sequenceobj;
        }

        static string AnswerObtain()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string ans = Console.ReadLine();

            return ans;
        }
    }

}