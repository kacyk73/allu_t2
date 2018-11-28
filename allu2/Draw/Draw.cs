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
    }
}
    