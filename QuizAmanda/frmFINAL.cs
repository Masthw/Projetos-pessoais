using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizAmanda
{
    public partial class frmFINAL : Form
    {
        public frmFINAL()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblErros_Click(object sender, EventArgs e)
        {

        }

        private void frmFINAL_Load(object sender, EventArgs e)
        {
            lblAcertos.Text = VariaveisGlobais.Acertos.ToString();
            lblErros.Text = VariaveisGlobais.Erros.ToString();

            if (VariaveisGlobais.Acertos == 10)
            {
                lblMensagem.Text = "Meus parabéns você me ama MUITOOO! ACERTOU TODAS UHULLLL 10/10, infelizmente eu te amo BEM MAIS 15/10";
            }
            else if (VariaveisGlobais.Acertos < 10 && VariaveisGlobais.Acertos >= 7)
            {
                lblMensagem.Text = "Alguns errinhos mas tudo bem você me conhece bem, te amo";
            }
            else if (VariaveisGlobais.Acertos < 7 && VariaveisGlobais.Acertos >= 4)
            {
                lblMensagem.Text = "Meu deus amor você não me conhece, tudo bem os de verdade eu sei quem são!!";
            }
            else if (VariaveisGlobais.Acertos < 4)
            {
                lblMensagem.Text = "??????????????MENOS DE 4????????????? VC NÃO ME CONHECE NADA";
            }
        }
    }
}
