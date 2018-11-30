using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allu2
{
    public class Pane
    {
        internal static void RefreshInfoPaneXY(MouseEventArgs e, PosXY CurrentPositionXY)
        {
            var TempPositionXY = new PosXY();
            //to fix at very beginning
            //TempPositionXY = Terra.GetPositionXY(e.X, e.Y);
            if (CurrentPositionXY != TempPositionXY)
            {

            }

        }
    }
}
