
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class Map
    {
        // identify variables
        private int nRows;
        private int nColumns;
        private Tile[,] worldMap;
        private String title;

        // properties for the variables
        public int NRows { get; set; }
        public int NColumns { get; set; }
        public Tile[,] WorldMap { get; set; }
        public String Title { get; set; }

        // no arg constructor
        public Map()
        {
            NRows = 10;
            NColumns = 10;

            WorldMap = new Tile[NRows, NColumns];

            for (int i = 0; i < NRows; i++)
            {
                for (int j = 0; j < NColumns; j++)
                {
                    WorldMap[i, j] = new Tile();
                    WorldMap[i, j].Xcoordinate = i;
                    WorldMap[i, j].Ycoordinate = j;
                }
            }
        }

        // player defined constructor
        public Map(int rows, int columns, String mapTitle)
        {
            NRows = rows;
            NColumns = columns;
            Title = mapTitle;

            WorldMap = new Tile[NRows, NColumns];

            for (int i = 0; i < NRows; i++)
            {
                for (int j = 0; j < NColumns; j++)
                {
                    WorldMap[i, j] = new Tile();
                    WorldMap[i, j].Xcoordinate = i;
                    WorldMap[i, j].Ycoordinate = j;
                }
            }
        }

        // story defined constructor
        public Map(int rows, int columns)
        {
            NRows = rows;
            NColumns = columns;
            Title = "The Northern Realms";

            WorldMap = new Tile[NRows, NColumns];

            for (int i = 0; i < NRows; i++)
            {
                for (int j = 0; j < NColumns; j++)
                {
                    WorldMap[i, j] = new Tile();
                    WorldMap[i, j].Xcoordinate = i;
                    WorldMap[i, j].Ycoordinate = j;
                }
            }
        }

        // method to catch tile
        public Tile TileAt(int x, int y)
        {
            Tile ourTile;
            ourTile = WorldMap[x, y];
            return ourTile;
        }

        // Method to display the map
        public void displayMap(Player p1, Map wm1)
        {
            Console.WriteLine("{0}", Title);
            for (int j = 0; j < NColumns; j++)
            {
                Console.Write("*---");
            }
            Console.WriteLine("*");
            for (int i = 0; i < NRows; i++)
            {
                Console.Write("|");
                for (int j = 0; j < NColumns; j++)
                {
                    if (occupied(p1, i, j))
                    {
                        Console.Write(" O |");
                    }
                    else if (EnemyLocation(wm1.TileAt(i, j)))
                    {
                        Console.Write(" E |");
                    }
                    else if (ItemLocation(wm1.TileAt(i, j)))
                    {
                        Console.Write(" I |");
                    }
                    else
                    {
                        Console.Write("   |");
                    }
                }
                Console.WriteLine();
                for (int j = 0; j < NColumns; j++)
                {
                    Console.Write("*---");
                }
                Console.WriteLine("*");
            }
        }

        // Method to print Enemy tiles on map 
        public Boolean EnemyLocation(Tile t)
        {
            if (t.Type == "ENEMY")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method to print Item tiles on map
        public Boolean ItemLocation(Tile t)
        {
            if (t.Type == "ITEM")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // method to check if player is on tile
        public Boolean occupied(Player p1, int x, int y)
        {
            if (p1.X == x && p1.Y == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
