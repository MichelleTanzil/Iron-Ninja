namespace iron_ninja
{
    public class Drink : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}
    
        // Implement a GetInfo Method
        public string GetInfo()
        {
            return $"{Name} (Drink). Calories: {Calories}. Spicy?:{IsSpicy}, IsSweet?:{IsSweet}.";
        }
        // Add a constructor method
        public Drink(string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
    }
}