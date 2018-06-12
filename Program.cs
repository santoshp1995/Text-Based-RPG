using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            // declare variables
            int player1Attack;
            int player1Defense;
            int player1Speed;
            int player1Health;

            String player1TypeChoice;
            String player1Name;
            String player1Class;
            String title;
            String difficulty;
            Player player1 = new Player();
            Map worldmap = new Map();

            Boolean wonGame = false;

            Player swordsman = new Player("Swordsman");
            Player mage = new Player("Mage");
            Player archer = new Player("Archer");
            Player ninja = new Player("Ninja");
            Player assassin = new Player("Assassin");
            Enemy enemy = new Enemy();

            // Start the game
            Console.Clear();
            Console.WriteLine("Welcome to the Game!!!");


            // build the map
            Console.WriteLine("Enter difficulty of map?(EASY,MEDIUM,HARD)");
            difficulty = Console.ReadLine().ToUpper();
            switch (difficulty)
            {
                case "EASY":
                    worldmap = new Map(5, 8);

                    worldmap.Title = "The Land of Fire";

                    worldmap.TileAt(1, 0).Type = "ENEMY";
                    worldmap.TileAt(1, 1).Type = "ENEMY";
                    worldmap.TileAt(1, 2).Type = "ENEMY";
                    worldmap.TileAt(0, 2).Type = "ENEMY";
                    worldmap.TileAt(3, 0).Type = "ENEMY";
                    worldmap.TileAt(3, 1).Type = "ENEMY";
                    worldmap.TileAt(3, 2).Type = "ENEMY";
                    worldmap.TileAt(3, 3).Type = "ENEMY";
                    worldmap.TileAt(3, 4).Type = "ENEMY";
                    worldmap.TileAt(3, 5).Type = "ENEMY";
                    worldmap.TileAt(3, 6).Type = "ENEMY";
                    worldmap.TileAt(2, 6).Type = "ENEMY";
                    worldmap.TileAt(1, 6).Type = "ENEMY";
                    worldmap.TileAt(0, 6).Type = "ENEMY";
                    worldmap.TileAt(1, 7).Type = "ENEMY";
                    worldmap.TileAt(4, 4).Type = "ENEMY";

                    worldmap.TileAt(2, 4).Type = "ITEM";
                    worldmap.TileAt(4, 7).Type = "ITEM";
                    worldmap.TileAt(0, 6).Type = "ITEM";
                    break;
                case "MEDIUM":
                    worldmap = new Map(7, 12);

                    worldmap.Title = "The Land of Orcs";

                    worldmap.TileAt(3, 4).Type = "ENEMY";
                    worldmap.TileAt(3, 8).Type = "ENEMY";
                    worldmap.TileAt(4, 4).Type = "ENEMY";
                    worldmap.TileAt(4, 8).Type = "ENEMY";
                    worldmap.TileAt(5, 0).Type = "ENEMY";
                    worldmap.TileAt(5, 1).Type = "ENEMY";
                    worldmap.TileAt(5, 2).Type = "ENEMY";
                    worldmap.TileAt(5, 3).Type = "ENEMY";
                    worldmap.TileAt(5, 4).Type = "ENEMY";
                    worldmap.TileAt(5, 5).Type = "ENEMY";
                    worldmap.TileAt(5, 8).Type = "ENEMY";
                    worldmap.TileAt(6, 2).Type = "ENEMY";
                    worldmap.TileAt(6, 3).Type = "ENEMY";
                    worldmap.TileAt(6, 10).Type = "ENEMY";
                    worldmap.TileAt(6, 11).Type = "ENEMY";
                    worldmap.TileAt(4, 9).Type = "ENEMY";
                    worldmap.TileAt(2, 9).Type = "ENEMY";
                    worldmap.TileAt(0, 9).Type = "ENEMY";
                    worldmap.TileAt(1, 9).Type = "ENEMY";
                    worldmap.TileAt(4, 10).Type = "ENEMY";
                    worldmap.TileAt(2, 0).Type = "ENEMY";
                    worldmap.TileAt(2, 1).Type = "ENEMY";
                    worldmap.TileAt(2, 2).Type = "ENEMY";
                    worldmap.TileAt(2, 3).Type = "ENEMY";
                    worldmap.TileAt(2, 4).Type = "ENEMY";
                    worldmap.TileAt(2, 5).Type = "ENEMY";
                    worldmap.TileAt(2, 6).Type = "ENEMY";
                    worldmap.TileAt(2, 8).Type = "ENEMY";
                    worldmap.TileAt(1, 4).Type = "ENEMY";
                    worldmap.TileAt(0, 6).Type = "ENEMY";
                    worldmap.TileAt(1, 7).Type = "ENEMY";
                    worldmap.TileAt(0, 4).Type = "ENEMY";

                    worldmap.TileAt(3, 5).Type = "ITEM";
                    worldmap.TileAt(3, 6).Type = "ITEM";
                    worldmap.TileAt(3, 7).Type = "ITEM";
                    worldmap.TileAt(4, 5).Type = "ITEM";
                    worldmap.TileAt(4, 6).Type = "ITEM";
                    worldmap.TileAt(4, 7).Type = "ITEM";
                    break;
                case "HARD":
                    worldmap = new Map(9, 16);

                    worldmap.Title = "Battle Arena";
                    for (int s = 0; s < 9; s++)
                    {
                        for (int t = 0; t < 16; t++)
                        {
                            worldmap.TileAt(s, t).Type = "ENEMY";
                        }
                    }
                    break;
            }
            if (worldmap == null)
            {
                worldmap = new Map();
            }

            // build the character
            Console.Clear();
            Console.WriteLine("Do you want a CUSTOM or DEFAULT character class?");
            switch (Console.ReadLine().ToUpper())
            {
                case "CUSTOM":

                    // ask user to enter in his stats
                    Console.WriteLine("What is the name of your character?");
                    player1Name = Console.ReadLine();
                    Console.WriteLine("What is the class of your character?");
                    player1Class = Console.ReadLine();
                    Console.WriteLine("Enter Health(HP) of character. NOTE: Must be less than 10");
                    player1Health = Convert.ToInt32(Console.ReadLine());
                    if (player1Health >= 10)
                    {
                        Console.WriteLine(" .... Enter value less than 10....");
                        player1Health = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Enter Attack(ATK) of character. NOTE: Must be less than 10");
                    player1Attack = Convert.ToInt32(Console.ReadLine());
                    if (player1Attack >= 10)
                    {
                        Console.WriteLine("....Enter value less than 10....");
                        player1Attack = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Enter Defense(DEF) of character. NOTE: Must be less than 10");
                    player1Defense = Convert.ToInt32(Console.ReadLine());
                    if (player1Defense >= 10)
                    {
                        Console.WriteLine("....Enter value less than 10....");
                        player1Defense = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Enter Speed(SPD) of character. NOTE: Must be less than 10");
                    player1Speed = Convert.ToInt32(Console.ReadLine());
                    if (player1Speed >= 10)
                    {
                        Console.WriteLine("....Enter value less than 10....");
                        player1Speed = Convert.ToInt32(Console.ReadLine());
                    }

                    // create custom player based on entered stats
                    player1 = new Player(player1Health, player1Attack, player1Defense, player1Speed, player1Name, player1Class);
                    break;
                case "DEFAULT":
                    Console.WriteLine("Which Character Are You?");
                    Console.WriteLine();
                    Console.WriteLine("{0}\t{1}\n\n{2}\t{3}\n\n{4}\t\t{5}\n\n{6}\t{7}\n\n{8}\t{9}",
                        "Swordsman", swordsman.ClassDescription, "Mage", mage.ClassDescription, "Archer", archer.ClassDescription,
                        "Ninja", ninja.ClassDescription, "Assassin", assassin.ClassDescription);
                    Console.WriteLine();

                    player1TypeChoice = Console.ReadLine().ToUpper();

                    // create character based on choice
                    switch (player1TypeChoice)
                    {
                        case "SWORDSMAN":
                            player1 = new Player("Swordsman");
                            break;
                        case "MAGE":
                            player1 = new Player("Mage");
                            break;
                        case "ARCHER":
                            player1 = new Player("Archer");
                            break;
                        case "NINJA":
                            player1 = new Player("Ninja");
                            break;
                        case "ASSASSIN":
                            player1 = new Player("Assassin");
                            break;
                    }
                    if (player1 == null)
                    {
                        player1 = new Player();
                    }
                    break;
            }
            if (player1 == null)
            {
                player1 = new Player();
            }

            // begin playing game
            player1.X = 0;
            player1.Y = 0;

            while (player1.Health > 0 && worldmap != null)
            {
                Console.Clear();
                takeTurn(player1, worldmap);
            }
            if (!wonGame)
            {
                Console.WriteLine("You Have Lost -- Game Over!!!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You Win!!!");
            }
        }

        // method to take turn
        public static void takeTurn(Player p1, Map wm1)
        {
            Boolean madeMove = false;
            Console.WriteLine(" Select an option");
            Console.WriteLine(" Move");
            Console.WriteLine(" See Map");
            Console.WriteLine(" See Stats");
            Console.WriteLine(" Quit");

            switch (Console.ReadLine().ToUpper())
            {
                case "MOVE":
                    Console.WriteLine("UP, DOWN, LEFT, RIGHT?");
                    switch (Console.ReadLine().ToUpper())
                    {
                        case "UP":
                            if (p1.X > 0)
                            {
                                p1.X -= 1;
                                madeMove = true;
                                wm1.displayMap(p1, wm1);
                            }
                            else
                            {
                                Console.WriteLine(" Player not on map!");
                                Console.ReadLine();
                            }
                            break;
                        case "DOWN":
                            if (p1.X <= wm1.NRows - 1)
                            {
                                p1.X += 1;
                                madeMove = true;
                                wm1.displayMap(p1, wm1);
                            }
                            else
                            {
                                Console.WriteLine(" Player not on map! ");
                                Console.ReadLine();
                            }
                            break;
                        case "LEFT":
                            if (p1.Y > 0)
                            {
                                p1.Y -= 1;
                                madeMove = true;
                                wm1.displayMap(p1, wm1);
                            }
                            else
                            {
                                Console.WriteLine(" Player not on map! ");
                                Console.ReadLine();
                            }
                            break;
                        case "RIGHT":
                            if (p1.Y <= wm1.NColumns - 1)
                            {
                                p1.Y += 1;
                                madeMove = true;
                                wm1.displayMap(p1, wm1);
                            }
                            else
                            {
                                Console.WriteLine("Player not on map");
                                Console.ReadLine();
                            }
                            break;
                    }
                    break;
                case "SEE MAP":
                    Console.WriteLine();
                    wm1.displayMap(p1, wm1);
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
                case "SEE STATS":
                    p1.printPlayerStats();
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
                case "QUIT":
                    p1.Health = 0;
                    break;
            }
            if (madeMove)
            {
                activateSquare(wm1.TileAt(p1.X, p1.Y), p1);
            }
        }

        // method to call square
        public static void activateSquare(Tile square, Player p1)
        {
            switch (square.Type.ToUpper())
            {
                case "ENEMY":
                    Console.WriteLine("{0}", "This is an Enemy Tile");
                    ActivateBattle(p1);
                    break;
                case "ITEM":
                    Console.WriteLine("{0}", "This is an Item Tile");
                    ActivateItem(p1);
                    break;
                case "NORMAL":
                    Console.WriteLine("{0}", "This a a Normal Tile");
                    break;
            }
            Console.ReadLine();
        }
        // method to activate a battle sequence
        public static void ActivateBattle(Player p1)
        {
            Random rnd = new Random();
            int enemy = rnd.Next(1, 12);

            Console.WriteLine("Battle has begun!!!");
            Enemy e1 = new Enemy(enemy.ToString());

            Console.WriteLine("{0} has appeared", e1.Name);
            Console.WriteLine("{0}", e1.EnemyDescription);

            int temp1 = p1.Health;
            int temp2 = p1.Attack;
            int temp3 = p1.Defense;
            int temp4 = p1.Speed;

            while (p1.Health > 0 && e1.Health > 0)
            {
                // Faster character's move
                if (p1.Speed >= e1.Speed)
                {
                    playersMove(p1, e1);
                }
                else
                {
                    enemysMove(p1, e1);
                }
                // slower character's move
                if (p1.Health <= 0 || e1.Health <= 0)
                {
                    break;
                }
                if (p1.Speed < e1.Speed)
                {
                    playersMove(p1, e1);
                }
                else
                {
                    enemysMove(p1, e1);
                }
            }
            if (p1.Health > 0)
            {
                p1.Experience++;
                afterBattleStats(temp1, temp2, temp3, temp4, p1);
            }
            if (p1.Experience == Math.Pow(p1.Level, 2))
            {
                p1.levelUp(p1);
                Console.WriteLine("You have leveld up");
            }
            Console.ReadLine();
        }
        public static void ActivateItem(Player p1)
        {
            Random rnd = new Random();
            int item = rnd.Next(1, 13);

            Console.WriteLine("You have found an item");
            Item i1 = new Item(item.ToString());

            Console.WriteLine("You found {0}", i1.Name);
            Console.WriteLine("{0}", i1.Itemdescription);

            int temp1 = p1.Health;
            int temp2 = p1.Attack;
            int temp3 = p1.Defense;
            int temp4 = p1.Speed;

            Console.WriteLine(" Do you want to USE or LEAVE the item?");
            if (Console.ReadLine().ToUpper() == "USE")
            {
                switch (i1.Stat)
                {
                    case "HEALTH":
                        p1.Health += i1.Value;
                        break;
                    case "ATTACK":
                        p1.Attack += i1.Value;
                        break;
                    case "DEFENSE":
                        p1.Defense += i1.Value;
                        break;
                    case "SPEED":
                        p1.Speed += i1.Value;
                        break;
                }
            }
        }

        // player battle move
        public static void playersMove(Player p1, Enemy e1)
        {
            Console.WriteLine("\nATTACK,CHARGE,DEFEND,HEAL,CHECKSELF,CHECKENEMY");
            String choice = Console.ReadLine();
            switch (choice.ToUpper())
            {
                case "ATTACK":
                    if (p1.Attack > e1.Defense)
                    {
                        e1.Health -= (p1.Attack - e1.Defense);
                        Console.WriteLine("You dealt {0} damage to the enemy", (p1.Attack - e1.Defense));
                    }
                    else
                    {
                        p1.Health -= 1;
                        e1.Health -= 1;
                        Console.WriteLine("The defense had no holes but both combatants lost (1) HP");
                    }
                    break;
                case "CHARGE":
                    p1.Attack += 3;
                    Console.WriteLine("You are charging up to land a powerful blow(Attack up by 3)");
                    break;
                case "DEFEND":
                    p1.Defense += 1;
                    Console.WriteLine("You have braced yourself for enemy's attack");
                    break;
                case "HEAL":
                    p1.Health += 2;
                    Console.WriteLine("You recovered 2 HP");
                    break;
                case "CHECKSELF":
                    Console.WriteLine("Player HP: {0}", p1.Health);
                    Console.WriteLine("Player ATK: {0}", p1.Attack);
                    Console.WriteLine("Player DEF: {0}", p1.Defense);
                    Console.WriteLine("Player SPD: {0}", p1.Speed);
                    break;
                case "CHECKENEMY":
                    Console.WriteLine("Enemy HP: {0}", e1.Health);
                    Console.WriteLine("Enemy ATK: {0}", e1.Attack);
                    Console.WriteLine("Enemy DEF: {0}", e1.Defense);
                    Console.WriteLine("Enemy SPD: {0}", e1.Speed);
                    break;
            }
        }

        // Enemy battle move
        public static void enemysMove(Player p1, Enemy e1)
        {
            Random rand = new Random();
            switch (rand.Next(4))
            {
                case 0:
                    if (e1.Attack > p1.Defense)
                    {
                        p1.Health -= (e1.Attack - p1.Defense);
                        Console.WriteLine("Enemy dealt {0} damage to player", (e1.Attack - p1.Defense));
                    }
                    else
                    {
                        p1.Health -= 1;
                        e1.Health -= 1;
                        Console.WriteLine("Your defense was strong but the scuffle hurt you both by (1) HP");
                    }
                    break;
                case 1:
                    e1.Defense++;
                    Console.WriteLine("Enemy has braced themselves for your attack");
                    break;
                case 2:
                    e1.Health++;
                    Console.WriteLine("Enemy is healing themselves");
                    break;
                case 3:
                    e1.Attack++;
                    Console.WriteLine("Enemy is preparing for a strong attack");
                    break;
            }
        }

        // display player's after battle stats
        public static void afterBattleStats(int stat1, int stat2, int stat3, int stat4, Player player)
        {
            if (player.Health > stat1)
            {
                player.Health = stat1;
            }
            player.Attack = stat2;
            player.Defense = stat3;
            player.Speed = stat4;
            player.Experience += 5;
            Console.WriteLine("You Won the fight!");
            Console.WriteLine("You have earned 6 EXP");
            if (player.Experience == 12)
            {
                player.Level = 2;
                Console.WriteLine("Level Up! Now Level 2");
                Console.WriteLine();
                Console.WriteLine("Which attribute do you want to increase by (1)?(HEALTH,ATTACK,DEFENSE,SPEED");
                String increaseAttribute = Console.ReadLine();
                switch (increaseAttribute.ToUpper())
                {
                    case "HEALTH":
                        player.Health++;
                        Console.WriteLine("You now have {0} HP", player.Health);
                        break;
                    case "ATTACK":
                        player.Attack++;
                        Console.WriteLine("You now have {0} ATK", player.Attack);
                        break;
                    case "DEFENSE":
                        player.Defense++;
                        Console.WriteLine("You now have {0} DEF", player.Defense);
                        break;
                    case "SPEED":
                        player.Speed++;
                        Console.WriteLine("You now have {0} SPD", player.Speed);
                        break;
                }
            }
            if (player.Experience == 24)
            {
                player.Level = 3;
                Console.WriteLine("Level Up! Now Level 3");
                Console.WriteLine();
                Console.WriteLine("Which attribute do you want to increase by (2)?(HEALTH,ATTACK,DEFENSE,SPEED");
                String increaseAttribute = Console.ReadLine();
                switch (increaseAttribute.ToUpper())
                {
                    case "HEALTH":
                        player.Health += 2;
                        Console.WriteLine("You now have {0} HP", player.Health);
                        break;
                    case "ATTACK":
                        player.Attack += 2;
                        Console.WriteLine("You now have {0} ATK", player.Attack);
                        break;
                    case "DEFENSE":
                        player.Defense += 2;
                        Console.WriteLine("You now have {0} DEF", player.Defense);
                        break;
                    case "SPEED":
                        player.Speed += 2;
                        Console.WriteLine("You now have {0} SPD", player.Speed);
                        break;
                }
            }
            if (player.Experience == 42)
            {
                player.Level = 4;
                Console.WriteLine("Level Up! Now Level 4");
                Console.WriteLine();
                Console.WriteLine("Which attribute do you want to increase by (3)?(HEALTH,ATTACK,DEFENSE,SPEED");
                String increaseAttribute = Console.ReadLine();
                switch (increaseAttribute.ToUpper())
                {
                    case "HEALTH":
                        player.Health += 3;
                        Console.WriteLine("You now have {0} HP", player.Health);
                        break;
                    case "ATTACK":
                        player.Attack += 3;
                        Console.WriteLine("You now have {0} ATK", player.Attack);
                        break;
                    case "DEFENSE":
                        player.Defense += 3;
                        Console.WriteLine("You now have {0} DEF", player.Defense);
                        break;
                    case "SPEED":
                        player.Speed += 3;
                        Console.WriteLine("You now have {0} SPD", player.Speed);
                        break;
                }
            }
            if (player.Experience == 60)
            {
                player.Level = 5;
                Console.WriteLine("Level Up! Now Level 5");
                Console.WriteLine();
                Console.WriteLine("Which attribute do you want to increase by (4)?(HEALTH,ATTACK,DEFENSE,SPEED");
                String increaseAttribute = Console.ReadLine();
                switch (increaseAttribute.ToUpper())
                {
                    case "HEALTH":
                        player.Health += 4;
                        Console.WriteLine("You now have {0} HP", player.Health);
                        break;
                    case "ATTACK":
                        player.Attack += 4;
                        Console.WriteLine("You now have {0} ATK", player.Attack);
                        break;
                    case "DEFENSE":
                        player.Defense += 4;
                        Console.WriteLine("You now have {0} DEF", player.Defense);
                        break;
                    case "SPEED":
                        player.Speed += 4;
                        Console.WriteLine("You now have {0} SPD", player.Speed);
                        break;
                }
            }
            if (player.Experience == 78)
            {
                player.Level = 6;
                Console.WriteLine("Level Up! Now Level 6");
                Console.WriteLine();
                Console.WriteLine("Which attribute do you want to increase by (5)?(HEALTH,ATTACK,DEFENSE,SPEED");
                String increaseAttributes = Console.ReadLine();
                switch (increaseAttributes.ToUpper())
                {
                    case "HEALTH":
                        player.Health += 5;
                        Console.WriteLine("You now have {0} HP", player.Health);
                        break;
                    case "ATTACK":
                        player.Attack += 5;
                        Console.WriteLine("You now have {0} ATK", player.Attack);
                        break;
                    case "DEFENSE":
                        player.Defense += 5;
                        Console.WriteLine("You now have {0} DEF", player.Defense);
                        break;
                    case "SPEED":
                        player.Speed += 5;
                        Console.WriteLine("You now have {0} SPD", player.Speed);
                        break;
                }
            }
            if (player.Experience == 96)
            {
                player.Level = 7;
                Console.WriteLine("Level Up! Now Level 7");
                Console.WriteLine("Which attribute do you want to increase by (6)?(HEALTH,ATTACK,DEFENSE,SPEED");
                String increaseAttributes = Console.ReadLine();
                switch (increaseAttributes.ToUpper())
                {
                    case "HEALTH":
                        player.Health += 6;
                        Console.WriteLine("You now have {0} HP", player.Health);
                        break;
                    case "ATTACK":
                        player.Attack += 6;
                        Console.WriteLine("You now have {0} ATK", player.Attack);
                        break;
                    case "DEFENSE":
                        player.Defense += 6;
                        Console.WriteLine("You now have {0} DEF", player.Defense);
                        break;
                    case "SPEED":
                        player.Speed += 6;
                        Console.WriteLine("You now have {0} SPD", player.Speed);
                        break;
                }
            }
            if (player.Experience == 114)
            {
                player.Level = 8;
                Console.WriteLine("Level Up! Now Level 8");
                Console.WriteLine("Which attribute do you want to increase by (7)?(HEALTH,ATTACK,DEFENSE,SPEED");
                String increaseAttributes = Console.ReadLine();
                switch (increaseAttributes.ToUpper())
                {
                    case "HEALTH":
                        player.Health += 7;
                        Console.WriteLine("You now have {0} HP", player.Health);
                        break;
                    case "ATTACK":
                        player.Attack += 7;
                        Console.WriteLine("You now have {0} ATK", player.Attack);
                        break;
                    case "DEFENSE":
                        player.Defense += 7;
                        Console.WriteLine("You now have {0} DEF", player.Defense);
                        break;
                    case "SPEED":
                        player.Speed += 7;
                        Console.WriteLine("You now have {0} SPD", player.Speed);
                        break;
                }
            }
            if (player.Experience == 132)
            {
                player.Level = 9;
                Console.WriteLine("Level Up! Now Level 9");
                Console.WriteLine("Which attribute do you want to increase by (8)?(HEALTH,ATTACK,DEFENSE,SPEED");
                String increaseAttributes = Console.ReadLine();
                switch (increaseAttributes.ToUpper())
                {
                    case "HEALTH":
                        player.Health += 8;
                        Console.WriteLine("You now have {0} HP", player.Health);
                        break;
                    case "ATTACK":
                        player.Attack += 8;
                        Console.WriteLine("You now have {0} ATK", player.Attack);
                        break;
                    case "DEFENSE":
                        player.Defense += 8;
                        Console.WriteLine("You now have {0} DEF", player.Defense);
                        break;
                    case "SPEED":
                        player.Speed += 8;
                        Console.WriteLine("You now have {0} SPD", player.Speed);
                        break;
                }

            }
            if (player.Experience == 150)
            {
                player.Level = 10;
                Console.WriteLine("Level Up! Now Level 10");
                Console.WriteLine("You have reached MAX level...");
                Console.WriteLine("Which attribute do you want to increase by (9)?(HEALTH,ATTACK,DEFENSE,SPEED");
                String increaseAttributes = Console.ReadLine();
                switch (increaseAttributes.ToUpper())
                {
                    case "HEALTH":
                        player.Health += 9;
                        Console.WriteLine("You now have {0} HP", player.Health);
                        break;
                    case "ATTACK":
                        player.Attack += 9;
                        Console.WriteLine("You now have {0} ATK", player.Attack);
                        break;
                    case "DEFENSE":
                        player.Defense += 9;
                        Console.WriteLine("You now have {0} DEF", player.Defense);
                        break;
                    case "SPEED":
                        player.Speed += 9;
                        Console.WriteLine("You now have {0} SPD", player.Speed);
                        break;
                }
            }
        }

        // method to activate item
        public static void itemInterface()
        {
            Console.WriteLine("Item has been spotted");
            Item newItem = new Item();

            Console.ReadLine();
        }
    }
}
