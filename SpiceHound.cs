using System;
namespace iron_ninja
{
    class SpiceHound : Ninja 
    {

        public override bool IsFull
        {
            get{
            if(calorieIntake >= 1200)
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
                if (item.IsSpicy) { calorieIntake -= 5; }
                item.GetInfo();
            }
            else
            {
                Console.WriteLine("The SweetTooth is full and cannot eat anymore.");
            }
        }
    }
}