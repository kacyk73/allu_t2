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
    public partial class main : Form
    {

        public main()
        {
            InitializeComponent();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {

            Board board = new Board();

            board.ShowDialog();

            this.Close();

        }
    }
}
