using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu2
{
    public class Terrain
    {
        public int[,] map;
        private int boardDimX;
        private int boardDimY;

        public Terrain(int boardDimX, int boardDimY)
        {
            this.boardDimX = boardDimX;
            this.boardDimY = boardDimY;
        }

        public void Load_Map()
        {
            //loading the map from the file 
            //the terrain type is stored in the enum
            //Terrain_Type

            string[] lines = System.IO.File.ReadAllLines(@"txt\map.txt");

            int[,] terr = new int[boardDimX, boardDimY];

            //initiating the terr matrix
            int x, y;
            y = 0;
            foreach (var item in lines)
            {
                x = 0;
                foreach (var s in item)
                {
                    switch (s)
                    {
                        case 'v':
                            terr[x, y] = (int)TerrainKind.grass;
                            x++;
                            break;
                        case 'w':
                            terr[x, y] = (int)TerrainKind.water;
                            x++;
                            break;
                        case 'r':
                            terr[x, y] = (int)TerrainKind.road;
                            x++;
                            break;
                        case 'c':
                            terr[x, y] = (int)TerrainKind.city;
                            x++;
                            break;
                        default:
                            break;
                    }
                }
                y++;
            }
            map = terr;
        }
    }
}
