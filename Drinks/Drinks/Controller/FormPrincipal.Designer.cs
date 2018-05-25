namespace Drinks.Controller
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.closeForm = new System.Windows.Forms.Button();
            this.PanelBackground = new System.Windows.Forms.PictureBox();
            this.FormMinimize = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCompras = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabVendas = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabEstoque = new System.Windows.Forms.TabPage();
            this.FormLogo = new System.Windows.Forms.PictureBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelUnidadeMedida = new System.Windows.Forms.Label();
            this.labelTamanho = new System.Windows.Forms.Label();
            this.buttonNovoProduto = new System.Windows.Forms.Button();
            this.buttonSalvarProduto = new System.Windows.Forms.Button();
            this.buttonCancelarProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.comboBoxTamanho = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBuscarProduto = new System.Windows.Forms.Button();
            this.textBoxBuscaProduto = new System.Windows.Forms.TextBox();
            this.comboBoxModoBusca = new System.Windows.Forms.ComboBox();
            this.dgvProdutosCadastrados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBackground)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabCompras.SuspendLayout();
            this.tabVendas.SuspendLayout();
            this.tabEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // closeForm
            // 
            this.closeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.closeForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeForm.BackgroundImage")));
            this.closeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeForm.FlatAppearance.BorderSize = 0;
            this.closeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeForm.Location = new System.Drawing.Point(888, 12);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(24, 23);
            this.closeForm.TabIndex = 0;
            this.closeForm.Text = " ";
            this.closeForm.UseVisualStyleBackColor = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.PanelBackground.Location = new System.Drawing.Point(-1, -1);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(928, 47);
            this.PanelBackground.TabIndex = 1;
            this.PanelBackground.TabStop = false;
            // 
            // FormMinimize
            // 
            this.FormMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.FormMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FormMinimize.BackgroundImage")));
            this.FormMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FormMinimize.FlatAppearance.BorderSize = 0;
            this.FormMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormMinimize.Location = new System.Drawing.Point(858, 12);
            this.FormMinimize.Name = "FormMinimize";
            this.FormMinimize.Size = new System.Drawing.Size(24, 23);
            this.FormMinimize.TabIndex = 2;
            this.FormMinimize.Text = " ";
            this.FormMinimize.UseVisualStyleBackColor = false;
            this.FormMinimize.Click += new System.EventHandler(this.FormMinimize_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCompras);
            this.tabControl1.Controls.Add(this.tabVendas);
            this.tabControl1.Controls.Add(this.tabEstoque);
            this.tabControl1.Location = new System.Drawing.Point(12, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 503);
            this.tabControl1.TabIndex = 3;
            // 
            // tabCompras
            // 
            this.tabCompras.Controls.Add(this.button3);
            this.tabCompras.Controls.Add(this.comboBox2);
            this.tabCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabCompras.Location = new System.Drawing.Point(4, 22);
            this.tabCompras.Name = "tabCompras";
            this.tabCompras.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompras.Size = new System.Drawing.Size(476, 477);
            this.tabCompras.TabIndex = 0;
            this.tabCompras.Text = "COMPRAS";
            this.tabCompras.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Consultar Produtos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Marca",
            "Unidade de Medida",
            "Tamanho"});
            this.comboBox2.Location = new System.Drawing.Point(8, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // tabVendas
            // 
            this.tabVendas.Controls.Add(this.button2);
            this.tabVendas.Controls.Add(this.comboBox1);
            this.tabVendas.Location = new System.Drawing.Point(4, 22);
            this.tabVendas.Name = "tabVendas";
            this.tabVendas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVendas.Size = new System.Drawing.Size(476, 477);
            this.tabVendas.TabIndex = 1;
            this.tabVendas.Text = "VENDAS";
            this.tabVendas.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Consultar Produtos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Marca",
            "Unidade de Medida",
            "Tamanho"});
            this.comboBox1.Location = new System.Drawing.Point(7, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // tabEstoque
            // 
            this.tabEstoque.Controls.Add(this.buttonBuscarProduto);
            this.tabEstoque.Controls.Add(this.panel1);
            this.tabEstoque.Controls.Add(this.textBoxBuscaProduto);
            this.tabEstoque.Controls.Add(this.dgvProdutosCadastrados);
            this.tabEstoque.Controls.Add(this.comboBoxModoBusca);
            this.tabEstoque.Controls.Add(this.label2);
            this.tabEstoque.Location = new System.Drawing.Point(4, 22);
            this.tabEstoque.Name = "tabEstoque";
            this.tabEstoque.Size = new System.Drawing.Size(892, 477);
            this.tabEstoque.TabIndex = 2;
            this.tabEstoque.Text = "ESTOQUE";
            this.tabEstoque.UseVisualStyleBackColor = true;
            // 
            // FormLogo
            // 
            this.FormLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.FormLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FormLogo.BackgroundImage")));
            this.FormLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FormLogo.Location = new System.Drawing.Point(16, 5);
            this.FormLogo.Name = "FormLogo";
            this.FormLogo.Size = new System.Drawing.Size(100, 39);
            this.FormLogo.TabIndex = 4;
            this.FormLogo.TabStop = false;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(151, 52);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(55, 13);
            this.labelDescricao.TabIndex = 5;
            this.labelDescricao.Text = "Descricao";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(154, 69);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(284, 20);
            this.textBoxDescricao.TabIndex = 6;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(28, 69);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(86, 20);
            this.textBoxID.TabIndex = 8;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(28, 52);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 7;
            this.labelID.Text = "ID";
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.buttonPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPesquisar.BackgroundImage")));
            this.buttonPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPesquisar.FlatAppearance.BorderSize = 0;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Location = new System.Drawing.Point(120, 68);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(31, 23);
            this.buttonPesquisar.TabIndex = 9;
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(25, 96);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 10;
            this.labelMarca.Text = "Marca";
            // 
            // labelUnidadeMedida
            // 
            this.labelUnidadeMedida.AutoSize = true;
            this.labelUnidadeMedida.Location = new System.Drawing.Point(151, 96);
            this.labelUnidadeMedida.Name = "labelUnidadeMedida";
            this.labelUnidadeMedida.Size = new System.Drawing.Size(84, 13);
            this.labelUnidadeMedida.TabIndex = 12;
            this.labelUnidadeMedida.Text = "Unidade medida";
            // 
            // labelTamanho
            // 
            this.labelTamanho.AutoSize = true;
            this.labelTamanho.Location = new System.Drawing.Point(286, 96);
            this.labelTamanho.Name = "labelTamanho";
            this.labelTamanho.Size = new System.Drawing.Size(52, 13);
            this.labelTamanho.TabIndex = 14;
            this.labelTamanho.Text = "Tamanho";
            // 
            // buttonNovoProduto
            // 
            this.buttonNovoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonNovoProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNovoProduto.FlatAppearance.BorderSize = 0;
            this.buttonNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovoProduto.Location = new System.Drawing.Point(31, 172);
            this.buttonNovoProduto.Name = "buttonNovoProduto";
            this.buttonNovoProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonNovoProduto.TabIndex = 16;
            this.buttonNovoProduto.Text = "NOVO";
            this.buttonNovoProduto.UseVisualStyleBackColor = false;
            // 
            // buttonSalvarProduto
            // 
            this.buttonSalvarProduto.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSalvarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvarProduto.FlatAppearance.BorderSize = 0;
            this.buttonSalvarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvarProduto.Location = new System.Drawing.Point(120, 172);
            this.buttonSalvarProduto.Name = "buttonSalvarProduto";
            this.buttonSalvarProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarProduto.TabIndex = 17;
            this.buttonSalvarProduto.Text = "SALVAR";
            this.buttonSalvarProduto.UseVisualStyleBackColor = false;
            // 
            // buttonCancelarProduto
            // 
            this.buttonCancelarProduto.BackColor = System.Drawing.Color.Red;
            this.buttonCancelarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelarProduto.FlatAppearance.BorderSize = 0;
            this.buttonCancelarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarProduto.Location = new System.Drawing.Point(208, 172);
            this.buttonCancelarProduto.Name = "buttonCancelarProduto";
            this.buttonCancelarProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarProduto.TabIndex = 18;
            this.buttonCancelarProduto.Text = "LIMPAR";
            this.buttonCancelarProduto.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "CADASTRAR PRODUTO";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(28, 113);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(86, 21);
            this.comboBoxMarca.TabIndex = 22;
            // 
            // comboBoxUnidadeMedida
            // 
            this.comboBoxUnidadeMedida.FormattingEnabled = true;
            this.comboBoxUnidadeMedida.Items.AddRange(new object[] {
            "Litro (L)",
            "Mililitro (mL)"});
            this.comboBoxUnidadeMedida.Location = new System.Drawing.Point(154, 113);
            this.comboBoxUnidadeMedida.Name = "comboBoxUnidadeMedida";
            this.comboBoxUnidadeMedida.Size = new System.Drawing.Size(129, 21);
            this.comboBoxUnidadeMedida.TabIndex = 23;
            // 
            // comboBoxTamanho
            // 
            this.comboBoxTamanho.FormattingEnabled = true;
            this.comboBoxTamanho.Location = new System.Drawing.Point(289, 113);
            this.comboBoxTamanho.Name = "comboBoxTamanho";
            this.comboBoxTamanho.Size = new System.Drawing.Size(147, 21);
            this.comboBoxTamanho.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxTamanho);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxUnidadeMedida);
            this.panel1.Controls.Add(this.labelDescricao);
            this.panel1.Controls.Add(this.comboBoxMarca);
            this.panel1.Controls.Add(this.textBoxDescricao);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.buttonCancelarProduto);
            this.panel1.Controls.Add(this.buttonPesquisar);
            this.panel1.Controls.Add(this.buttonSalvarProduto);
            this.panel1.Controls.Add(this.labelMarca);
            this.panel1.Controls.Add(this.buttonNovoProduto);
            this.panel1.Controls.Add(this.labelUnidadeMedida);
            this.panel1.Controls.Add(this.labelTamanho);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 471);
            this.panel1.TabIndex = 0;
            // 
            // buttonBuscarProduto
            // 
            this.buttonBuscarProduto.BackColor = System.Drawing.Color.Transparent;
            this.buttonBuscarProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBuscarProduto.BackgroundImage")));
            this.buttonBuscarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBuscarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarProduto.FlatAppearance.BorderSize = 0;
            this.buttonBuscarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarProduto.Location = new System.Drawing.Point(851, 43);
            this.buttonBuscarProduto.Name = "buttonBuscarProduto";
            this.buttonBuscarProduto.Size = new System.Drawing.Size(31, 30);
            this.buttonBuscarProduto.TabIndex = 35;
            this.buttonBuscarProduto.UseVisualStyleBackColor = false;
            // 
            // textBoxBuscaProduto
            // 
            this.textBoxBuscaProduto.Location = new System.Drawing.Point(604, 47);
            this.textBoxBuscaProduto.Name = "textBoxBuscaProduto";
            this.textBoxBuscaProduto.Size = new System.Drawing.Size(241, 20);
            this.textBoxBuscaProduto.TabIndex = 34;
            // 
            // comboBoxModoBusca
            // 
            this.comboBoxModoBusca.FormattingEnabled = true;
            this.comboBoxModoBusca.Location = new System.Drawing.Point(476, 46);
            this.comboBoxModoBusca.Name = "comboBoxModoBusca";
            this.comboBoxModoBusca.Size = new System.Drawing.Size(122, 21);
            this.comboBoxModoBusca.TabIndex = 33;
            // 
            // dgvProdutosCadastrados
            // 
            this.dgvProdutosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosCadastrados.Location = new System.Drawing.Point(476, 75);
            this.dgvProdutosCadastrados.Name = "dgvProdutosCadastrados";
            this.dgvProdutosCadastrados.Size = new System.Drawing.Size(413, 399);
            this.dgvProdutosCadastrados.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(587, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "PRODUTOS CADASTRADOS";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 567);
            this.Controls.Add(this.FormLogo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.FormMinimize);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.PanelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelBackground)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabCompras.ResumeLayout(false);
            this.tabVendas.ResumeLayout(false);
            this.tabEstoque.ResumeLayout(false);
            this.tabEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosCadastrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.PictureBox PanelBackground;
        private System.Windows.Forms.Button FormMinimize;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCompras;
        private System.Windows.Forms.TabPage tabVendas;
        private System.Windows.Forms.TabPage tabEstoque;
        private System.Windows.Forms.PictureBox FormLogo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelUnidadeMedida;
        private System.Windows.Forms.Label labelTamanho;
        private System.Windows.Forms.Button buttonNovoProduto;
        private System.Windows.Forms.Button buttonSalvarProduto;
        private System.Windows.Forms.Button buttonCancelarProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.ComboBox comboBoxUnidadeMedida;
        private System.Windows.Forms.ComboBox comboBoxTamanho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBuscarProduto;
        private System.Windows.Forms.TextBox textBoxBuscaProduto;
        private System.Windows.Forms.DataGridView dgvProdutosCadastrados;
        private System.Windows.Forms.ComboBox comboBoxModoBusca;
        private System.Windows.Forms.Label label2;
    }
}