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
    public partial class frmP6 : Form
    {
        public frmP6()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            //somar a VariavelGlobalAcertos
            if (rbtnCerta.Checked == true)
            {
                VariaveisGlobais.Acertos++;
                frmP7 p7 = new frmP7();
                p7.ShowDialog();
                this.Dispose();
            }
            //Se não somar VariavelGlobalErros
            else if (radioButton1.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                VariaveisGlobais.Erros++;
                frmP7 p7 = new frmP7();
                p7.ShowDialog();
                this.Dispose();
            }
            //Caso nao escolha nenhuma opção não deixa avançar
            else
            {
                MessageBox.Show("Escolha uma opção!");
            }
        }
    }
}
