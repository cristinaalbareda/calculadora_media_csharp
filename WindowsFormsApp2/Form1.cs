using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void valor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            decimal val_1 = decimal.Parse(valor1.Text);
            decimal val_2 = decimal.Parse(valor2.Text);
            decimal val_3 = decimal.Parse(valor3.Text);
            decimal calcular;
            
            calcular = (val_1 + val_2 + val_3) / 3;
            media.Text = calcular.ToString("0.00");


            decimal med = Convert.ToDecimal(media.Text);
           

            if (med >= 7)
            {
                situacao.Text = "Aprovado!";
            }
            else
            {
                situacao.Text = "Reprovado :(";
            }

        }

        private void situacao_Click(object sender, EventArgs e)
        {
          
           
        }

        private void sair_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Tem certeza que deseja sair?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Teste condicional para aceitar números no textbox
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }

            //Teste condicional para aceitar a tecla Backspace e vírgula
            if (e.KeyChar == 8 || e.KeyChar == 44)
            {
                e.Handled = false;
            }
        }

        private void txtNota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 8 || e.KeyChar == 44)
            {
                e.Handled = false;
            }
        }

        private void txtNota3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 8 || e.KeyChar == 44)
            {
                e.Handled = false;
            }
        }

        private void txtNota4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 8 || e.KeyChar == 44)
            {
                e.Handled = false;
            }
        }

    }
    
}
