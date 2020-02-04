using System;

namespace Lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
                Proceed();
            
            
            //Get number of sides from user.

        }

        static void Proceed()
        {
            Console.WriteLine("Enter a number of sides for the dice : ");
            int input = int.Parse(Console.ReadLine());
            RollDice(input);
            //Console.WriteLine(RollDice(input));
        }

        //RollDice
        //Parameters: int
        //Return type: int
        //Preconditions: the dice can not be 0
        //Postconditions:  the dice should display the roll
        private static string RollDice(int sides)
        {           
            Random rnd = new Random();
            int dice1 = rnd.Next(1, sides);  // creates a number between 1 and n
            int dice2 = rnd.Next(1, sides);
            Console.WriteLine(dice1 + " and " + dice2);

            if (sides == 6)
            {
                CheckDice(dice1, dice2);
            }           
            return dice1 + " and " + dice2;
        }

        private static void CheckDice(int dice1, int dice2)
        {
            if (dice1 == 1 && dice2 == 1)
            {
                Console.WriteLine("Snake Eyes!");
            }
            else if ((dice1 == 1 && dice2 == 2) || (dice2 == 1 && dice1 == 2)){
                Console.WriteLine("Ace Deuce!");
            }
            else if (dice1 == 6 && dice2 == 6) 
            {
                Console.WriteLine("Box Cars!");
            }
            else if ((dice1 + dice2) == 7 || (dice1 + dice2) == 11)
            {
                Console.WriteLine("WIN!!");
            }
            else if ((dice1 + dice2) == 2 || (dice1 + dice2) == 3 || (dice1 + dice2) == 12)
            {
                Console.WriteLine("Craps!");
            }
        }
    }
}
