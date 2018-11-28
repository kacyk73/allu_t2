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

        public Board()
        {
            InitializeComponent();
            globalParameters = new GlobalParameters();
            GameIsOn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameIsOn()
        {
            
        }
    }
}
