using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu2
{
    public class Population
    {
        public int[,] pop;
        private int boardDimX;
        private int boardDimY;

        public Population(int boardDimX, int boardDimY)
        {
            this.boardDimX = boardDimX;
            this.boardDimY = boardDimY;
        }

        internal void Populate(int [,] map)
        {
            Random rnd = new Random();

            int[,] pop = new int[boardDimX, boardDimY];

            for (int x = 0; x <boardDimX; x++)
                for (int y = 0; y < boardDimY; y++)
                {
                    switch (map[x, y])
                    {
                        case (int)TerrainKind.grass:
                            pop[x, y] = rnd.Next((int)PopulationSettings.minimal, (int)PopulationSettings.maximal);
                            break;
                        case (int)TerrainKind.city:
                            pop[x, y] = (int)PopulationSettings.city_factor * rnd.Next((int)PopulationSettings.minimal, (int)PopulationSettings.maximal);
                            break;
                        case (int)TerrainKind.water:
                            pop[x, y] = 0;
                            break;
                        case (int)TerrainKind.road:
                            pop[x, y] = 0;
                            break;
                        default:
                            break;
                    }
                }
        }
    }
}
