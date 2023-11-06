using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuffetFrancisco.View
{
    public partial class PDVTela : Form
    {
        int tudo = 0;
        public PDVTela()
        {
            InitializeComponent();
        }

        private void btn_pastel_Click(object sender, EventArgs e)
        {
            string registropastel = "12";

            txt_cod.Text = registropastel;
        }

        private void btn_coxinha_Click(object sender, EventArgs e)
        {
            string registrocoxinha = "13";

            txt_cod.Text = registrocoxinha;
        }

        private void btn_esfiha_Click(object sender, EventArgs e)
        {
            string registroesfiha = "14";

            txt_cod.Text = registroesfiha;
        }

        private void btn_paodequeijo_Click(object sender, EventArgs e)
        {
            string registropaodequeijo = "15";

            txt_cod.Text = registropaodequeijo;
        }

        private void btn_cafe_Click(object sender, EventArgs e)
        {
            string registrocafe = "16";

            txt_cod.Text = registrocafe;
        }

        private void btn_refri_Click(object sender, EventArgs e)
        {
            string registrorefri = "17";

            txt_cod.Text = registrorefri;
        }

        private void btn_suco_Click(object sender, EventArgs e)
        {
            string registrosuco = "18";

            txt_cod.Text = registrosuco;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string codigo = txt_cod.Text;
            int qtd = ((int)num_qtde.Value);

            string[] itens = { "Pastel", "Coxinha", "Esfiha", "Pão de Queijo", "Café", "Refrigerante", "Sucos" };
            int[] valor = { 8, 8, 8, 7, 15, 10, 12 };
            int total = 0;
            int cont = 11;
            string convert = txt_cod.Text;
            int contagem = Convert.ToInt32(convert);
            int i = -1;

            do
            {
                cont += 1;
                i += 1;


                if (contagem == cont)
                {
                    total = qtd * valor[i];
                    tudo += total;
                    dataGridViewPDV.Rows.Add(itens[i], num_qtde.Value, valor[i], total);
                    lbl_vt.Text = "R$: " + tudo.ToString() + ",00";
                }

            } while (contagem != cont);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            lbl_vt.Text = string.Empty;
            txt_cod.Text = string.Empty;
            num_qtde.Value = 0;
            dataGridViewPDV.Rows.Clear();
            tudo = 0;
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            TelaFecharVenda telaFecharVenda = new TelaFecharVenda();
            telaFecharVenda.Show();
        }
    }
}
