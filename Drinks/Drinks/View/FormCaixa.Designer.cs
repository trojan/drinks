namespace Drinks.View
{
    partial class FormCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaixa));
            this.PanelBackground = new System.Windows.Forms.PictureBox();
            this.textBoxTotalPagar = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxValorTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.caixaTitle = new System.Windows.Forms.Label();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CancelarBtnIcon = new System.Windows.Forms.PictureBox();
            this.labelbtnCancelar = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBoxProdutoInformation = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNovoItem = new System.Windows.Forms.Button();
            this.buttonGravarItem = new System.Windows.Forms.Button();
            this.buttonExcluirItem = new System.Windows.Forms.Button();
            this.buttonVisualizarItem = new System.Windows.Forms.Button();
            this.dgvItemVenda = new System.Windows.Forms.DataGridView();
            this.IDPRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_TOTAL_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelarBtnIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(720, 42);
            this.PanelBackground.TabIndex = 7;
            this.PanelBackground.TabStop = false;
            // 
            // textBoxTotalPagar
            // 
            this.textBoxTotalPagar.Enabled = false;
            this.textBoxTotalPagar.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.textBoxTotalPagar.Location = new System.Drawing.Point(409, 335);
            this.textBoxTotalPagar.Name = "textBoxTotalPagar";
            this.textBoxTotalPagar.Size = new System.Drawing.Size(299, 38);
            this.textBoxTotalPagar.TabIndex = 11;
            this.textBoxTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.textBoxValor.Location = new System.Drawing.Point(409, 174);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(299, 32);
            this.textBoxValor.TabIndex = 12;
            this.textBoxValor.TextChanged += new System.EventHandler(this.textBoxValor_TextChanged);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.textBoxQuantidade.Location = new System.Drawing.Point(409, 120);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(299, 32);
            this.textBoxQuantidade.TabIndex = 13;
            this.textBoxQuantidade.TextChanged += new System.EventHandler(this.textBoxQuantidade_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label1.Location = new System.Drawing.Point(406, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "QUANTIDADE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label2.Location = new System.Drawing.Point(406, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "VALOR UNITÁRIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label3.Location = new System.Drawing.Point(512, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "TOTAL A PAGAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label4.Location = new System.Drawing.Point(406, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "VALOR TOTAL";
            // 
            // textBoxValorTotal
            // 
            this.textBoxValorTotal.Enabled = false;
            this.textBoxValorTotal.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.textBoxValorTotal.Location = new System.Drawing.Point(409, 228);
            this.textBoxValorTotal.Name = "textBoxValorTotal";
            this.textBoxValorTotal.Size = new System.Drawing.Size(299, 32);
            this.textBoxValorTotal.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label5.Location = new System.Drawing.Point(406, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "PRODUTO";
            // 
            // caixaTitle
            // 
            this.caixaTitle.AutoSize = true;
            this.caixaTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.caixaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.caixaTitle.ForeColor = System.Drawing.Color.White;
            this.caixaTitle.Location = new System.Drawing.Point(12, 9);
            this.caixaTitle.Name = "caixaTitle";
            this.caixaTitle.Size = new System.Drawing.Size(74, 25);
            this.caixaTitle.TabIndex = 22;
            this.caixaTitle.Text = "CAIXA";
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.buttonFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.buttonFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinalizar.Location = new System.Drawing.Point(564, 395);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(144, 38);
            this.buttonFinalizar.TabIndex = 23;
            this.buttonFinalizar.UseVisualStyleBackColor = false;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(580, 406);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(606, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "FINALIZAR";
            // 
            // CancelarBtnIcon
            // 
            this.CancelarBtnIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.CancelarBtnIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarBtnIcon.Image = ((System.Drawing.Image)(resources.GetObject("CancelarBtnIcon.Image")));
            this.CancelarBtnIcon.Location = new System.Drawing.Point(423, 406);
            this.CancelarBtnIcon.Name = "CancelarBtnIcon";
            this.CancelarBtnIcon.Size = new System.Drawing.Size(20, 20);
            this.CancelarBtnIcon.TabIndex = 37;
            this.CancelarBtnIcon.TabStop = false;
            // 
            // labelbtnCancelar
            // 
            this.labelbtnCancelar.AutoSize = true;
            this.labelbtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.labelbtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelbtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelbtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelbtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(22)))), ((int)(((byte)(47)))));
            this.labelbtnCancelar.Location = new System.Drawing.Point(450, 406);
            this.labelbtnCancelar.Name = "labelbtnCancelar";
            this.labelbtnCancelar.Size = new System.Drawing.Size(78, 15);
            this.labelbtnCancelar.TabIndex = 36;
            this.labelbtnCancelar.Text = "CANCELAR";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.buttonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.buttonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(22)))), ((int)(((byte)(47)))));
            this.buttonCancelar.Location = new System.Drawing.Point(409, 395);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(144, 38);
            this.buttonCancelar.TabIndex = 35;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // comboBoxProdutoInformation
            // 
            this.comboBoxProdutoInformation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProdutoInformation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProdutoInformation.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.comboBoxProdutoInformation.FormattingEnabled = true;
            this.comboBoxProdutoInformation.Location = new System.Drawing.Point(409, 67);
            this.comboBoxProdutoInformation.Name = "comboBoxProdutoInformation";
            this.comboBoxProdutoInformation.Size = new System.Drawing.Size(299, 31);
            this.comboBoxProdutoInformation.TabIndex = 38;
            this.comboBoxProdutoInformation.SelectedIndexChanged += new System.EventHandler(this.comboBoxProdutoInformation_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonNovoItem);
            this.panel1.Controls.Add(this.buttonGravarItem);
            this.panel1.Controls.Add(this.buttonExcluirItem);
            this.panel1.Controls.Add(this.buttonVisualizarItem);
            this.panel1.Location = new System.Drawing.Point(12, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 27);
            this.panel1.TabIndex = 39;
            // 
            // buttonNovoItem
            // 
            this.buttonNovoItem.Location = new System.Drawing.Point(9, 2);
            this.buttonNovoItem.Name = "buttonNovoItem";
            this.buttonNovoItem.Size = new System.Drawing.Size(75, 23);
            this.buttonNovoItem.TabIndex = 46;
            this.buttonNovoItem.Text = "Novo Item";
            this.buttonNovoItem.UseVisualStyleBackColor = true;
            this.buttonNovoItem.Click += new System.EventHandler(this.buttonNovoItem_Click);
            // 
            // buttonGravarItem
            // 
            this.buttonGravarItem.Location = new System.Drawing.Point(99, 2);
            this.buttonGravarItem.Name = "buttonGravarItem";
            this.buttonGravarItem.Size = new System.Drawing.Size(75, 23);
            this.buttonGravarItem.TabIndex = 43;
            this.buttonGravarItem.Text = "Gravar Item";
            this.buttonGravarItem.UseVisualStyleBackColor = true;
            this.buttonGravarItem.Click += new System.EventHandler(this.buttonGravarItem_Click);
            // 
            // buttonExcluirItem
            // 
            this.buttonExcluirItem.Location = new System.Drawing.Point(190, 2);
            this.buttonExcluirItem.Name = "buttonExcluirItem";
            this.buttonExcluirItem.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirItem.TabIndex = 45;
            this.buttonExcluirItem.Text = "Excluir Item";
            this.buttonExcluirItem.UseVisualStyleBackColor = true;
            this.buttonExcluirItem.Click += new System.EventHandler(this.buttonExcluirItem_Click);
            // 
            // buttonVisualizarItem
            // 
            this.buttonVisualizarItem.Location = new System.Drawing.Point(280, 2);
            this.buttonVisualizarItem.Name = "buttonVisualizarItem";
            this.buttonVisualizarItem.Size = new System.Drawing.Size(92, 23);
            this.buttonVisualizarItem.TabIndex = 44;
            this.buttonVisualizarItem.Text = "Visualizar Item";
            this.buttonVisualizarItem.UseVisualStyleBackColor = true;
            this.buttonVisualizarItem.Click += new System.EventHandler(this.buttonVisualizarItem_Click);
            // 
            // dgvItemVenda
            // 
            this.dgvItemVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemVenda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvItemVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItemVenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvItemVenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRODUTO,
            this.PRODUTO,
            this.VALOR_UNITARIO,
            this.QUANTIDADE_UNITARIO,
            this.VALOR_TOTAL_UNITARIO});
            this.dgvItemVenda.GridColor = System.Drawing.Color.White;
            this.dgvItemVenda.Location = new System.Drawing.Point(12, 48);
            this.dgvItemVenda.MultiSelect = false;
            this.dgvItemVenda.Name = "dgvItemVenda";
            this.dgvItemVenda.ReadOnly = true;
            this.dgvItemVenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItemVenda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvItemVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemVenda.Size = new System.Drawing.Size(380, 352);
            this.dgvItemVenda.TabIndex = 40;
            // 
            // IDPRODUTO
            // 
            this.IDPRODUTO.HeaderText = "IDPRODUTO";
            this.IDPRODUTO.Name = "IDPRODUTO";
            this.IDPRODUTO.ReadOnly = true;
            this.IDPRODUTO.Visible = false;
            this.IDPRODUTO.Width = 97;
            // 
            // PRODUTO
            // 
            this.PRODUTO.HeaderText = "PRODUTO";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.ReadOnly = true;
            this.PRODUTO.Width = 86;
            // 
            // VALOR_UNITARIO
            // 
            this.VALOR_UNITARIO.HeaderText = "VALOR_UNITARIO";
            this.VALOR_UNITARIO.Name = "VALOR_UNITARIO";
            this.VALOR_UNITARIO.ReadOnly = true;
            this.VALOR_UNITARIO.Width = 126;
            // 
            // QUANTIDADE_UNITARIO
            // 
            this.QUANTIDADE_UNITARIO.HeaderText = "QUANTIDADE_UNITARIO";
            this.QUANTIDADE_UNITARIO.Name = "QUANTIDADE_UNITARIO";
            this.QUANTIDADE_UNITARIO.ReadOnly = true;
            this.QUANTIDADE_UNITARIO.Width = 161;
            // 
            // VALOR_TOTAL_UNITARIO
            // 
            this.VALOR_TOTAL_UNITARIO.HeaderText = "VALOR_TOTAL_UNITARIO";
            this.VALOR_TOTAL_UNITARIO.Name = "VALOR_TOTAL_UNITARIO";
            this.VALOR_TOTAL_UNITARIO.ReadOnly = true;
            this.VALOR_TOTAL_UNITARIO.Width = 167;
            // 
            // FormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 445);
            this.Controls.Add(this.dgvItemVenda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxProdutoInformation);
            this.Controls.Add(this.CancelarBtnIcon);
            this.Controls.Add(this.labelbtnCancelar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.caixaTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxValorTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxTotalPagar);
            this.Controls.Add(this.PanelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAIXA";
            this.Load += new System.EventHandler(this.FormCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelarBtnIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PanelBackground;
        private System.Windows.Forms.TextBox textBoxTotalPagar;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxValorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label caixaTitle;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox CancelarBtnIcon;
        private System.Windows.Forms.Label labelbtnCancelar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ComboBox comboBoxProdutoInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNovoItem;
        private System.Windows.Forms.Button buttonGravarItem;
        private System.Windows.Forms.Button buttonExcluirItem;
        private System.Windows.Forms.Button buttonVisualizarItem;
        private System.Windows.Forms.DataGridView dgvItemVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE_UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_TOTAL_UNITARIO;
    }
}