using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy; 
        public bool IsSweet; 

        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
    }
    class Buffet
    {   
        public List<Food> Menu;
         
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Enchiladas Mariscos", 1000, true, true);
                new Food("Ceviche Tostadas", 1200, true, false);
                new Food("Albondigas", 700, false, true);
                new Food("Chile Rellenos", 800, true, false);
                new Food("Fajitas", 500, true, false);
                new Food("Corn Tamales", 700, false, false);
                new Food("Plato de Carnitas", 900, true, true);
                new Food("Taquitos Rancheros", 700, false, true);
                new Food("Chilaquiles Rojas", 1000, true, true);
                new Food("Sope de Pollo", 500, true, true);
            }
            public Food Serve()
            {
                Random rand = new Randmon();
                int randFood = rand.Next(Menu.Count);
                return Menu[randFood];
            }
        }
    }
    class Ninja
    {
        private int calorieIntake;
        public list<Food> FoodHistory;
        //add constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        //add public "getter" property called "IsFull"
        private bool IsFull;
        public bool IsFull
        {
            get
            {
                if (calorieIntake > 1200)
                {
                    return true;
                }
                return false;
            }
        }
        //build out the Eat method
        public void Eat(Food item)
        {
            if (isFull == false)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"The food eaten was {item.Name}.");
                if (item.IsSpicy){
                    Console.WriteLine($"{item.Name} is spicy.");
                }
                if (item.IsSweet){
                    Console.WriteLine($"{item.Name} is sweet.");
                }
            }
            else{Console.WriteLine("This Ninja is full, he/she cannot eat anymore!");}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Buffet spread = new Buffet();
            Ninja Richard = new Ninja();

            while (Richard.isFull != true)
            {
                Richard.Eat(spread.Serve());
            }
        }
    }
}
