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
    public partial class VariaveisForm : Form
    {

        int _x = 32;
        int _w = 45;
        int _y = 16;
        int _z = 32;

        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Exemplicar a diferanã entre class e struct
            //decimal brimestre1 = 4.44m;
            //string meuNome = "Rafael";
            //var Nascimento = new DateTime(1970, 05, 14);
            //int @int = 10;
            //var class = 10;

            int a = 2;
            int b = 6;
            int c = 10;
            var d = 13;

            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add(string.Concat("b = ",b));
            resultadoListBox.Items.Add(string.Format("c = {0:C}",c));
            resultadoListBox.Items.Add($"d = {d}");

            resultadoListBox.Items.Add("C * D =" + (c * d));
            resultadoListBox.Items.Add("C / D =" + (c / Convert.ToDecimal(d)));
            resultadoListBox.Items.Add("D % A =" + (d % a));

        }

        private void operacoesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var x = 5;

            resultadoListBox.Items.Add("x = " + x);

            //x = x - 3; Escrita de forma reduzida abaixo
            x -= x;
            resultadoListBox.Items.Add("x = " + x);


        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int a;
            a = 5;
            resultadoListBox.Items.Add("Exemplo de pré-incremental");
            resultadoListBox.Items.Add("A = "+a);
            resultadoListBox.Items.Add("2 + ++A = " + (2 + ++a));
            resultadoListBox.Items.Add("A = " + a);

            resultadoListBox.Items.Add("------------------------");

            a = 5;
            resultadoListBox.Items.Add("Exemplo de pós-incremental");
            resultadoListBox.Items.Add("A = " + a);
            resultadoListBox.Items.Add("2 + A++ = " + (2 + a++));
            resultadoListBox.Items.Add("A = " + a);

        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirValoresVariaveis();

            resultadoListBox.Items.Add("W <= X = " + (_w < _x));
            resultadoListBox.Items.Add("X == Z = " + (_x == _z));
            resultadoListBox.Items.Add("X != Z = " + (_x != _z));

        }

        private void ExibirValoresVariaveis()
        {
            resultadoListBox.Items.Add("X  = " + _x);
            resultadoListBox.Items.Add("Y = " + _y);
            resultadoListBox.Items.Add("W = " + _w);
            resultadoListBox.Items.Add("Z = " + _z);

            resultadoListBox.Items.Add(new string('-', 50));
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirValoresVariaveis();

            //Preceência 
            //1º Negação (!)
            //2º E (&&)
            //3° OU (||)

            resultadoListBox.Items.Add("W < X || Y == 16 = " + (_w < _x || _y == 16));
            resultadoListBox.Items.Add("X == Z && Z != X = " + (_x == _z && _z != _x));
            resultadoListBox.Items.Add("Y > W  = " + (!(_y > _w)));



        }

        private void ternariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;

            ano = 2018;
            resultadoListBox.Items.Add($"O ano {ano} é bissexto? {(ano % 4 == 0 ? "SIM":"Não")}");

            ano = 2020;
            resultadoListBox.Items.Add($"O ano {ano} é bissexto? {(DateTime.IsLeapYear(2020)? "SIM" : "Não")}");

        }
    }
}
