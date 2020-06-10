using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_reajuste
{
    public partial class frm_Reajuste : Form
    {
        public frm_Reajuste()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {

            if (txt_Nome.Text == "" || txt_Salario.Text == "")
            {

                MessageBox.Show("Informe seu nome e salário para calcular o reajuste!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                DesenvolvedorWeb devw = new DesenvolvedorWeb();
                Designer des = new Designer();
                Programador prog = new Programador();

                decimal salario;
                string nome;

                salario = Convert.ToDecimal(txt_Salario.Text);
                nome = txt_Nome.Text;

                if (rdb_DesenvolvedorWeb.Checked)
                {
                    devw.salario = salario;
                    devw.Reajustar();
                    txt_Reajuste.Text = devw.salario.ToString();

                }
                else if (rdb_Designer.Checked)
                {
                    des.salario = salario;
                    des.Reajustar();
                    txt_Reajuste.Text = des.salario.ToString();

                }
                else if (rdb_Programador.Checked)
                {
                    prog.salario = salario;
                    prog.Reajustar();
                    txt_Reajuste.Text = prog.salario.ToString();

                }
                else
                {
                    MessageBox.Show("Escolha uma profissão para fazer o reajuste!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Salario.Clear();
            txt_Nome.Clear();
            txt_Reajuste.Clear();
            rdb_DesenvolvedorWeb.Checked = false;
            rdb_Designer.Checked = false;
            rdb_Programador.Checked = false;
            pcb_Imagens.Image = Properties.Resources.salario;
            txt_Nome.Focus();
        }

        private void rdb_DesenvolvedorWeb_CheckedChanged(object sender, EventArgs e)
        {
            pcb_Imagens.Image = Properties.Resources.devweb;
        }

        private void rdb_Programador_CheckedChanged(object sender, EventArgs e)
        {
            pcb_Imagens.Image = Properties.Resources.programador;
        }

        private void rdb_Designer_CheckedChanged(object sender, EventArgs e)
        {
            pcb_Imagens.Image = Properties.Resources.designer;
        }

        private void frm_Reajuste_Load(object sender, EventArgs e)
        {
            pcb_Imagens.Image = Properties.Resources.salario;
        }

        private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txt_Salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}
