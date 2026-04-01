using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicioC_
{
    public partial class CalcArea : Form
    {
        public CalcArea()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu projetoMenu = new menu();
            projetoMenu.Show();
            this.Hide();
        }
    }
}
