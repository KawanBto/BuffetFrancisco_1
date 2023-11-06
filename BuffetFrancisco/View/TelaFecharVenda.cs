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
    public partial class TelaFecharVenda : Form
    {

        private int tudo;

        public TelaFecharVenda(int tudo)
        {
            this.tudo = tudo;
            InitializeComponent();
        }

        private void TelaFecharVenda_Load(object sender, EventArgs e)
        {
            lbl_data.Text = DateTime.Now.ToString();
            lbl_valorvenda.Text = "R$ " + tudo + ",00".ToString();
        }
    }
}
