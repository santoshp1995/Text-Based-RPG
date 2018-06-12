using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class Player
    {
        // identify variables
        private int health;
        private int attack;
        private int defense;
        private int speed;
        private String playerType;
        private String classDescription;
        private int x;
        private int y;
        private int level;
        private int experience;

        Random rand = new Random();

        // properties for variables
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public String PlayerType { get; set; }
        public String ClassDescription { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        // no arg constructor
        public Player()
        {
            Level = 1;
            Experience = 0;
            Health = 5;
            Attack = 4;
            Defense = 1;
            Speed = 2;
            PlayerType = "Vagrant";
            ClassDescription = "Wanderer who attacks anyone he sees";
        }
        // player defined constructor
        public Player(int hp, int atk, int def, int spd, String pt, String cd)
        {
            Level = 1;
            Experience = 0;
            Health = hp;
            Attack = atk;
            Defense = def;
            Speed = spd;
            PlayerType = pt;
            ClassDescription = cd;
        }
        // story defined constructor
        public Player(String playertype)
        {
            Level = 1;
            Experience = 0;

            switch (playertype.ToUpper())
            {
                case "SWORDSMAN":
                    Health = 6;
                    Attack = 6;
                    Defense = 2;
                    Speed = 3;
                    PlayerType = "Swordsman";
                    ClassDescription = "Warrior with high attack but low defense";
                    break;
                case "MAGE":
                    Health = 5;
                    Attack = 7;
                    Defense = 3;
                    Speed = 5;
                    PlayerType = "Mage";
                    ClassDescription = "\tHigh attack power, low defense";
                    break;
                case "ARCHER":
                    Health = 5;
                    Attack = 7;
                    Defense = 1;
                    Speed = 6;
                    PlayerType = "Archer";
                    ClassDescription = "Long range fighter. Low Defense but high attack powers";
                    break;
                case "NINJA":
                    Health = 6;
                    Attack = 5;
                    Defense = 5;
                    Speed = 7;
                    PlayerType = "Ninja";
                    ClassDescription = "\tBalanced Fighter. Decent in all attributes";
                    break;
                case "ASSASSIN":
                    Health = 3;
                    Attack = 8;
                    Defense = 6;
                    Speed = 5;
                    PlayerType = "Assassin";
                    ClassDescription = "High attack. Low Health";
                    break;
            }
        }
        // print out the player's stats
        public void printPlayerStats()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Level {0}", Level);
            Console.WriteLine("{0} EXP", Experience);
            Console.WriteLine("{0}", PlayerType);
            Console.WriteLine("Class Description: {0}", ClassDescription);
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("                    Health: {0}", Health);
            Console.WriteLine("                    Attack: {0}", Attack);
            Console.WriteLine("                    Defense: {0}", Defense);
            Console.WriteLine("                    Speed: {0}", Speed);
            Console.WriteLine("--------------------------------------------------------------");
        }
        public void levelUp(Player newPlayer)
        {
            String skill;
            Console.WriteLine("Which Skill do you want to level up?");
            skill = Console.ReadLine();
            switch (skill)
            {
                case "0":
                    Health += newPlayer.Level;
                    break;
                case "1":
                    Attack += newPlayer.Level;
                    break;
                case "2":
                    Defense += newPlayer.Level;
                    break;
                case "3":
                    Speed += newPlayer.Level;
                    break;
            }
            Level++;
            printPlayerStats();
        }
    }
}
