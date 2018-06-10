namespace Drinks.View
{
    partial class FormProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduto));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.PanelBackground = new System.Windows.Forms.PictureBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelUnidadeMedida = new System.Windows.Forms.Label();
            this.labelTamanho = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.comboBoxTamanho = new System.Windows.Forms.ComboBox();
            this.comboBoxUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxValorUnitario = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.produtoTitle = new System.Windows.Forms.Label();
            this.pictureBoxUnidadeMedida = new System.Windows.Forms.PictureBox();
            this.pictureBoxTamanho = new System.Windows.Forms.PictureBox();
            this.pictureBoxMarca = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnidadeMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProdutos.GridColor = System.Drawing.Color.White;
            this.dgvProdutos.Location = new System.Drawing.Point(0, 267);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(720, 178);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProdutos_CellMouseDoubleClick);
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(720, 42);
            this.PanelBackground.TabIndex = 2;
            this.PanelBackground.TabStop = false;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(90, 124);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(50, 18);
            this.labelMarca.TabIndex = 30;
            this.labelMarca.Text = "Marca";
            // 
            // labelUnidadeMedida
            // 
            this.labelUnidadeMedida.AutoSize = true;
            this.labelUnidadeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnidadeMedida.Location = new System.Drawing.Point(441, 124);
            this.labelUnidadeMedida.Name = "labelUnidadeMedida";
            this.labelUnidadeMedida.Size = new System.Drawing.Size(114, 18);
            this.labelUnidadeMedida.TabIndex = 29;
            this.labelUnidadeMedida.Text = "Unidade Medida";
            // 
            // labelTamanho
            // 
            this.labelTamanho.AutoSize = true;
            this.labelTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamanho.Location = new System.Drawing.Point(291, 124);
            this.labelTamanho.Name = "labelTamanho";
            this.labelTamanho.Size = new System.Drawing.Size(71, 18);
            this.labelTamanho.TabIndex = 28;
            this.labelTamanho.Text = "Tamanho";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelID.Location = new System.Drawing.Point(90, 63);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 18);
            this.labelID.TabIndex = 27;
            this.labelID.Text = "ID";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(186, 63);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(76, 18);
            this.labelDescricao.TabIndex = 26;
            this.labelDescricao.Text = "Descrição";
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSair.ForeColor = System.Drawing.Color.Red;
            this.buttonSair.Location = new System.Drawing.Point(520, 206);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(115, 35);
            this.buttonSair.TabIndex = 25;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSalvar.ForeColor = System.Drawing.Color.White;
            this.buttonSalvar.Location = new System.Drawing.Point(233, 206);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(115, 35);
            this.buttonSalvar.TabIndex = 23;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNovo.ForeColor = System.Drawing.Color.White;
            this.buttonNovo.Location = new System.Drawing.Point(93, 206);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(115, 35);
            this.buttonNovo.TabIndex = 22;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // comboBoxTamanho
            // 
            this.comboBoxTamanho.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTamanho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTamanho.FormattingEnabled = true;
            this.comboBoxTamanho.Location = new System.Drawing.Point(294, 145);
            this.comboBoxTamanho.Name = "comboBoxTamanho";
            this.comboBoxTamanho.Size = new System.Drawing.Size(111, 26);
            this.comboBoxTamanho.TabIndex = 21;
            // 
            // comboBoxUnidadeMedida
            // 
            this.comboBoxUnidadeMedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUnidadeMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUnidadeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUnidadeMedida.FormattingEnabled = true;
            this.comboBoxUnidadeMedida.Location = new System.Drawing.Point(444, 145);
            this.comboBoxUnidadeMedida.Name = "comboBoxUnidadeMedida";
            this.comboBoxUnidadeMedida.Size = new System.Drawing.Size(158, 26);
            this.comboBoxUnidadeMedida.TabIndex = 20;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(93, 144);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(162, 26);
            this.comboBoxMarca.TabIndex = 19;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescricao.Location = new System.Drawing.Point(189, 84);
            this.textBoxDescricao.MaxLength = 60;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(320, 24);
            this.textBoxDescricao.TabIndex = 18;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(93, 84);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(90, 25);
            this.textBoxID.TabIndex = 17;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxValorUnitario
            // 
            this.textBoxValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorUnitario.Location = new System.Drawing.Point(515, 84);
            this.textBoxValorUnitario.Name = "textBoxValorUnitario";
            this.textBoxValorUnitario.Size = new System.Drawing.Size(120, 24);
            this.textBoxValorUnitario.TabIndex = 31;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(512, 63);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(42, 18);
            this.labelValor.TabIndex = 32;
            this.labelValor.Text = "Valor";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.Crimson;
            this.buttonExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonExcluir.ForeColor = System.Drawing.Color.White;
            this.buttonExcluir.Location = new System.Drawing.Point(376, 206);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(115, 35);
            this.buttonExcluir.TabIndex = 34;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // produtoTitle
            // 
            this.produtoTitle.AutoSize = true;
            this.produtoTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.produtoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.produtoTitle.ForeColor = System.Drawing.Color.White;
            this.produtoTitle.Location = new System.Drawing.Point(12, 9);
            this.produtoTitle.Name = "produtoTitle";
            this.produtoTitle.Size = new System.Drawing.Size(111, 25);
            this.produtoTitle.TabIndex = 35;
            this.produtoTitle.Text = "PRODUTO";
            // 
            // pictureBoxUnidadeMedida
            // 
            this.pictureBoxUnidadeMedida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnidadeMedida.BackgroundImage")));
            this.pictureBoxUnidadeMedida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxUnidadeMedida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxUnidadeMedida.Location = new System.Drawing.Point(608, 144);
            this.pictureBoxUnidadeMedida.Name = "pictureBoxUnidadeMedida";
            this.pictureBoxUnidadeMedida.Size = new System.Drawing.Size(27, 26);
            this.pictureBoxUnidadeMedida.TabIndex = 36;
            this.pictureBoxUnidadeMedida.TabStop = false;
            this.pictureBoxUnidadeMedida.Click += new System.EventHandler(this.pictureBoxUnidadeMedida_Click);
            // 
            // pictureBoxTamanho
            // 
            this.pictureBoxTamanho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTamanho.BackgroundImage")));
            this.pictureBoxTamanho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxTamanho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTamanho.Location = new System.Drawing.Point(411, 145);
            this.pictureBoxTamanho.Name = "pictureBoxTamanho";
            this.pictureBoxTamanho.Size = new System.Drawing.Size(27, 26);
            this.pictureBoxTamanho.TabIndex = 37;
            this.pictureBoxTamanho.TabStop = false;
            this.pictureBoxTamanho.Click += new System.EventHandler(this.pictureBoxTamanho_Click);
            // 
            // pictureBoxMarca
            // 
            this.pictureBoxMarca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMarca.BackgroundImage")));
            this.pictureBoxMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMarca.Location = new System.Drawing.Point(261, 144);
            this.pictureBoxMarca.Name = "pictureBoxMarca";
            this.pictureBoxMarca.Size = new System.Drawing.Size(27, 26);
            this.pictureBoxMarca.TabIndex = 38;
            this.pictureBoxMarca.TabStop = false;
            this.pictureBoxMarca.Click += new System.EventHandler(this.pictureBoxMarca_Click);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 445);
            this.Controls.Add(this.pictureBoxMarca);
            this.Controls.Add(this.pictureBoxTamanho);
            this.Controls.Add(this.pictureBoxUnidadeMedida);
            this.Controls.Add(this.produtoTitle);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.textBoxValorUnitario);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelUnidadeMedida);
            this.Controls.Add(this.labelTamanho);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.comboBoxTamanho);
            this.Controls.Add(this.comboBoxUnidadeMedida);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.PanelBackground);
            this.Controls.Add(this.dgvProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUTOS";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnidadeMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.PictureBox PanelBackground;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelUnidadeMedida;
        private System.Windows.Forms.Label labelTamanho;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.ComboBox comboBoxTamanho;
        private System.Windows.Forms.ComboBox comboBoxUnidadeMedida;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxValorUnitario;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Label produtoTitle;
        private System.Windows.Forms.PictureBox pictureBoxUnidadeMedida;
        private System.Windows.Forms.PictureBox pictureBoxTamanho;
        private System.Windows.Forms.PictureBox pictureBoxMarca;
    }
}