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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompra));
            this.PanelBackground = new System.Windows.Forms.PictureBox();
            this.panelItemCompra = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
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
            this.compraTitle = new System.Windows.Forms.Label();
            this.labelbtnCancelar = new System.Windows.Forms.Label();
            this.CancelarBtnIcon = new System.Windows.Forms.PictureBox();
            this.btnNovo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImprimir = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBackground)).BeginInit();
            this.panelItemCompra.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelarBtnIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.panelItemCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10F);
            this.label3.Location = new System.Drawing.Point(312, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10F);
            this.label5.Location = new System.Drawing.Point(163, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10F);
            this.label4.Location = new System.Drawing.Point(13, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Unitario";
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Font = new System.Drawing.Font("Roboto", 10.25F);
            this.labelProduto.Location = new System.Drawing.Point(10, 5);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(59, 17);
            this.labelProduto.TabIndex = 6;
            this.labelProduto.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(139, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
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
            this.textBoxQuantidade.Font = new System.Drawing.Font("Roboto Medium", 11.25F);
            this.textBoxQuantidade.Location = new System.Drawing.Point(162, 78);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(123, 26);
            this.textBoxQuantidade.TabIndex = 2;
            this.textBoxQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxQuantidade.TextChanged += new System.EventHandler(this.textBoxQuantidade_TextChanged);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Font = new System.Drawing.Font("Roboto Medium", 11.25F);
            this.textBoxValor.Location = new System.Drawing.Point(13, 78);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(123, 26);
            this.textBoxValor.TabIndex = 1;
            this.textBoxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxValor.TextChanged += new System.EventHandler(this.textBoxValor_TextChanged);
            // 
            // comboBoxProdutoInformation
            // 
            this.comboBoxProdutoInformation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProdutoInformation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProdutoInformation.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProdutoInformation.FormattingEnabled = true;
            this.comboBoxProdutoInformation.Location = new System.Drawing.Point(13, 24);
            this.comboBoxProdutoInformation.Name = "comboBoxProdutoInformation";
            this.comboBoxProdutoInformation.Size = new System.Drawing.Size(519, 26);
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
            this.buttonFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.buttonFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.buttonFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinalizar.Location = new System.Drawing.Point(569, 367);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(139, 37);
            this.buttonFinalizar.TabIndex = 11;
            this.buttonFinalizar.UseVisualStyleBackColor = false;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(127)))));
            this.buttonSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSair.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Location = new System.Drawing.Point(569, 315);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(139, 37);
            this.buttonSair.TabIndex = 13;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.buttonImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Location = new System.Drawing.Point(569, 97);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(139, 37);
            this.buttonImprimir.TabIndex = 14;
            this.buttonImprimir.UseVisualStyleBackColor = false;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.buttonNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNovo.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.buttonNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.buttonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovo.Location = new System.Drawing.Point(569, 48);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(139, 37);
            this.buttonNovo.TabIndex = 15;
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.buttonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.buttonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(22)))), ((int)(((byte)(47)))));
            this.buttonCancelar.Location = new System.Drawing.Point(569, 263);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(139, 37);
            this.buttonCancelar.TabIndex = 16;
            this.buttonCancelar.UseVisualStyleBackColor = false;
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
            // compraTitle
            // 
            this.compraTitle.AutoSize = true;
            this.compraTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.compraTitle.Font = new System.Drawing.Font("Roboto Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.compraTitle.ForeColor = System.Drawing.Color.White;
            this.compraTitle.Location = new System.Drawing.Point(12, 9);
            this.compraTitle.Name = "compraTitle";
            this.compraTitle.Size = new System.Drawing.Size(103, 24);
            this.compraTitle.TabIndex = 21;
            this.compraTitle.Text = "COMPRAS";
            // 
            // labelbtnCancelar
            // 
            this.labelbtnCancelar.AutoSize = true;
            this.labelbtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.labelbtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelbtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelbtnCancelar.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelbtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(22)))), ((int)(((byte)(47)))));
            this.labelbtnCancelar.Location = new System.Drawing.Point(620, 275);
            this.labelbtnCancelar.Name = "labelbtnCancelar";
            this.labelbtnCancelar.Size = new System.Drawing.Size(69, 14);
            this.labelbtnCancelar.TabIndex = 22;
            this.labelbtnCancelar.Text = "CANCELAR";
            // 
            // CancelarBtnIcon
            // 
            this.CancelarBtnIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.CancelarBtnIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarBtnIcon.Image = ((System.Drawing.Image)(resources.GetObject("CancelarBtnIcon.Image")));
            this.CancelarBtnIcon.Location = new System.Drawing.Point(587, 273);
            this.CancelarBtnIcon.Name = "CancelarBtnIcon";
            this.CancelarBtnIcon.Size = new System.Drawing.Size(18, 17);
            this.CancelarBtnIcon.TabIndex = 23;
            this.CancelarBtnIcon.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(180)))), ((int)(((byte)(134)))));
            this.btnNovo.Location = new System.Drawing.Point(620, 60);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(39, 14);
            this.btnNovo.TabIndex = 24;
            this.btnNovo.Text = "NOVO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(587, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 17);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(83)))), ((int)(((byte)(190)))));
            this.btnImprimir.Location = new System.Drawing.Point(620, 110);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(65, 14);
            this.btnImprimir.TabIndex = 26;
            this.btnImprimir.Text = "IMPRIMIR";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(585, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(127)))));
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(624, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 14);
            this.label6.TabIndex = 28;
            this.label6.Text = "SAIR";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(127)))));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(584, 325);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 20);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(623, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 14);
            this.label7.TabIndex = 30;
            this.label7.Text = "FINALIZAR";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(587, 378);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 20);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 445);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.CancelarBtnIcon);
            this.Controls.Add(this.labelbtnCancelar);
            this.Controls.Add(this.compraTitle);
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
            ((System.ComponentModel.ISupportInitialize)(this.CancelarBtnIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label compraTitle;
        private System.Windows.Forms.Label labelbtnCancelar;
        private System.Windows.Forms.PictureBox CancelarBtnIcon;
        private System.Windows.Forms.Label btnNovo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label btnImprimir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}