namespace Drinks.View
{
    partial class FormCompra
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
            this.PanelBackground = new System.Windows.Forms.PictureBox();
            this.panelItemCompra = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelProduto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxValorTotal = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.comboBoxProdutoInformation = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvItemPedido = new System.Windows.Forms.DataGridView();
            this.IDPRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_TOTAL_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonVisualizarItem = new System.Windows.Forms.Button();
            this.buttonExcluirItem = new System.Windows.Forms.Button();
            this.buttonGravarItem = new System.Windows.Forms.Button();
            this.buttonNovoItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBackground)).BeginInit();
            this.panelItemCompra.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(720, 42);
            this.PanelBackground.TabIndex = 8;
            this.PanelBackground.TabStop = false;
            // 
            // panelItemCompra
            // 
            this.panelItemCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelItemCompra.Controls.Add(this.label3);
            this.panelItemCompra.Controls.Add(this.label5);
            this.panelItemCompra.Controls.Add(this.label4);
            this.panelItemCompra.Controls.Add(this.labelProduto);
            this.panelItemCompra.Controls.Add(this.label2);
            this.panelItemCompra.Controls.Add(this.label1);
            this.panelItemCompra.Controls.Add(this.textBoxValorTotal);
            this.panelItemCompra.Controls.Add(this.textBoxQuantidade);
            this.panelItemCompra.Controls.Add(this.textBoxValor);
            this.panelItemCompra.Controls.Add(this.comboBoxProdutoInformation);
            this.panelItemCompra.Location = new System.Drawing.Point(12, 48);
            this.panelItemCompra.Name = "panelItemCompra";
            this.panelItemCompra.Size = new System.Drawing.Size(551, 121);
            this.panelItemCompra.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label5.Location = new System.Drawing.Point(159, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label4.Location = new System.Drawing.Point(10, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Unitario";
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.labelProduto.Location = new System.Drawing.Point(10, 5);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(54, 17);
            this.labelProduto.TabIndex = 6;
            this.labelProduto.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label2.Location = new System.Drawing.Point(142, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.Location = new System.Drawing.Point(291, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // textBoxValorTotal
            // 
            this.textBoxValorTotal.Enabled = false;
            this.textBoxValorTotal.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.textBoxValorTotal.Location = new System.Drawing.Point(313, 78);
            this.textBoxValorTotal.Name = "textBoxValorTotal";
            this.textBoxValorTotal.Size = new System.Drawing.Size(123, 25);
            this.textBoxValorTotal.TabIndex = 1000;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.textBoxQuantidade.Location = new System.Drawing.Point(162, 78);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(123, 25);
            this.textBoxQuantidade.TabIndex = 2;
            this.textBoxQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.textBoxValor.Location = new System.Drawing.Point(13, 78);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(123, 25);
            this.textBoxValor.TabIndex = 1;
            this.textBoxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxProdutoInformation
            // 
            this.comboBoxProdutoInformation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProdutoInformation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProdutoInformation.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.comboBoxProdutoInformation.FormattingEnabled = true;
            this.comboBoxProdutoInformation.Location = new System.Drawing.Point(13, 24);
            this.comboBoxProdutoInformation.Name = "comboBoxProdutoInformation";
            this.comboBoxProdutoInformation.Size = new System.Drawing.Size(519, 25);
            this.comboBoxProdutoInformation.TabIndex = 0;
            this.comboBoxProdutoInformation.SelectedIndexChanged += new System.EventHandler(this.comboBoxProdutoInformation_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvItemPedido);
            this.panel2.Location = new System.Drawing.Point(12, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 229);
            this.panel2.TabIndex = 10;
            // 
            // dgvItemPedido
            // 
            this.dgvItemPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvItemPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItemPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvItemPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItemPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRODUTO,
            this.PRODUTO,
            this.VALOR_UNITARIO,
            this.QUANTIDADE_UNITARIO,
            this.VALOR_TOTAL_UNITARIO});
            this.dgvItemPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemPedido.GridColor = System.Drawing.Color.White;
            this.dgvItemPedido.Location = new System.Drawing.Point(0, 0);
            this.dgvItemPedido.MultiSelect = false;
            this.dgvItemPedido.Name = "dgvItemPedido";
            this.dgvItemPedido.ReadOnly = true;
            this.dgvItemPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItemPedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvItemPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemPedido.Size = new System.Drawing.Size(551, 229);
            this.dgvItemPedido.TabIndex = 1;
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
            // buttonFinalizar
            // 
            this.buttonFinalizar.Location = new System.Drawing.Point(569, 367);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(139, 37);
            this.buttonFinalizar.TabIndex = 11;
            this.buttonFinalizar.Text = "Finalizar";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(569, 315);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(139, 37);
            this.buttonSair.TabIndex = 13;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(569, 97);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(139, 37);
            this.buttonImprimir.TabIndex = 14;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(569, 48);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(139, 37);
            this.buttonNovo.TabIndex = 15;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(569, 263);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(139, 37);
            this.buttonCancelar.TabIndex = 16;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonVisualizarItem
            // 
            this.buttonVisualizarItem.Location = new System.Drawing.Point(471, 410);
            this.buttonVisualizarItem.Name = "buttonVisualizarItem";
            this.buttonVisualizarItem.Size = new System.Drawing.Size(92, 23);
            this.buttonVisualizarItem.TabIndex = 17;
            this.buttonVisualizarItem.Text = "Visualizar Item";
            this.buttonVisualizarItem.UseVisualStyleBackColor = true;
            this.buttonVisualizarItem.Click += new System.EventHandler(this.buttonVisualizarItem_Click);
            // 
            // buttonExcluirItem
            // 
            this.buttonExcluirItem.Location = new System.Drawing.Point(381, 410);
            this.buttonExcluirItem.Name = "buttonExcluirItem";
            this.buttonExcluirItem.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirItem.TabIndex = 18;
            this.buttonExcluirItem.Text = "Excluir Item";
            this.buttonExcluirItem.UseVisualStyleBackColor = true;
            this.buttonExcluirItem.Click += new System.EventHandler(this.buttonExcluirItem_Click);
            // 
            // buttonGravarItem
            // 
            this.buttonGravarItem.Location = new System.Drawing.Point(290, 410);
            this.buttonGravarItem.Name = "buttonGravarItem";
            this.buttonGravarItem.Size = new System.Drawing.Size(75, 23);
            this.buttonGravarItem.TabIndex = 4;
            this.buttonGravarItem.Text = "Gravar Item";
            this.buttonGravarItem.UseVisualStyleBackColor = true;
            this.buttonGravarItem.Click += new System.EventHandler(this.buttonGravarItem_Click);
            // 
            // buttonNovoItem
            // 
            this.buttonNovoItem.Location = new System.Drawing.Point(200, 410);
            this.buttonNovoItem.Name = "buttonNovoItem";
            this.buttonNovoItem.Size = new System.Drawing.Size(75, 23);
            this.buttonNovoItem.TabIndex = 20;
            this.buttonNovoItem.Text = "Novo Item";
            this.buttonNovoItem.UseVisualStyleBackColor = true;
            this.buttonNovoItem.Click += new System.EventHandler(this.buttonNovoItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label3.Location = new System.Drawing.Point(310, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor Total";
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 445);
            this.Controls.Add(this.buttonNovoItem);
            this.Controls.Add(this.buttonGravarItem);
            this.Controls.Add(this.buttonExcluirItem);
            this.Controls.Add(this.buttonVisualizarItem);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelItemCompra);
            this.Controls.Add(this.PanelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPRAS";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelBackground)).EndInit();
            this.panelItemCompra.ResumeLayout(false);
            this.panelItemCompra.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PanelBackground;
        private System.Windows.Forms.Panel panelItemCompra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.ComboBox comboBoxProdutoInformation;
        private System.Windows.Forms.Button buttonVisualizarItem;
        private System.Windows.Forms.Button buttonExcluirItem;
        private System.Windows.Forms.Button buttonGravarItem;
        private System.Windows.Forms.Button buttonNovoItem;
        private System.Windows.Forms.DataGridView dgvItemPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxValorTotal;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE_UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_TOTAL_UNITARIO;
        private System.Windows.Forms.Label label3;
    }
}