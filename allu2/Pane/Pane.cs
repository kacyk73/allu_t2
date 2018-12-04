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
        private int boardDimX;
        private int boardDimY;
        private int boardBoxDim;

        public Pane(int boardDimX, int boardDimY, int boardBoxDim)
        {
            this.boardDimX = boardDimX;
            this.boardDimY = boardDimY;
            this.boardBoxDim = boardBoxDim;
        }

        internal void RefreshInfoPaneXY(MouseEventArgs e, PosXY CurrentPositionXY)
        {
            var TempPositionXY = new PosXY();
            //to fix at very beginning
            TempPositionXY = GetPositionXY(e.X, e.Y);
            if (CurrentPositionXY != TempPositionXY)
            {

            }

        }

        internal PosXY GetPositionXY(int x, int y)
        {
            var result = new PosXY();

            if ((x >= 0) && (y >= 0) && (x <  boardDimX * boardBoxDim)
                && (y < boardDimY * boardBoxDim))
            {
                result.PosX = x / boardBoxDim;
                result.PosY = y / boardBoxDim;
            }

            return result;
        }
    }
}
