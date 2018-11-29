using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu2
{
    public static class Draw
    {
        internal static void drawBoardGrid(Graphics graphics, int boardDimX, int boardDimY, int boardBoxDim)
        {
            var c = Color.Black;
            var pen = new Pen(c);

            for (int x = 0; x <= boardDimX; x++)
            {
                graphics.DrawLine(pen, x * boardBoxDim, 0, x*boardBoxDim, boardDimY * boardBoxDim);
            }
            for (int y = 0; y <= boardDimY; y++)
            {
                graphics.DrawLine(pen, 0, y * boardBoxDim, boardDimX * boardBoxDim, y * boardBoxDim);
            }
        }

        internal static void setBackgroundBoardColor(Graphics graphics, int boardDimX, int boardDimY, int boardBoxDim)
        {
            var c = Color.DarkGreen;
            var pen = new SolidBrush(c);
            graphics.FillRectangle(pen, 0, 0, boardDimX * boardBoxDim, boardDimY * boardBoxDim);
        }

        internal static void drawMapFull(Graphics graphics, int boardDimX, int boardDimY, int boardBoxDim, int[,] map)
        {

            //iterate through the map
            for (int i = 0; i < boardDimX; i++)
            {
                for (int j = 0; j < boardDimY; j++)
                {
                    DrawMapXY(graphics, boardBoxDim, map[i, j], i, j);

                }
            }
        }

        internal static void DrawMapXY(Graphics graphics, int boardBoxDim, int mapXYType, int x, int y)
        {
            Brush c;

            switch (mapXYType)
            {
                case (int)TerrainKind.grass:
                    c = Brushes.DarkGreen;
                    break;
                case (int)TerrainKind.road:
                    c = Brushes.DarkSlateGray;
                    break;
                case (int)TerrainKind.city:
                    c = Brushes.DarkOliveGreen;
                    break;
                case (int)TerrainKind.water:
                    c = Brushes.Navy;
                    break;
                default:
                    c = Brushes.DarkGreen;
                    break;
            }

            //draw actual box
            graphics.FillRectangle(c, x * boardBoxDim + 1, y * boardBoxDim + 1, boardBoxDim - 1, boardBoxDim - 1);
        }
    }
}
    