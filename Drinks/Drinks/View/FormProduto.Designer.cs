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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.PanelBackground.Size = new System.Drawing.Size(720, 47);
            this.PanelBackground.TabIndex = 2;
            this.PanelBackground.TabStop = false;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(90, 124);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(47, 17);
            this.labelMarca.TabIndex = 30;
            this.labelMarca.Text = "Marca";
            // 
            // labelUnidadeMedida
            // 
            this.labelUnidadeMedida.AutoSize = true;
            this.labelUnidadeMedida.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnidadeMedida.Location = new System.Drawing.Point(264, 124);
            this.labelUnidadeMedida.Name = "labelUnidadeMedida";
            this.labelUnidadeMedida.Size = new System.Drawing.Size(105, 17);
            this.labelUnidadeMedida.TabIndex = 29;
            this.labelUnidadeMedida.Text = "Unidade Medida";
            // 
            // labelTamanho
            // 
            this.labelTamanho.AutoSize = true;
            this.labelTamanho.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamanho.Location = new System.Drawing.Point(469, 124);
            this.labelTamanho.Name = "labelTamanho";
            this.labelTamanho.Size = new System.Drawing.Size(62, 17);
            this.labelTamanho.TabIndex = 28;
            this.labelTamanho.Text = "Tamanho";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(90, 64);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 17);
            this.labelID.TabIndex = 27;
            this.labelID.Text = "ID";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(230, 64);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(68, 17);
            this.labelDescricao.TabIndex = 26;
            this.labelDescricao.Text = "Descrição";
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(520, 206);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(115, 35);
            this.buttonSair.TabIndex = 25;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(233, 206);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(115, 35);
            this.buttonSalvar.TabIndex = 23;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovo.Location = new System.Drawing.Point(93, 206);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(115, 35);
            this.buttonNovo.TabIndex = 22;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // comboBoxTamanho
            // 
            this.comboBoxTamanho.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTamanho.FormattingEnabled = true;
            this.comboBoxTamanho.Location = new System.Drawing.Point(472, 144);
            this.comboBoxTamanho.Name = "comboBoxTamanho";
            this.comboBoxTamanho.Size = new System.Drawing.Size(129, 25);
            this.comboBoxTamanho.TabIndex = 21;
            // 
            // comboBoxUnidadeMedida
            // 
            this.comboBoxUnidadeMedida.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUnidadeMedida.FormattingEnabled = true;
            this.comboBoxUnidadeMedida.Location = new System.Drawing.Point(267, 144);
            this.comboBoxUnidadeMedida.Name = "comboBoxUnidadeMedida";
            this.comboBoxUnidadeMedida.Size = new System.Drawing.Size(158, 25);
            this.comboBoxUnidadeMedida.TabIndex = 20;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(93, 144);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(132, 25);
            this.comboBoxMarca.TabIndex = 19;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDescricao.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescricao.Location = new System.Drawing.Point(233, 84);
            this.textBoxDescricao.MaxLength = 60;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(256, 25);
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
            this.textBoxValorUnitario.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorUnitario.Location = new System.Drawing.Point(515, 84);
            this.textBoxValorUnitario.Name = "textBoxValorUnitario";
            this.textBoxValorUnitario.Size = new System.Drawing.Size(120, 25);
            this.textBoxValorUnitario.TabIndex = 31;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(512, 64);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(39, 17);
            this.labelValor.TabIndex = 32;
            this.labelValor.Text = "Valor";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Location = new System.Drawing.Point(376, 206);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(115, 35);
            this.buttonExcluir.TabIndex = 34;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 445);
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
    }
}