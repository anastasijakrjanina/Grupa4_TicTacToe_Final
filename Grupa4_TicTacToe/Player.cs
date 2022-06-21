using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupa4_TicTacToe
{
    public class Player
    {

        public string Name { get; set; }

        public bool GetIsNameentered()
        {
            return !string.IsNullOrWhiteSpace(Name);
        }
        public static string IsPlayerNameExist(int num)
        {
           
            if (num % 1 == 0)
            {
                return "True";
            }


            return num.ToString();

        }


        //vai 2 spēlētājs eksistē  ?
        public static string IsPlayer2NameExist(string playerName)
        {
            if (playerName == "Dace" || playerName == "Anastasija" || playerName == "Jev")
            {
                return "True";
            }
            return "False";
        }
    }
}
