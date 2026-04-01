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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu projetoMenu = new menu();
            projetoMenu.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttcalc_Click(object sender, EventArgs e)
        {
            float nota1 = float.Parse(txtnota1.Text);
            float nota2 = float.Parse(txtnota2.Text);
            float nota3 = float.Parse(txtnota3.Text);
            float media = (nota1 + nota2 + nota3) / 3;
            string nome = txtnome.Text;
            if (media >= 5 && media <= 10)
            {
                LabResult.Text = nome + " passou!!! Sua media foi: " + media;
                LabResult.Visible = true;

            }
            else if (media < 5 && media <= 10)
            {
                LabResult.Text = nome + " Reprovou >:( Sua media foi: " + media;
                LabResult.Visible = true;
            }
            else
            {
                LabResult.Text = nome + " Tu não sabe digitar não? TENTA DENOVO";
                LabResult.Visible = true;
            }

        }
    }
}

