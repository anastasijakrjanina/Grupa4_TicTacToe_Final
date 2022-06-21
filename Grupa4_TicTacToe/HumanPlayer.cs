using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupa4_TicTacToe
{
    public class HumanPlayer : Player
    {
        public void GetPlayerName()
        {
            Console.WriteLine();
            Console.Write("Player please enter Your name: ");
            Name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(Name))
            {
                Console.WriteLine("You did not enter your name. Try again.");
                Name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(Name))
                {
                    Console.WriteLine("No more tries");

                }
                else
                {
                    Console.WriteLine($"Hi {Name}.");
                }
            }
            else
            {
                Console.WriteLine($"Hi {Name}.");
            }


        }

    }
}
