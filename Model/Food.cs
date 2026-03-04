using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi.Model
{
    public class Food: AItem
    {
        private const int NUTRITION = 100;
        private int Nutrition { get; set; }
        private FoodItem FoodItemType { get; set; }

        public enum FoodItem
        {
            Meat,
            Seeds,
            FruitBowl
        }

        public Food (int nutrition, FoodItem fooditem, int uses)
        {
            this.Nutrition = nutrition;
            this.FoodItemType = fooditem;
            this.Uses = uses;
        }

        public Food(FoodItem fooditem, int uses)
        {
            this.Nutrition = NUTRITION;
            this.FoodItemType = fooditem;
            this.Uses = uses;
        }

        public Food(int nutrition, FoodItem fooditem)
        {
            this.Nutrition = nutrition;
            this.FoodItemType = fooditem;
            this.Uses = USES;
        }

        public Food (FoodItem fooditem)
        {
            this.Nutrition = NUTRITION;
            this.FoodItemType = fooditem;
            this.Uses = USES;
        }
    }
}
