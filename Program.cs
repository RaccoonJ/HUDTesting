using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUDTesting 
{
    internal class Program
    {
        static int Health;
        static int Lives;
        static float Score;
        static float Multiplier;
        static string Name;
        static int HealthChange;
        static int LivesChange;
        static float ScoreChange;
       
        static void Main(string[] args)
        {
            LivesChange = 1;
            Health = 100;
            Lives = 3;
            Score = 0;
            Multiplier = 1;
            Console.WriteLine("Hello, what is your name?");
            Name = Console.ReadLine();
            Console.WriteLine("Hello " + Name);

            HUD();

            Console.WriteLine("Good job! You subdued a monster");
            ScoreChange += 100;
            Score += ScoreChange * Multiplier;

            HUD();
           
            Console.WriteLine("Good job! You subdued a monster");
            Score += ScoreChange * Multiplier;

            HUD();

            Console.WriteLine("Congratulations! You leveled up!");
            Multiplier += 1;
            Score += ScoreChange * Multiplier;

            HUD();

            Console.WriteLine("Oh no! You walked into a trap!");
            HealthChange = 50;
            Health -= HealthChange;
            HUD();
            
            Console.WriteLine("Good job! You subdued a monster");
            Score += ScoreChange * Multiplier;

            HUD();

            Console.WriteLine("Good job! You subdued a monster");
            Score += ScoreChange * Multiplier;

            HUD();


        }
        static void HUD()
        {


            Console.WriteLine("INTERESTING GAME TITLE");
            Console.WriteLine(" | " + "Health:" + Health + " | " + "Lives:" + Lives + " | " + "Score:" + Score + " | " + "Multiplier:" + Multiplier + " | ");

            Console.ReadKey(true);

            if (Health == 0)
            {
                Health += 100;
                Console.WriteLine("On no, you died!");
                Lives -= LivesChange;
            }
            if (Lives == 0)
            {
                Console.WriteLine("GAME OVER");
                Console.ReadKey(true);
                System.Environment.Exit(1);
            }

            Console.Clear();
        }
    }
}


