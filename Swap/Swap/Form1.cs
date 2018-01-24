using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap
{
    public partial class Form1 : Form
    {

        Elephant lloyd;
        Elephant lucinda;
        

        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        }

        private void Lloyd_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void Lucinda_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void swap_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = lucinda;
            lucinda = lloyd;
            lloyd = holder;

            MessageBox.Show("Values have been swapped");
        }
    }
}
