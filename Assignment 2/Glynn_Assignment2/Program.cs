using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Xml.Linq;

class Game
{
    static string p1;
    static string p2;
    static char[] position = {'1','2','3','4','5','6','7','8','9'};
    static int turnNum;
    public static int Main()
    {
        Reset();
        Console.WriteLine("\nWelcome To Tic-Tac-Toe!\nPlease select an option by typing either:");
        Console.WriteLine("\t1. Play Ti-Tac-Toe\n\t2. Exit Program");
        try
        {
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                EnterNames();
            }
            else if (option == 2)
            {
                Console.WriteLine("\nThanks for playing!\n");
                return 0;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("\nNumber is either too large or too small, please select one of the two options.");
            Main();
        }
        catch (FormatException)
        {
            Console.WriteLine("\nInvalid key entry, please select one of the two options.");
            Main();
        }
        return 0;
    }
    public static void EnterNames()
    {
        do
        {
            Console.WriteLine("Enter name for Player 1: ");
            p1 = Console.ReadLine();
            if (p1 == "b")
            {
                Main();
            }
        } while (NameVerify(p1) != false);
        Console.WriteLine("Welcome {0}!", p1);
        do
        {
            Console.WriteLine("Enter name for Player 2: ");
            p2 = Console.ReadLine();
        } while (NameVerify(p2) != false);
        Console.WriteLine("Welcome {0}!", p2);
        Play();
    }
    public static bool NameVerify(string name)
    {
        string pattern = "^[A-Za-z ]+$";
        Regex regex = new Regex(pattern);
        if (regex.IsMatch(name) == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool InputVerify(string pos)
    {
        string pattern = "^[1-9]+$";
        Regex regex = new Regex(pattern);
        if (regex.IsMatch(pos) == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static void Play()
    {
        for (int i = 0; i < 9; i++)
        {
            Board();
            Console.WriteLine("Player " + TurnCheck() + " please enter the number you would like to mark: ");
            string posNumStr = Console.ReadLine();
            do
            {
                try
                {
                    int posNumInt = Convert.ToInt32(posNumStr);
                    position[posNumInt - 1] = BoardMark(TurnCheck());
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nNumber is either too large or too small, please select one of the {0} options available.", 10-turnNum);
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInvalid key entry, please select one of the {0} options available.", 10 - turnNum);
                }
            } while (InputVerify(posNumStr) != false);
            EndCheck(WinCheck());
            turnNum++;
        }
    }
    public static int TurnCheck()
    {
        if (turnNum % 2 == 0)
        {
            return 2;
        }
        else
        {
            return 1;
        }
    }
    public static void Board()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", position[0], position[1], position[2]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", position[3], position[4], position[5]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", position[6], position[7], position[8]);
        Console.WriteLine("     |     |      ");
    }
    public static char BoardMark(int player)
    {
        if (player == 1)
        {
            return 'X';
        }
        else
        {
            return 'O';
        }
    }
    public static int WinCheck()
    {
        if (position[1] == position[2] && position[2] == position[3])       //first row
        {
            return 1;
        }
        else if (position[4] == position[5] && position[5] == position[6])  //second row
        {
            return 1;
        }
        else if (position[6] == position[7] && position[7] == position[8])  //third row
        {
            return 1;
        }
        else if (position[1] == position[4] && position[4] == position[7])  //first column
        {
            return 1;
        }
        else if (position[2] == position[5] && position[5] == position[8])  //second column
        {
            return 1;
        }
        else if (position[3] == position[6] && position[6] == position[9])  //third column
        {
            return 1;
        }
        else if (position[1] == position[5] && position[5] == position[9])  //diagonal L-R U-D
        {
            return 1;
        }
        else if (position[3] == position[5] && position[5] == position[7])  //diagonal L-R D-U
        {
            return 1;
        }
        //check for tie
        else if (position[1] != '1' && position[2] != '2' && position[3] != '3' && position[4] != '4' && position[5] != '5' && position[6] != '6' && position[7] != '7' && position[8] != '8' && position[9] != '9')
        {
            return 2;
        }
        else
        {
            return 0;
        }
    }
    public static void EndCheck(int status)
    {
        if (status == 1)
        {
            Console.WriteLine("");
        }
        if (status == 2)
        {
            Console.WriteLine(" _____                     \r\n |  __ \\                    \r\n | |  | |_ __ __ ___      __\r\n | |  | | '__/ _` \\ \\ /\\ / /\r\n | |__| | | | (_| |\\ V  V / \r\n |_____/|_|  \\__,_| \\_/\\_/  \r\n                            \r\n                            ");
        }
    }
    public static void Reset()
    {
        p1 = "";
        p2 = "";
        char [] position = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        turnNum = 1;
    }
}
