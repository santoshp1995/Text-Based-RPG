using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class Tile
    {
        // identify variables
        private String terrain;
        private String type;
        private String description;
        private int xcoordinate;
        private int ycoordinate;

        // properties for the variables
        public String Terrain { get; set; }
        public String Type { get; set; }
        public String Description { get; set; }
        public int Xcoordinate { get; set; }
        public int Ycoordinate { get; set; }

        // no arg constructor
        public Tile()
        {
            Terrain = "NORMAL";
            Type = "NORMAL";
            Description = "This is a normal tyle";
        }
        // player defined tile
        public Tile(String terrain, String type, int x, int y)
        {
            Terrain = terrain;
            Type = type;
            Xcoordinate = x;
            Ycoordinate = y;
            switch (Terrain)
            {
                case "1":
                    Description = "Grassy Plains";
                    break;
                case "2":
                    Description = "Snowy Mountain-Tops";
                    break;
                case "3":
                    Description = "Fiery plains";
                    break;
                case "4":
                    Description = "Deserted Village";
                    break;
                case "5":
                    Description = "Pirate Ship";
                    break;
            }
        }
        // Story defined constructor
        public Tile(String terrain, String type)
        {
            Terrain = terrain;
            Type = type;
            switch (terrain)
            {
                case "1":
                    Description = " Icy pond";
                    break;
                case "2":
                    Description = "Dragon pit";
                    break;
                case "3":
                    Description = "Snowy mountain-tops";
                    break;
                case "4":
                    Description = "Grassy Plains";
                    break;
                case "5":
                    Description = "Deserted Village";
                    break;
            }
        }
    }
}
