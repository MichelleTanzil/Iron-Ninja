using System;
using System.Collections.Generic;

namespace iron_ninja
{
    public class Buffet
    {
        public List<IConsumable> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Ha Gow", 300, false, false),
                new Food("Xiao Long Bao", 500, false, false),
                new Food("Shao Mai", 600, false, false),
                new Food("Red Bean Bao", 200, false, true),
                new Food("Spareribs with Pepper Salt", 800, true, false),
                new Food("Hot Pot", 1000, true, false),
                new Food("Rendang", 100, false, false),
                new Food("Durian", 800, false, true),
                new Food("Sushi", 300, false, false),
                new Food("Matcha", 200, false, true),
                new Drink("Wine", 300, false, true),
                new Drink("Jalapeno Margarita", 400, true, false),
                new Drink("Hot Chocolate", 200, true, false),
                new Drink("Water", 0, false, false),
                new Drink("Milk", 50, false, true),
                new Drink("Milkshake", 500, false, true),
                new Drink("Coffee", 100, false, false),
                new Drink("Green Tea", 50, false, false),
            };
        }
        public IConsumable Serve()
        {
            Random rand = new Random();
            int randItem = rand.Next(Menu.Count);
            Console.WriteLine(Menu[randItem].GetInfo());
            return Menu[randItem];
        }
    }
}