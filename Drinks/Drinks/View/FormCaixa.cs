using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks.View
{
    public partial class FormCaixa : Form
    {
        public FormCaixa()
        {
            InitializeComponent();
        }

        #region [DECLARÇÕES]
        // DAO
        DAO.DAO dao = new DAO.DAO();

        // MODEL
        Model.ProdutoModel prd_m = new Model.ProdutoModel();
        Model.ItensVendaModel ivnd_m = new Model.ItensVendaModel();
        Model.VendaModel vnd_m = new Model.VendaModel();

        // CONTROLLER
        Controller.ProdutoController prd_c = new Controller.ProdutoController();
        Controller.ItensVendaController ivnd_c = new Controller.ItensVendaController();
        Controller.VendaController vnd_c = new Controller.VendaController();
        #endregion

        #region [FUNÇÕES]
        DataTable dtProduto = new DataTable();
        DataTable dtItens = new DataTable();

        public void ListaProduto()
        {
            dao.ListarDados(null, null, null, null, prd_m).Fill(dtProduto);

            dtProduto.Columns.Add("PRODUCT_INFORMATION", typeof(String), "PRODUTO + ' ' + MARCA + ' ' + TAMANHO + '' + UNIDADE_MEDIDA");

            comboBoxProdutoInformation.DataSource = dtProduto;
            comboBoxProdutoInformation.DisplayMember = "PRODUCT_INFORMATION";
            comboBoxProdutoInformation.ValueMember = "CODIGO";
            comboBoxProdutoInformation.Refresh();
        }

        public void ListaItensCompra()
        {

            dao.ListaItensVenda(ivnd_m).Fill(dtItens);

            dgvItemVenda.DataSource = dtItens;
            dgvItemVenda.Columns["CODIGO"].Visible = false;
            dgvItemVenda.Columns["PRODUTO"].Visible = true;
            dgvItemVenda.Columns["MARCA"].Visible = true;
            dgvItemVenda.Columns["TAMANHO"].Visible = true;
            dgvItemVenda.Columns["UNIDADE_MEDIDA"].Visible = true;
            dgvItemVenda.Columns["QUANTIDADE_UNITARIO"].Visible = true;
            dgvItemVenda.Columns["VALOR_UNITARIO"].Visible = true;
            dgvItemVenda.Columns["VALOR_TOTAL_UNITARIO"].Visible = true;
        }

        public void LimpaDGV()
        {
            dgvItemVenda.DataSource = null; //REMOVERA O DATASOURCE
            //dgvItemVenda.Columns.Clear(); //REMOVERA AS COLUNAS
            dgvItemVenda.Rows.Clear();    //REMOVERA AS LINHAS
            dgvItemVenda.Refresh();    //ATUALIZARA O DGV
        }

        // RETORNA O PRODUTO DOS CAMPOS 'VALOR UNITARIO' E 'QUANTIDADE'
        private void Multiply()
        {
            float a;
            int b;

            bool isAValid = float.TryParse(textBoxValor.Text, out a);
            bool isBValid = int.TryParse(textBoxQuantidade.Text, out b);

            if (isAValid && isBValid)
                textBoxValorTotal.Text = (a * b).ToString();
            else
                textBoxValorTotal.Text = "Valores inválidos.";
        }
        #endregion


        private void FormCaixa_Load(object sender, EventArgs e)
        {
            // CARREGARA OS PRODUTOS NO COMBOBOX
            ListaProduto();
            // TIRAR LINHA EM BRANCO DO DATA_GRID_VIEW
            dgvItemVenda.AllowUserToAddRows = false;

            // VALOR INICIAL NA QUANTIDADE
            textBoxQuantidade.Text = "1";

            comboBoxProdutoInformation.Select();
        }

        private void comboBoxProdutoInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // QUANDO SELECIONAR UM ITEM NO COMBOBOX
            DataRowView drv = ((DataRowView)comboBoxProdutoInformation.SelectedItem);
            // ATRIBUIRA AO TEXTBOXVALOR O VALOR DESSE ITEM SELECIONADO 
            textBoxValor.Text = drv["VALOR_UNITARIO"].ToString();
        }


        #region [VENDA]
        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            // CODIGO RECEBERA O ID DO SUPOSTO PROXIMO ID_ITENS_VENDA
            int codigo = Convert.ToInt32(dao.BuscaRegistroVenda());
            int quantidadeTotal = 0;
            decimal valorTotal = 0;

            foreach (DataGridViewRow row in dgvItemVenda.Rows)
            {
                // PEGARA O ID DO PRODUTO NA TABELA
                int id = prd_m.IdProduto = Convert.ToInt32(row.Cells["IDPRODUTO"].Value);

                // PEGARA A QUANTIDADE ATUAL DO PRODUTO NO ESTOQUE, APARTIR DO ID DO PRODUTO
                int quantidade = dao.BuscarProdutoEspecifico(prd_m);

                // SUBTRAIRA A QUANTIDADE QUE TINHA EM ESTOQUE - QUANTIDADE DE SAIDA
                quantidade -= Convert.ToInt32(row.Cells["QUANTIDADE_UNITARIO"].Value);

                //INSERIR OS ITENS DA TABELA DE ITENS VENDA
                ivnd_c.InsereItensVenda(codigo, Convert.ToInt32(row.Cells["IDPRODUTO"].Value), Convert.ToInt32(row.Cells["QUANTIDADE_UNITARIO"].Value), Convert.ToDecimal(row.Cells["VALOR_UNITARIO"].Value));

                // SOMARA TODAS A QUANTIDADE E VALORES UNITARIOS DA TABELA, FORMANDO UM QUANTIDADE TOTAL E VALOR TOTAL
                quantidadeTotal += Convert.ToInt32(row.Cells["QUANTIDADE_UNITARIO"].Value);
                valorTotal += Convert.ToDecimal(row.Cells["VALOR_TOTAL_UNITARIO"].Value);

                //SUBTRAIRA A QUANTIDADE NO ESTOQUE, DE ACORDO COM O ID DO PRODUTO
                prd_c.AlteraQuantidadeProduto(id, quantidade);
            }

            //IRA INSERIR 
            vnd_c.InsereVenda(codigo, quantidadeTotal, valorTotal);

            // LIMPARA O DATA GRID VIEW
            LimpaDGV();

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimpaDGV();
            textBoxQuantidade.Text = "1";
            textBoxTotalPagar.Text = "";

            comboBoxProdutoInformation.Select();
        }


        #endregion

        #region [ITENS_VENDA]
        private void buttonNovoItem_Click(object sender, EventArgs e)
        {
            comboBoxProdutoInformation.Select();

            // VALOR INICIAL NA QUANTIDADE
            textBoxQuantidade.Text = "1";
        }



        private void buttonGravarItem_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)comboBoxProdutoInformation.SelectedItem);
            string informacaoProduto = drv["PRODUCT_INFORMATION"].ToString();

            this.dgvItemVenda.Rows.Add(Convert.ToInt32(comboBoxProdutoInformation.SelectedValue), informacaoProduto, textBoxValor.Text, textBoxQuantidade.Text, Convert.ToDecimal(textBoxValor.Text) * Convert.ToInt32(textBoxQuantidade.Text));

            dgvItemVenda.Refresh();
            comboBoxProdutoInformation.Select();

            textBoxQuantidade.Text = "1";

            decimal totalPagar = 0;

            foreach (DataGridViewRow row in dgvItemVenda.Rows)
            {
                totalPagar += Convert.ToDecimal(row.Cells["VALOR_TOTAL_UNITARIO"].Value);

                textBoxTotalPagar.Text = Convert.ToString(totalPagar);
            }
        }

        private void buttonExcluirItem_Click(object sender, EventArgs e)
        {
            int linha_selecionada = dgvItemVenda.CurrentRow.Index;

            if (linha_selecionada > 0)
                linha_selecionada -= 1;

            decimal val = Convert.ToDecimal(dgvItemVenda.SelectedRows[linha_selecionada].Cells["VALOR_TOTAL_UNITARIO"].Value.ToString());
            decimal totalPagar = Convert.ToDecimal(textBoxTotalPagar.Text) - val;

            textBoxTotalPagar.Text = Convert.ToString(totalPagar);

            dgvItemVenda.Rows.RemoveAt(linha_selecionada);
        }

        private void buttonVisualizarItem_Click(object sender, EventArgs e)
        {

        }
        #endregion



        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            Multiply();
        }

        private void textBoxQuantidade_TextChanged(object sender, EventArgs e)
        {
            Multiply();
        }

    }
}
