using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Player player1 = new Player();
            Player player2 = new Player();
            
            Console.WriteLine("Hello Haz!");
            Console.ReadLine();

            Console.Clear();
            player1.Draw();
            player2.Draw();

            while(true)
            {
                string direction = "";
                ConsoleKeyInfo keypress = Console.ReadKey(true);
                if(keypress.Key == ConsoleKey.UpArrow)
                {
                    direction = "up";
                }
                if(keypress.Key == ConsoleKey.DownArrow)
                {
                    direction = "down";
                }
                if(keypress.Key == ConsoleKey.LeftArrow)
                {
                    direction = "left";
                }
                if(keypress.Key == ConsoleKey.RightArrow)
                {
                    direction = "right";
                }

                string direction2 = "";
                if(keypress.Key == ConsoleKey.W)
                {
                    direction2 = "up";
                }
                if(keypress.Key == ConsoleKey.S)
                {
                    direction2 = "down";
                }
                if(keypress.Key == ConsoleKey.A)
                {
                    direction2 = "left";
                }
                if(keypress.Key == ConsoleKey.D)
                {
                    direction2 = "right";
                }

                player1.Move(direction);
                player2.Move(direction2);
                Console.Clear();
                player1.Draw();
                player2.Draw();
            }
            Console.ReadKey(true);
        }
    }
}
