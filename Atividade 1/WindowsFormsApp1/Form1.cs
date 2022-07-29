using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcularFrete();
        }


        void calcularFrete()
        {
            int valor = int.Parse(txtValor.Text);

            if (valor >= 1000)
            {
                label2.Text = Convert.ToString(0);
            }
            else if (cbxUF.SelectedItem.ToString() == "RJ")
            {
                label2.Text = Convert.ToString(10);
            }
            else if (cbxUF.SelectedItem.ToString() == "AM")
            {
                label2.Text = Convert.ToString(20);
            }
            else if (cbxUF.SelectedItem.ToString() == "SP")
            {
                label2.Text = Convert.ToString(5);
            }
            else if (cbxUF.SelectedItem.ToString() == "Outros...")
            {
                label2.Text = Convert.ToString(15);
            }
            else
            {
                MessageBox.Show("As caixas estão vazias, preencha os campos!");
            }
            label1.Text = Convert.ToString(valor);
            label3.Text = Convert.ToString(valor + Convert.ToInt32(label2.Text));
        }
        void LimparCampos()
        {
            label1.Text = "------";
            label2.Text = "------";
            label3.Text = "------";
            txtNome.Text = "";
            txtValor.Text = "";
            cbxUF.Text = "";
        }
    }

}
