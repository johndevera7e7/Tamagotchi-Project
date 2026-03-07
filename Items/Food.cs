using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi.Items
{
    public class Food: AItem
    {
        protected int Nutrition { get; set;}
        protected FoodItem FoodItemType { get; set; }
        public enum FoodItem
        {
            Meat,
            Seeds,
            Fruit_Bowl
        }

        public Food(FoodItem index)
        {
            switch (index)
            {
                case FoodItem.Meat:
                    this.FoodItemType = FoodItem.Meat;
                    this.Uses = 3;
                    this.Name = "Meat";
                    break;
                case FoodItem.Seeds:
                    this.FoodItemType = FoodItem.Seeds;
                    this.Uses = 5;
                    this.Name = "Seeds";
                    break;
                case FoodItem.Fruit_Bowl:
                    this.FoodItemType = FoodItem.Fruit_Bowl;
                    this.Uses = 2;
                    this.Name = "Fruit bowl";
                    break;
            }
        }
    }
}
