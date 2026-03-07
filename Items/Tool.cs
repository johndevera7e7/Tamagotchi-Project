using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi.Items
{
    public class Tool: AItem
    {
        protected ToolItem ToolItemType { get; set; }
        public enum ToolItem
        {
            Oil,
            Screwdriver
        }

        public Tool(ToolItem index)
        {
            switch (index)
            {
                case ToolItem.Oil:
                    this.ToolItemType = ToolItem.Oil;
                    this.Uses = 4;
                    this.Name = "Oil";
                    break;
                case ToolItem.Screwdriver:
                    this.ToolItemType = ToolItem.Screwdriver;
                    this.Uses = 2;
                    this.Name = "Screwdriver";
                    break;
                
            }
        }
    }
}
