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
        public Pane pane;

        public PosXY currentPositionXY = new PosXY();

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
            //initial drawings
            Draw.setBackgroundBoardColor(graphics, globalParameters.boardDimX, globalParameters.boardDimY, globalParameters.boardBoxDim);
            Draw.drawBoardGrid(graphics, globalParameters.boardDimX, globalParameters.boardDimY, globalParameters.boardBoxDim);

            //init map
            Terrain map = new Terrain(globalParameters.boardDimX, globalParameters.boardDimY);
            map.Load_Map();
            Draw.drawMapFull(graphics, globalParameters.boardDimX, globalParameters.boardDimY, globalParameters.boardBoxDim, map.map);

            //populate civilians
            Population pop = new Population(globalParameters.boardDimX, globalParameters.boardDimY);
            pop.Populate(map.map);

            //pane init
            pane = new Pane(globalParameters.boardDimX, globalParameters.boardDimY, globalParameters.boardBoxDim);

            InfantryHeavyArmy a = new InfantryHeavyArmy();
            a.posX = 0;
            a.posY = 0;
            a.DrawArmyXY(graphics, globalParameters.boardBoxDim);
        }

        private void Board_Load(object sender, EventArgs e)
        {
            graphics = CreateGraphics();
        }

        private void Board_Shown(object sender, EventArgs e)
        {
            GameIsOn();
        }

        private void Board_MouseMove(object sender, MouseEventArgs e)
        {
            pane.RefreshInfoPaneXY(e, ref currentPositionXY);
        }

    }
}
