using System;
using System.Threading;
using System.Collections.Generic;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            

            Console.Write("Player 1, press a key to represent your player: ");
            char playerSprite = Console.ReadKey().KeyChar;

            players.Add(new Player(playerSprite, ConsoleColor.DarkCyan));


            Console.Write("Player 2, press a key to represent your player: ");
            playerSprite = Console.ReadKey().KeyChar;

            players.Add(new Player(playerSprite, ConsoleColor.Magenta));



            Console.WriteLine("\n\nRetroRPG");
            Console.WriteLine("Press any key to begin!");
            Console.ReadLine();

            Console.Clear();

            Draw(players);


            while(true)
            {
                if(Console.KeyAvailable)
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

                    players[0].Move(direction);
                    players[1].Move(direction2);
                }
                    Console.Clear();
                    
                    Draw(players);
                    
                    Thread.Sleep(1000/30);
            }
        }
        public static void Draw(List<Player> players)
        {
            foreach(Player player in players)
            {
                player.Draw();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
