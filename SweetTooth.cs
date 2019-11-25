using System;
namespace iron_ninja
{
    class SweetTooth : Ninja 
    {

        public override bool IsFull
        {
            get{
            if(calorieIntake >= 1500)
                return true;
            return false;
            }
        }
        public override void Consume(IConsumable item)
        {
            if(IsFull == false)
            {
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                item.GetInfo();
                if (item.IsSweet){ calorieIntake += 10; }
            }
            else
            {
                Console.WriteLine("The SweetTooth is full and cannot eat anymore.");
            }
        }
    }
}