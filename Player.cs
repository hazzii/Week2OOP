using System;
using System.Windows;

namespace ConsoleApplication
{
    public class Player
    {
        int xPosition;
        int yPosition;
        char sprite;
        int health;
        int speed;
        ConsoleColor color = ConsoleColor.Gray;

        public Inventory inventory = new Inventory();

        public int XPosition
        {
            get { return xPosition; }
            set { xPosition = value; }
        }
        public int YPosition
        {
            get { return yPosition; }
            set { yPosition = value; }
        }

        public Player()
        {
            sprite = '&';
            xPosition = 3;
            yPosition = 3;
            speed = 1;
        }

        public Player(char playerSprite)
        {
            sprite = playerSprite;
            xPosition = 3;
            yPosition = 3;
            speed = 1;
        }

        public Player(char playerSprite, ConsoleColor color)
        {
            sprite = playerSprite;
            xPosition = 3;
            yPosition = 3;
            speed = 1;
            this.color = color;
        }

        public void Draw()
        {
            Console.ForegroundColor = this.color;
            Console.CursorLeft = xPosition;
            Console.CursorTop = yPosition;
            Console.Write(sprite);
        }

        public void Move(string direction)
        {
            switch(direction)
            {
                case "up" :
                    yPosition -= speed;
                break;
                case "down" :
                    yPosition += speed;
                break;
                case "left" :
                    xPosition -= speed;
                break;
                case "right" :
                    xPosition += speed;
                break;
                default:
                break;

            }

        }

    }


}