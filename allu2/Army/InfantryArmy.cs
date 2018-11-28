using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu2
{
    public class InfantryArmy : Army, IArmyDrawable
    {
        public void DrawArmyXY(Graphics graphics, int boardBoxDim)
        {
            var c = Color.White;
            var pen = new Pen(c);
            int x = this.posX * boardBoxDim;
            int y = this.posX * boardBoxDim;

            graphics.DrawLine(pen, x + 2, y + 4, x + 10, y + 4);
            graphics.DrawLine(pen, x + 2, y + 14, x + 10, y + 14);
            graphics.DrawLine(pen, x + 6, y + 4, x + 6, y + 14);
        }
    }
}
