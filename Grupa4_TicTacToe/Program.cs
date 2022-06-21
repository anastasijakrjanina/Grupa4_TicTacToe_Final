//1. Noteikt dalībnieku skaitu un tipu:
//spēlētāju skaits 2 :
//spēlētāju tips:
// game with friend  // labāk uztaisīt tikai vienu no sākuma, piemēram, cilvēks pret cilvēku
// -random player
// -computer
 
//2.izvēlas simbolu // good to have // Labāk uzreiz ņemt default X, bez izvēles
//
//spēlētājs izvēlas spēles simboliu (X vai O)
//
 
 
//3.Izvēlas *spēles līmeņi - viegls (3x3)
 
//4. Spēles noteikumi
//4.1 Sāk spēlētājs ar simbolu X, var veikt tikai vienu gājiemu viena reizē, gājiens pāriet nākošajam spēlētājam
//4.2 Izdarīto gājienu nedrīkst mainīt
//4.3 Nedrīkst izmantot jau aizpildītu lauciņu
//4.4 uzvar spelētājs , kurš pirmais savāc 3 savus simbolus vai nu horizontāli, vai vertikāli, vai pa diognāli
//4.5 Apsveic uzvarētāju
 
//5. Spēle beigusies
//5.1 Sākt jaunu spēli vai turpināt ar to pašu spēlētāju (ja turpina ar to pašu spēlētāju, var izvēlēties simbolu)
 
//
//
 
 
//kā saukt lauciņus:
//A1 etc, 1-9, xrinda y kolonna
 
 
using Grupa4_TicTacToe;

//Welcome screen added
Console.Clear();
GameIntro.Welcome();
Thread.Sleep(3000);
Console.Clear();


string helloPlayer = GameIntro.HelloPlayer;
Console.WriteLine(helloPlayer);


GameIntro.GameRules();
 
GameIntro.GoodLuck();


//ComputerPlayer computerPlayer = new ComputerPlayer();
//computerPlayer.PlayerComputer();
//computerPlayer.GetPlayerName();

HumanPlayer player1 = new HumanPlayer(); // izveidots objetkts
player1.GetPlayerName(); //izsaucam f-ciju GetPlayerName

HumanPlayer player2 = new HumanPlayer();
player2.GetPlayerName();

Thread.Sleep(1000);
Console.Clear();


Console.WriteLine($"Player {player1.Name} is playing with {Symbol.X}");
Console.WriteLine($"Player {player2.Name} is playing with {Symbol.O}");
Console.WriteLine();

int check;
  
//Board started

string[] arr = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

try
{
    do
    {
        Board.ShowBoard(arr);

        Console.WriteLine($"Enter your value from 1 to 9: {player1.Name}");
        bool user1BadInput = false;
        int addedSymbol;

        do
        {
            addedSymbol = int.Parse(Console.ReadLine());
            user1BadInput = arr[addedSymbol - 1] == "X" || arr[addedSymbol - 1] == "O";
            if (user1BadInput)
            {
                Console.WriteLine("This cell is occupied");
                Console.WriteLine("Try again");
                Thread.Sleep(1000);
                Console.Clear();
                Board.ShowBoard(arr);
                Console.WriteLine($"Enter your value from 1 to 9: {player1.Name}");
            }
            else arr[addedSymbol - 1] = "X";
        }
        while (user1BadInput);

        Console.Clear();
        Board.ShowBoard(arr);
        check = CheckWinnner.Winner(arr);

        if (check == 0)
        {
            Console.WriteLine("No win");
            Console.Clear();

            Board.ShowBoard(arr);
            Console.WriteLine($"Enter your value from 1 to 9: {player2.Name}");
            bool user2BadInput = false;

            do
            {
                addedSymbol = int.Parse(Console.ReadLine());
                user2BadInput = arr[addedSymbol - 1] == "X" || arr[addedSymbol - 1] == "O";
                if (user2BadInput)
                {
                    Console.WriteLine("This cell is occupied");
                    Console.WriteLine("Try again");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Board.ShowBoard(arr);
                    Console.WriteLine($"Enter your value from 1 to 9: {player2.Name}");
                }
                else arr[addedSymbol - 1] = "O";
            }
            while (user2BadInput);

            Console.Clear();
            Board.ShowBoard(arr);
            check = CheckWinnner.Winner(arr);
            if (check == 0)
            {
                Console.WriteLine("No win");
                Console.Clear();
            }
            else if (check == -1)
            {
                Console.WriteLine("All cells are occupied. Game over!");
            }
            else Console.WriteLine($"You WON {player2.Name}. Congratulations!");
        }
        else if (check == -1)
        {
            Console.WriteLine("All cells are occupied. Game over!");
        }
        else Console.WriteLine($"You WON {player1.Name}. Congratulations!");
    }

    while (check == 0);
}
catch (FormatException ex)
{
    string formatException = ex.Message;
    Console.WriteLine("You didn't enter number!");
    Console.WriteLine($"Message: {formatException}");
}
catch (IndexOutOfRangeException ex)
{
    string indexOutOfRangeException = ex.Message;
    Console.WriteLine("You Entered number not in 1 to 9!");
    Console.WriteLine($"Message: {indexOutOfRangeException}");
}
