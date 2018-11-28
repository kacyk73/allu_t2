using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allu2
{
    public class InfantryLightArmy: InfantryArmy, IArmyDrawable
    {
        public new void DrawArmyXY(Graphics graphics, int boardBoxDim)
        {
            var c = Color.White;
            var pen = new Pen(c);
            int x = this.posX * boardBoxDim;
            int y = this.posX * boardBoxDim;

            base.DrawArmyXY(graphics, boardBoxDim);

            graphics.DrawLine(pen, x + 2, y + 2, x + 10, y + 2);

        }
    }
}
