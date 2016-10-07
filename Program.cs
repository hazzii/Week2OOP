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

            Console.ReadKey(true);
        }
    }
}
