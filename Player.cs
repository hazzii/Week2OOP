using System;
using System.Windows;

namespace ConsoleApplication
{
    public class Player
    {
        int xPosition;
        int yPosition;
        char sprite;

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
        }

        public void Draw()
        {
            Console.Write(sprite);
        }

    }

}