using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi.Model
{
    public class Tool: AItem
    {
        private ToolItem ToolItemType { get; set; }
        public enum ToolItem
        {
            Oil,
            Screwdriver
        }

        public Tool (int uses, ToolItem toolitem)
        {
            this.Uses = uses;
            this.ToolItemType = toolitem;
        }

        public Tool(ToolItem toolitem)
        {
            this.Uses = USES;
            this.ToolItemType = toolitem;
        }
    }
}
