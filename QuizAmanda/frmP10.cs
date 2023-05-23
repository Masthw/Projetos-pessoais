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
    public partial class frmP10 : Form
    {
        public frmP10()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            //somar a VariavelGlobalAcertos
            if (rbtnCerta.Checked == true)
            {
                VariaveisGlobais.Acertos++;
                frmFINAL FINAL = new frmFINAL();
                FINAL.ShowDialog();
                this.Dispose();
            }
            //Se não somar VariavelGlobalErros
            else if (radioButton1.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                VariaveisGlobais.Erros++;
                frmFINAL FINAL = new frmFINAL();
                FINAL.ShowDialog();
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
