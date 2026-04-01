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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void bttOrdenaNum_Click(object sender, EventArgs e)
        {
            OrdenaNum projetoOrdena = new OrdenaNum();
            projetoOrdena.Show();
            this.Hide();
        }

        private void bttQuaLiga_Click(object sender, EventArgs e)
        {
            QualiLiga ProjetoLiga = new QualiLiga();
            ProjetoLiga.Show();
            this.Hide();
        }

        private void calcIMC_Click(object sender, EventArgs e)
        {
            CalcIMC projetoIMC = new CalcIMC();
            projetoIMC.Show();
            this.Hide();
        }

        private void bttcalcnota_Click(object sender, EventArgs e)
        {
             Form1 projetoCalcNota = new Form1();  
            projetoCalcNota.Show();
            this.Hide();
        }

        private void bttCalcArea_Click(object sender, EventArgs e)
        {
            CalcArea projetoArea = new CalcArea();
            projetoArea.Show();
            this.Hide();
        }

        private void bttTipoTri_Click(object sender, EventArgs e)
        {
            TipoTri projetoTipoTri = new TipoTri();
            projetoTipoTri.Show();
            this.Hide();
        }

        private void bbtMaiorMenor_Click(object sender, EventArgs e)
        {
            MaiorMenor projetoMaiorMenor = new MaiorMenor();
            projetoMaiorMenor.Show();
            this.Hide();
        }
    }
}
