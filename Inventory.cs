using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Inventory
    {
        int maxItems = 8;


        public int MaxItems
        {
            get { return maxItems; }
            set { maxItems = value; }

        }


        public List<Item> Items = new List<Item>();

        public bool IsOpen {get; set;}


        public Inventory()
        {
         

        }

        public void AddItem(Item item)
        {
            if(IsOpen)
            {
            if(Items.Count < maxItems)
            {
                Items.Add(item);
            }
            else
            {
                Console.WriteLine("Unable to add item, inventory is full");
            }
        }
        else
        {
            Console.WriteLine("Inventory is closed");
        }

        public void Open()
        {
            IsOpen = true;
            Console.WriteLine("Opening Inventory");
        }

        public void Close()
        {
            IsOpen = false;
            Console.WriteLine("Closing Inventory");
        }

        public void ListInventory()
        {
            foreach(Item item in Items)
            {
                item.Describe();
            }
        }

    }
    
}

