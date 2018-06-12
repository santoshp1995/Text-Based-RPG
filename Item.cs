using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class Item
    {
        // identify variables
        private String name;
        private String stat;
        private int value;
        private String itemdescription;

        // properties of variables
        public String Name { get; set; }
        public String Stat { get; set; }
        public int Value { get; set; }
        public String Itemdescription { get; set; }

        // no arg constructor
        public Item()
        {
            Name = "Health Potion";
            Stat = "HEALTH";
            Value = 4;
            Itemdescription = "Heals HP by 4";
        }
        // player defined constructor
        public Item(String name, String stat, int value, String itemdescription)
        {
            Name = name;
            Stat = stat;
            Value = value;
            Itemdescription = itemdescription;
        }
        // story defined constructor
        public Item(String name)
        {
            switch (name)
            {
                case "1":
                    Name = "Basic Health Potion";
                    Stat = "HEALTH";
                    Value = 1;
                    Itemdescription = "Restores HP by (1) point";
                    break;
                case "2":
                    Name = "Simple Health Potion";
                    Stat = "HEALTH";
                    Value = 2;
                    Itemdescription = "Restores HP by (2) points";
                    break;
                case "3":
                    Name = "Super Health Potion";
                    Stat = "HEALTH";
                    Value = 3;
                    Itemdescription = "Restores HP by (3) points";
                    break;
                case "4":
                    Name = "Basic Attack Potion";
                    Stat = "ATTACK";
                    Value = 1;
                    Itemdescription = "Raises ATK by (1) point";
                    break;
                case "5":
                    Name = "Simple Attack Potion";
                    Stat = "ATTACK";
                    Value = 2;
                    Itemdescription = "RAISES ATK by (2) points";
                    break;
                case "6":
                    Name = "Super Attack Potion";
                    Stat = "ATTACK";
                    Value = 3;
                    Itemdescription = "Raises ATK by (3) points";
                    break;
                case "7":
                    Name = "Basic Defense Potion";
                    Stat = "DEFENSE";
                    Value = 1;
                    Itemdescription = "Raises DEF by (1) points";
                    break;
                case "8":
                    Name = "Simple Defense Potion";
                    Stat = "DEFENSE";
                    Value = 2;
                    Itemdescription = "Raises DEF by (2) points";
                    break;
                case "9":
                    Name = "Super Defense Potion";
                    Stat = "DEFENSE";
                    value = 3;
                    Itemdescription = "Raises DEF by (3) points";
                    break;
                case "10":
                    Name = "Simple Speed Potion";
                    Stat = "SPEED";
                    Value = 1;
                    Itemdescription = "Raises SPD by (1) point";
                    break;
                case "11":
                    Name = "Basic Speed Potion";
                    Stat = "SPEED";
                    Value = 2;
                    Itemdescription = "Raises SPD by (2) points";
                    break;
                case "12":
                    Name = "Super Speed Potion";
                    Stat = "SPEED";
                    Value = 3;
                    Itemdescription = "Raises SPD by (3) points";
                    break;
                case "13":
                    Name = "Mega Health Potion";
                    Stat = "HEALTH";
                    Value = 5;
                    Itemdescription = "Restores HP by (5) points";
                    break;
            }
        }

    }
}
