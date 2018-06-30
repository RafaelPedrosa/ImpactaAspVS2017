namespace AspNetVS2017C.Capitulo01.Troco
{
    partial class TrocoForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocoForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 5, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 4, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 3, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 2, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ValorCompraTextBox = new System.Windows.Forms.TextBox();
            this.ValorPagotTextBox = new System.Windows.Forms.TextBox();
            this.TrocoTextBox = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MoedasImageList = new System.Windows.Forms.ImageList(this.components);
            this.MoedasListView = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.CalcularButton);
            this.groupBox1.Controls.Add(this.TrocoTextBox);
            this.groupBox1.Controls.Add(this.ValorPagotTextBox);
            this.groupBox1.Controls.Add(this.ValorCompraTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da compra -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor pago -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor do Troco -";
            // 
            // ValorCompraTextBox
            // 
            this.ValorCompraTextBox.Location = new System.Drawing.Point(106, 20);
            this.ValorCompraTextBox.Name = "ValorCompraTextBox";
            this.ValorCompraTextBox.Size = new System.Drawing.Size(150, 20);
            this.ValorCompraTextBox.TabIndex = 1;
            // 
            // ValorPagotTextBox
            // 
            this.ValorPagotTextBox.Location = new System.Drawing.Point(106, 55);
            this.ValorPagotTextBox.Name = "ValorPagotTextBox";
            this.ValorPagotTextBox.Size = new System.Drawing.Size(150, 20);
            this.ValorPagotTextBox.TabIndex = 2;
            // 
            // TrocoTextBox
            // 
            this.TrocoTextBox.Location = new System.Drawing.Point(106, 90);
            this.TrocoTextBox.Name = "TrocoTextBox";
            this.TrocoTextBox.ReadOnly = true;
            this.TrocoTextBox.Size = new System.Drawing.Size(150, 20);
            this.TrocoTextBox.TabIndex = 3;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalcularButton.Location = new System.Drawing.Point(6, 321);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(250, 32);
            this.CalcularButton.TabIndex = 4;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.MoedasListView);
            this.groupBox2.Location = new System.Drawing.Point(268, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 359);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Troco";
            // 
            // MoedasImageList
            // 
            this.MoedasImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MoedasImageList.ImageStream")));
            this.MoedasImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MoedasImageList.Images.SetKeyName(0, "1.png");
            this.MoedasImageList.Images.SetKeyName(1, "5.png");
            this.MoedasImageList.Images.SetKeyName(2, "10.png");
            this.MoedasImageList.Images.SetKeyName(3, "25.png");
            this.MoedasImageList.Images.SetKeyName(4, "50.png");
            this.MoedasImageList.Images.SetKeyName(5, "100.png");
            // 
            // MoedasListView
            // 
            this.MoedasListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoedasListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.MoedasListView.LargeImageList = this.MoedasImageList;
            this.MoedasListView.Location = new System.Drawing.Point(3, 16);
            this.MoedasListView.Name = "MoedasListView";
            this.MoedasListView.Size = new System.Drawing.Size(656, 340);
            this.MoedasListView.TabIndex = 0;
            this.MoedasListView.UseCompatibleStateImageBehavior = false;
            this.MoedasListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // TrocoForm
            // 
            this.AcceptButton = this.CalcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 383);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TrocoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App de Troco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.TextBox TrocoTextBox;
        private System.Windows.Forms.TextBox ValorPagotTextBox;
        private System.Windows.Forms.TextBox ValorCompraTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView MoedasListView;
        private System.Windows.Forms.ImageList MoedasImageList;
    }
}

