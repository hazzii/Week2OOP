using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Player player1 = new Player();

            
            Console.WriteLine("Hello Haz!");
            Console.ReadLine();

            Console.Clear();
            player1.Draw();

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

            player1.Move(direction);
            Console.Clear();
            player1.Draw();

            Console.ReadKey(true);
        }
    }
}
