namespace Drinks.View
{
    partial class FormConsultaProduto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.PanelBackground = new System.Windows.Forms.PictureBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonBuscarProduto = new System.Windows.Forms.Button();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.textBoxCampoBusca = new System.Windows.Forms.TextBox();
            this.consultaProdTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProdutos);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 368);
            this.panel1.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.GridColor = System.Drawing.Color.White;
            this.dgvProdutos.Location = new System.Drawing.Point(0, 0);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(639, 368);
            this.dgvProdutos.TabIndex = 1;
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(811, 42);
            this.PanelBackground.TabIndex = 7;
            this.PanelBackground.TabStop = false;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSair.ForeColor = System.Drawing.Color.Red;
            this.buttonSair.Location = new System.Drawing.Point(657, 382);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(142, 34);
            this.buttonSair.TabIndex = 8;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonBuscarProduto
            // 
            this.buttonBuscarProduto.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonBuscarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBuscarProduto.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarProduto.Location = new System.Drawing.Point(657, 132);
            this.buttonBuscarProduto.Name = "buttonBuscarProduto";
            this.buttonBuscarProduto.Size = new System.Drawing.Size(142, 34);
            this.buttonBuscarProduto.TabIndex = 9;
            this.buttonBuscarProduto.Text = "Buscar";
            this.buttonBuscarProduto.UseVisualStyleBackColor = false;
            this.buttonBuscarProduto.Click += new System.EventHandler(this.buttonBuscarProduto_Click);
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFiltro.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(657, 71);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(142, 25);
            this.comboBoxFiltro.TabIndex = 22;
            // 
            // textBoxCampoBusca
            // 
            this.textBoxCampoBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxCampoBusca.Location = new System.Drawing.Point(657, 102);
            this.textBoxCampoBusca.Name = "textBoxCampoBusca";
            this.textBoxCampoBusca.Size = new System.Drawing.Size(142, 24);
            this.textBoxCampoBusca.TabIndex = 24;
            // 
            // consultaProdTitle
            // 
            this.consultaProdTitle.AutoSize = true;
            this.consultaProdTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.consultaProdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.consultaProdTitle.ForeColor = System.Drawing.Color.White;
            this.consultaProdTitle.Location = new System.Drawing.Point(12, 9);
            this.consultaProdTitle.Name = "consultaProdTitle";
            this.consultaProdTitle.Size = new System.Drawing.Size(273, 25);
            this.consultaProdTitle.TabIndex = 36;
            this.consultaProdTitle.Text = "CONSULTA DE PRODUTOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Filtrar por:";
            // 
            // FormConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consultaProdTitle);
            this.Controls.Add(this.textBoxCampoBusca);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.buttonBuscarProduto);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.PanelBackground);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA DE PRODUTO";
            this.Load += new System.EventHandler(this.FormConsultaProduto_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PanelBackground;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonBuscarProduto;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox textBoxCampoBusca;
        private System.Windows.Forms.Label consultaProdTitle;
        private System.Windows.Forms.Label label1;
    }
}