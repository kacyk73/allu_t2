using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allu2
{
    public partial class Board : Form
    {
        public GlobalParameters globalParameters;
        public Graphics graphics;

        public Board()
        {
            InitializeComponent();
            globalParameters = new GlobalParameters();
        }

        private void btnBoardExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameIsOn()
        {
            //Graphics graphics = CreateGraphics();

            Draw.drawBoardGrid(graphics, globalParameters.boardDimX, globalParameters.boardDimY, globalParameters.boardBoxDim);
        }

        private void Board_Load(object sender, EventArgs e)
        {
            graphics = CreateGraphics();
        }

        private void Board_Shown(object sender, EventArgs e)
        {
            GameIsOn();
        }
    }
}
