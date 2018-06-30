namespace AspNetVS2017.Capitulo1.Tabuada
{
    partial class TabuadaForm
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
            this.TabuadaListBox = new System.Windows.Forms.ListBox();
            this.TabuadaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TabuadaListBox
            // 
            this.TabuadaListBox.FormattingEnabled = true;
            this.TabuadaListBox.Location = new System.Drawing.Point(12, 38);
            this.TabuadaListBox.Name = "TabuadaListBox";
            this.TabuadaListBox.Size = new System.Drawing.Size(268, 225);
            this.TabuadaListBox.TabIndex = 1;
            // 
            // TabuadaTextBox
            // 
            this.TabuadaTextBox.Location = new System.Drawing.Point(12, 12);
            this.TabuadaTextBox.Name = "TabuadaTextBox";
            this.TabuadaTextBox.Size = new System.Drawing.Size(268, 20);
            this.TabuadaTextBox.TabIndex = 0;
            this.TabuadaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabuadaTextBox_KeyPress);
            // 
            // TabuadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.TabuadaTextBox);
            this.Controls.Add(this.TabuadaListBox);
            this.Name = "TabuadaForm";
            this.Text = "App da Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TabuadaListBox;
        private System.Windows.Forms.TextBox TabuadaTextBox;
    }
}

