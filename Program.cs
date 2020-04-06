using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Moves game = new Moves();
        }

        public class Board
        {
            int[,] boardFields = new int[10, 10];
            char[] verticalFieldNames = new char[10] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            int[] horizontalFieldNames = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        }

        public class Moves
        {
            UserInput[] moves = new UserInput[100];
            int turn;

            public Moves()
            {
                for (int i = 0; i < 100; i++)
                {
                    UserInput temp = new UserInput();
                    int temp_turn = i;
                    if (IsMovePossible(temp_turn, temp, moves))
                    {
                        this.moves[i] = temp;
                        this.turn = temp_turn;
                    }
                    else
                    {
                        Console.WriteLine("This move have been already taken.");
                    }
                }
            }

            bool IsMovePossible(int turn, UserInput present, UserInput[] soFar)
            {
                for (int i = 0; i <= turn; i++)
                {
                    if (turn == i)
                        return true;
                    if (present == soFar[i])
                    {
                        return false;
                    }
                }
                return true;
            }



        }







        /* used moves */




    }

    public class UserInput
    {
        /* Move */

        char verticalCoordinate;
        int horizontalCoordinate;


        /* Alowable moves  */
        char[] verticalFieldNames = new char[10] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        int[] horizontalFieldNames = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public UserInput()
        {
            this.verticalCoordinate = SetVerticalCoordinate();
            this.horizontalCoordinate = SetHorizontalCoordinate();
        }


        char SetVerticalCoordinate()
        {
            string temp;
            do
            {
                Console.WriteLine("Give verical coordinate (A-J): ");
                temp = Console.ReadLine();
                if (IsStringValid(temp, verticalFieldNames))
                {
                    verticalCoordinate = char.Parse(temp);
                }
                else
                {
                    Console.WriteLine("Give corect value");
                }
            } while (!IsStringValid(temp, verticalFieldNames));
            return this.verticalCoordinate;
        }
        int SetHorizontalCoordinate()
        {

            string temp;
            do
            {
                Console.WriteLine("Give Horizontal Coorinate (1-10): ");
                temp = Console.ReadLine();
                if (IsIntValid(temp, horizontalFieldNames))
                {
                    horizontalCoordinate = char.Parse(temp);
                }
                else
                {
                    Console.WriteLine("Give corect value");
                }
            } while (!IsIntValid(temp, horizontalFieldNames));
            return this.horizontalCoordinate;
        }

        bool IsStringValid(string temp, char[] FieldNames)
        {
            foreach (char FieldName in FieldNames)
                if (FieldName.ToString() == temp)
                    return true;
            return false;
        }
        bool IsIntValid(string temp, int[] FieldNames)
        {
            foreach (int FieldName in FieldNames)
                if (FieldName.ToString() == temp)
                    return true;
            return false;
        }
    }

    class ships
    {

    }
}

