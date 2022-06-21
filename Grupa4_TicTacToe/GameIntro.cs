using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupa4_TicTacToe
{
    internal class GameIntro
    {
        public static string HelloPlayer = "Hello, let's start the game!";

        public static void GameRules()
        {
            Console.WriteLine();
            Console.WriteLine("Game rules:");
            Console.WriteLine("1.Must be two players, choose your opponent");
            Console.WriteLine("2.Start player with symbol 'X' ");
            Console.WriteLine("3.Field cannot be overwriten");
            Console.WriteLine("4.Can't change move");
            Console.WriteLine("5.Winner is player who first set 3 same symbols horizontaly/verticaly/diagonally");
            Console.WriteLine();
        }

        public static void GoodLuck()
        {

            Console.WriteLine("Good luck, player!");
            Console.WriteLine();
        }

        public static void Welcome()
        {
            Console.WriteLine("  #####                              #                       ");
            Console.WriteLine(" #     # #####   ####  #    # #####  #    #                  ");
            Console.WriteLine(" #       #    # #    # #    # #    # #    #                  ");
            Console.WriteLine(" #  #### #    # #    # #    # #    # #    #                  ");
            Console.WriteLine(" #     # #####  #    # #    # #####  #######                 ");
            Console.WriteLine(" #     # #   #  #    # #    # #           #                  ");
            Console.WriteLine("  #####  #    #  ####   ####  #           #                  ");
            Console.WriteLine("                                                             ");
            Console.WriteLine(" #######          #######               #######              ");
            Console.WriteLine("    #    #  ####     #      ##    ####     #     ####  ######");
            Console.WriteLine("    #    # #    #    #     #  #  #    #    #    #    # #     ");
            Console.WriteLine("    #    # #         #    #    # #         #    #    # ##### ");
            Console.WriteLine("    #    # #         #    ###### #         #    #    # #     ");
            Console.WriteLine("    #    # #    #    #    #    # #    #    #    #    # #     ");
            Console.WriteLine("    #    #  ####     #    #    #  ####     #     ####  ######");
        }

    }
}

