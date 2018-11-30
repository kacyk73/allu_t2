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
            TempPositionXY = GetPositionXY(e.X, e.Y);
            if (CurrentPositionXY != TempPositionXY)
            {

            }

        }

        internal static PosXY GetPositionXY(int x, int y)
        {
            var result = new PosXY();

            //if ((x >= 0) && (y >= 0) && (x < glb_settings.get_map_dim_parameter_x() * glb_settings.get_map_box_size())
            //    && (y < glb_settings.get_map_dim_parameter_y() * glb_settings.get_map_box_size()))
            //{
            //    result.PosX = x / glb_settings.get_map_box_size();
            //    result.PosY = y / glb_settings.get_map_box_size();
            //}

            return result;
        }
    }
}
