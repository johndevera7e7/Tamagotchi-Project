using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi.Items
{
    public class Toy: AItem
    {
        protected ToyItem ToyItemType { get; set; }
        public enum ToyItem
        {
            Bouncy_Ball,
            Bone,
            Ball_Of_Yarn
        }

        public Toy(ToyItem index)
        {
            this.Uses = 3;
            switch (index)
            {
                case ToyItem.Bouncy_Ball:
                    this.ToyItemType = ToyItem.Bouncy_Ball;
                    this.Name = "Bouncy ball";
                    break;
                case ToyItem.Bone:
                    this.ToyItemType = ToyItem.Bone;
                    this.Name = "Bone";
                    break;
                case ToyItem.Ball_Of_Yarn:
                    this.ToyItemType = ToyItem.Ball_Of_Yarn;
                    this.Name = "Ball of yarn";
                    break;
            }
        }
    }
}
