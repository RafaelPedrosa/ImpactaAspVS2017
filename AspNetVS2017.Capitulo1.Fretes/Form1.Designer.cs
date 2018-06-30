namespace AspNetVS2017.Capitulo1.Fretes
{
    partial class FreteForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.ValorTextBox = new System.Windows.Forms.TextBox();
            this.FreteTextBox = new System.Windows.Forms.TextBox();
            this.UfComboBox = new System.Windows.Forms.ComboBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.LimparButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Uf -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "%Frete -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Cliente -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "&Valor -";
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Location = new System.Drawing.Point(63, 6);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.Size = new System.Drawing.Size(207, 20);
            this.ClienteTextBox.TabIndex = 1;
            // 
            // ValorTextBox
            // 
            this.ValorTextBox.Location = new System.Drawing.Point(63, 44);
            this.ValorTextBox.Name = "ValorTextBox";
            this.ValorTextBox.Size = new System.Drawing.Size(207, 20);
            this.ValorTextBox.TabIndex = 2;
            // 
            // FreteTextBox
            // 
            this.FreteTextBox.Location = new System.Drawing.Point(63, 117);
            this.FreteTextBox.Name = "FreteTextBox";
            this.FreteTextBox.ReadOnly = true;
            this.FreteTextBox.Size = new System.Drawing.Size(207, 20);
            this.FreteTextBox.TabIndex = 4;
            // 
            // UfComboBox
            // 
            this.UfComboBox.FormattingEnabled = true;
            this.UfComboBox.Items.AddRange(new object[] {
            "AM",
            "MG",
            "RJ",
            "SP",
            "Outros"});
            this.UfComboBox.Location = new System.Drawing.Point(63, 82);
            this.UfComboBox.Name = "UfComboBox";
            this.UfComboBox.Size = new System.Drawing.Size(207, 21);
            this.UfComboBox.TabIndex = 3;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(63, 178);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(99, 23);
            this.Calcularbutton.TabIndex = 6;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(63, 152);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(207, 20);
            this.TotalTextBox.TabIndex = 5;
            // 
            // LimparButton
            // 
            this.LimparButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LimparButton.Location = new System.Drawing.Point(171, 178);
            this.LimparButton.Name = "LimparButton";
            this.LimparButton.Size = new System.Drawing.Size(99, 23);
            this.LimparButton.TabIndex = 7;
            this.LimparButton.Text = "Limpar";
            this.LimparButton.UseVisualStyleBackColor = true;
            this.LimparButton.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total -";
            // 
            // FreteForm
            // 
            this.AcceptButton = this.Calcularbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.LimparButton;
            this.ClientSize = new System.Drawing.Size(283, 206);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LimparButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.UfComboBox);
            this.Controls.Add(this.FreteTextBox);
            this.Controls.Add(this.ValorTextBox);
            this.Controls.Add(this.ClienteTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FreteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Frete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClienteTextBox;
        private System.Windows.Forms.TextBox ValorTextBox;
        private System.Windows.Forms.TextBox FreteTextBox;
        private System.Windows.Forms.ComboBox UfComboBox;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Button LimparButton;
        private System.Windows.Forms.Label label5;
    }
}

