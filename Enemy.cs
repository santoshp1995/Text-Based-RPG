using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class Enemy
    {
        // identitfy the variables
        private int health;
        private int attack;
        private int defense;
        private int speed;
        private int expGiven;
        private String name;
        private String enemyDescription;

        // properties for the variables
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int ExpGiven { get; set; }
        public String Name { get; set; }
        public String EnemyDescription { get; set; }

        // no arg constructor
        public Enemy()
        {
            Health = 4;
            Attack = 3;
            Defense = 1;
            Speed = 2;
            ExpGiven = 5;
            Name = "Rogue";
            EnemyDescription = "Homeless guy. Very weak fighter overall";
        }

        // player defined constructor
        public Enemy(int hp, int atk, int def, int spd, String n, String ed, int eg)
        {
            Health = hp;
            Attack = atk;
            Defense = def;
            Speed = spd;
            Name = n;
            EnemyDescription = ed;
            ExpGiven = eg;
        }

        // story defined constructor
        public Enemy(String mob)
        {
            switch (mob)
            {
                case "1":
                    Health = 5;
                    Attack = 4;
                    Defense = 3;
                    Speed = 1;
                    Name = "Pirate";
                    EnemyDescription = "Has mediocre attack and low defense.";
                    ExpGiven = 5;
                    break;
                case "2":
                    Health = 3;
                    Attack = 5;
                    Defense = 2;
                    Speed = 6;
                    Name = "Elf";
                    EnemyDescription = "Has solid attack and speed abilities";
                    ExpGiven = 5;
                    break;
                case "3":
                    Health = 6;
                    Attack = 6;
                    Defense = 4;
                    Speed = 1;
                    Name = "Templar Knight";
                    EnemyDescription = "Has high attack power";
                    ExpGiven = 5;
                    break;
                case "4":
                    Health = 4;
                    Attack = 2;
                    Defense = 3;
                    Speed = 6;
                    Name = "Thief";
                    EnemyDescription = "Has low attack and defense";
                    ExpGiven = 5;
                    break;
                case "5":
                    Health = 3;
                    Attack = 7;
                    Defense = 1;
                    Speed = 5;
                    Name = "Gunslinger";
                    EnemyDescription = "High Attack power but low HP";
                    ExpGiven = 5;
                    break;
                case "6":
                    Health = 6;
                    Attack = 5;
                    Defense = 5;
                    Speed = 1;
                    Name = "Brute";
                    EnemyDescription = "Has average attack and defense abilities";
                    ExpGiven = 5;
                    break;
                case "7":
                    Health = 3;
                    Attack = 5;
                    Defense = 6;
                    Speed = 1;
                    Name = "Three Headed Dog";
                    EnemyDescription = "Has a high Defense ability";
                    ExpGiven = 5;
                    break;
                case "8":
                    Health = 7;
                    Attack = 6;
                    Defense = 5;
                    Speed = 4;
                    Name = "Grim Reaper";
                    EnemyDescription = "Has high health and attack power";
                    ExpGiven = 10;
                    break;
                case "9":
                    Health = 10;
                    Attack = 10;
                    Defense = 20;
                    Speed = 10;
                    Name = "Goku";
                    EnemyDescription = "Yeah.... Good Luck Killing This Guy!!!";
                    ExpGiven = 35;
                    break;
                case "10":
                    Health = 5;
                    Attack = 4;
                    Defense = 7;
                    Speed = 5;
                    Name = "Witch";
                    EnemyDescription = "Has a defense but weak attack abilities";
                    ExpGiven = 5;
                    break;
                case "11":
                    Health = 5;
                    Attack = 5;
                    Defense = 5;
                    Speed = 5;
                    Name = "Instructor";
                    EnemyDescription = "Mediocre in all categories";
                    ExpGiven = 5;
                    break;
                case "12":
                    Health = 4;
                    Attack = 7;
                    Defense = 5;
                    Speed = 4;
                    Name = "Viking";
                    EnemyDescription = "Has high attack power";
                    ExpGiven = 5;
                    break;
            }
        }
    }
}
