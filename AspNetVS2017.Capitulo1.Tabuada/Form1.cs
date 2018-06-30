using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo1.Tabuada
{
    public partial class TabuadaForm : Form
    {
        public TabuadaForm()
        {
            InitializeComponent();
        }

        private void TabuadaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //\b = BackSpcae | \r = Espaço(Return) | \0 = Nulo
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == '\r')
            {

                if (e.KeyChar == 13)
                {
                    Calcular();
                }   
            

            }
            else
            {
                e.Handled = true;
                e.KeyChar = '\0';
              

            }
        }

        private void Calcular()
        {
            TabuadaListBox.Items.Clear();
            var tabuada = Convert.ToInt32(TabuadaTextBox.Text);

            for (int i = 0; i <= 10; i++)
            {
                TabuadaListBox.Items.Add($"{tabuada} X {i} = {tabuada * i}");
            }
            
            TabuadaTextBox.Focus();
            TabuadaTextBox.SelectAll();

        }
    }
}
