using System;

namespace ConsoleApplication
{

    public class Item
    {
        string name;
        string description;
        char sprite;
        
        public Item()
        {


        }

        public Item(string name, string description, char sprite)
        {
            this.name = name;
            this.description = description;
            this.sprite = sprite;
        }

        public void Draw()
        {
            Console.Write(sprite);
        }

        public void Describe()
        {
            Console.WriteLine(name + ": " + description);
        }

    }

}