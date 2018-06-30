using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017C.Capitulo01.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {

            var ValorPago = Convert.ToDecimal(ValorPagotTextBox.Text);
            var ValorCompra = Convert.ToDecimal(ValorCompraTextBox.Text);

            var Troco = ValorPago - ValorCompra;

            TrocoTextBox.Text = Troco.ToString("c2");

            var moedas1 = (int)(Troco/1);// Cast
            Troco = Troco % 1;

            var moedas050 = (int)(Troco / 0.5m);// Cast
            Troco %= 0.5m;

            var moedas025 = (int)(Troco / 0.25m);// Cast
            Troco %= 0.25m;

            var moedas010 = (int)(Troco / 0.1m);// Cast
            Troco %= 0.1m;

            var moedas005 = (int)(Troco / 0.05m);// Cast
            Troco %= 0.05m;

            var moedas001 = (int)(Troco / 0.01m);// Cast
            Troco %= 0.01m;

            MoedasListView.Items[0].Text = moedas1.ToString();
            MoedasListView.Items[1].Text = moedas050.ToString();
            MoedasListView.Items[2].Text = moedas025.ToString();
            MoedasListView.Items[3].Text = moedas010.ToString();
            MoedasListView.Items[4].Text = moedas005.ToString();
            MoedasListView.Items[5].Text = moedas001.ToString();

        }
    }
}
