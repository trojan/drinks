namespace Drinks.View
{
    partial class FormTamanho
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
            this.panelTamanho = new System.Windows.Forms.Panel();
            this.labelID = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.PanelBackground = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTamanho = new System.Windows.Forms.DataGridView();
            this.buttonSair = new System.Windows.Forms.Button();
            this.tamanhoTitle = new System.Windows.Forms.Label();
            this.panelTamanho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBackground)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamanho)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTamanho
            // 
            this.panelTamanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTamanho.Controls.Add(this.labelID);
            this.panelTamanho.Controls.Add(this.labelDescricao);
            this.panelTamanho.Controls.Add(this.textBoxDescricao);
            this.panelTamanho.Controls.Add(this.textBoxID);
            this.panelTamanho.Location = new System.Drawing.Point(12, 48);
            this.panelTamanho.Name = "panelTamanho";
            this.panelTamanho.Size = new System.Drawing.Size(375, 100);
            this.panelTamanho.TabIndex = 21;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelID.Location = new System.Drawing.Point(29, 16);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 20);
            this.labelID.TabIndex = 5;
            this.labelID.Text = "ID";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDescricao.Location = new System.Drawing.Point(150, 16);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(80, 20);
            this.labelDescricao.TabIndex = 4;
            this.labelDescricao.Text = "Descrição";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxDescricao.Location = new System.Drawing.Point(154, 39);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(185, 26);
            this.textBoxDescricao.TabIndex = 3;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxID.Location = new System.Drawing.Point(33, 39);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(81, 26);
            this.textBoxID.TabIndex = 2;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNovo.ForeColor = System.Drawing.Color.White;
            this.buttonNovo.Location = new System.Drawing.Point(393, 48);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(90, 30);
            this.buttonNovo.TabIndex = 20;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.Crimson;
            this.buttonExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonExcluir.ForeColor = System.Drawing.Color.White;
            this.buttonExcluir.Location = new System.Drawing.Point(393, 293);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(90, 30);
            this.buttonExcluir.TabIndex = 19;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonGravar
            // 
            this.buttonGravar.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonGravar.ForeColor = System.Drawing.Color.White;
            this.buttonGravar.Location = new System.Drawing.Point(393, 257);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(90, 30);
            this.buttonGravar.TabIndex = 18;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = false;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(495, 42);
            this.PanelBackground.TabIndex = 17;
            this.PanelBackground.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvTamanho);
            this.panel1.Location = new System.Drawing.Point(12, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 185);
            this.panel1.TabIndex = 23;
            // 
            // dgvTamanho
            // 
            this.dgvTamanho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTamanho.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTamanho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTamanho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTamanho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTamanho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTamanho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTamanho.GridColor = System.Drawing.Color.White;
            this.dgvTamanho.Location = new System.Drawing.Point(0, 0);
            this.dgvTamanho.MultiSelect = false;
            this.dgvTamanho.Name = "dgvTamanho";
            this.dgvTamanho.ReadOnly = true;
            this.dgvTamanho.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTamanho.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvTamanho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTamanho.Size = new System.Drawing.Size(373, 183);
            this.dgvTamanho.TabIndex = 1;
            this.dgvTamanho.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTamanho_CellMouseDoubleClick);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSair.ForeColor = System.Drawing.Color.Red;
            this.buttonSair.Location = new System.Drawing.Point(393, 329);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(90, 30);
            this.buttonSair.TabIndex = 22;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // tamanhoTitle
            // 
            this.tamanhoTitle.AutoSize = true;
            this.tamanhoTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.tamanhoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tamanhoTitle.ForeColor = System.Drawing.Color.White;
            this.tamanhoTitle.Location = new System.Drawing.Point(12, 9);
            this.tamanhoTitle.Name = "tamanhoTitle";
            this.tamanhoTitle.Size = new System.Drawing.Size(114, 25);
            this.tamanhoTitle.TabIndex = 36;
            this.tamanhoTitle.Text = "TAMANHO";
            // 
            // FormTamanho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 370);
            this.Controls.Add(this.tamanhoTitle);
            this.Controls.Add(this.panelTamanho);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.PanelBackground);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTamanho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAMANHO";
            this.Load += new System.EventHandler(this.FormTamanho_Load);
            this.panelTamanho.ResumeLayout(false);
            this.panelTamanho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBackground)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamanho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTamanho;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.PictureBox PanelBackground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTamanho;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label tamanhoTitle;
    }
}