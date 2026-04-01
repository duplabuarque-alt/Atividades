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
    public partial class CalcIMC : Form
    {
        public CalcIMC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu projetoMenu = new menu();
            projetoMenu.Show();
            this.Hide();
        }

        private void bttcalc_Click(object sender, EventArgs e)
        {
            float labalt = float.Parse(txtAlt.Text);
            int labKg = int.Parse(txtkg.Text);
            float IMC = labKg / (labalt * labalt);
            if (IMC <= 18.5)
            {
                labResult.Text = "Abaixo do Peso";
                labResult.Visible = true;
            }
            else if (IMC > 18.5 && IMC <= 25)
            {
                labResult.Text = "Peso Normal";
                labResult.Visible = true;
            }
            else if (IMC > 25 && IMC <= 30)
            {
                labResult.Text = "SobrePeso";
                labResult.Visible = true;
            }
            else if (IMC > 30 && IMC <= 35)
            {
                labResult.Text = "Obesidade Grau 1";
                labResult.Visible = true;
            }
            else if (IMC > 35 && IMC <= 40)
            {
                labResult.Text = "Obesidade Severa";
                labResult.Visible = true;
            }
            else if (IMC > 40)
            {
                labResult.Text = "Obesidade Morbida";
                labResult.Visible = true;
            }
        }
    }
    
}
