using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo1.Fretes
{
    public partial class FreteForm : Form
    {
        public FreteForm()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {

            var erros = ValidarFormulario();

            if (erros.Count == 0)
            {
                Calcular();
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, erros),
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Calcular()
        {
            var percentual = 0m;
            var valor = Convert.ToDecimal(ValorTextBox.Text);
            var nordeste = new List<string> { "BA", "PE", "AL" };
            switch (UfComboBox.Text.ToUpper())
            {
                case "SP":
                    percentual = 0.2m;
                    break;
                case "AM":
                    percentual = 0.6m;
                    break;
                case "RJ":
                    percentual = 0.3m;
                    break;

                case var uf when nordeste.Contains(uf):
                    percentual = 0.4m;
                    break;                

                case "MG":
                    percentual = 0.35m;
                    break;

                case null:
                    throw new NullReferenceException("A UF não pode ser nula.");


                default:
                    percentual = 0.75m;
                    break;
            }

            FreteTextBox.Text = percentual.ToString("P2");
            TotalTextBox.Text = (valor * (1 + percentual)).ToString("C2");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<string> ValidarFormulario()
        {

            var erros = new List<string>();

            if (ClienteTextBox.Text.Trim() == string.Empty)
            {
                erros.Add("É obrigatório adicionar o nome do cliente!");
            }
            // Se o campo for Vazio.
            if (string.IsNullOrEmpty(ValorTextBox.Text.Trim()))
            {
                erros.Add("O campo valor é obrigatório!");
            }
            else
            {
                if (!decimal.TryParse(ValorTextBox.Text.Trim(), out decimal valor))
                {
                    erros.Add("O campo valor está com o formato inálido.");
                }
            }

            if (UfComboBox.SelectedIndex == -1)
            {
                erros.Add("Selecione uma UF de destino");
            }

            return erros;

        }

        private void LimparButton_Click(object sender, EventArgs e)
        {

            ClienteTextBox.Text = "";
            ValorTextBox.Text = String.Empty;
            UfComboBox.SelectedIndex = -1;
            FreteTextBox.Clear();
            TotalTextBox.Clear();

            ClienteTextBox.Focus();

        }
    }
}
