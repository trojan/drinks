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
    public partial class FormCompra : Form
    {
        public FormCompra()
        {
            InitializeComponent();
        }

        #region  [DECLARAÇÕES]
        // DAO
        DAO.DAO dao = new DAO.DAO();

        // MODEL
        Model.ProdutoModel prd_m = new Model.ProdutoModel();
        Model.ItensCompraModel icmp_m = new Model.ItensCompraModel();
        Model.CompraModel cmp_m = new Model.CompraModel();

        // CONTROLLER
        Controller.ProdutoController prd_c = new Controller.ProdutoController();
        Controller.ItensCompraController icmp_c = new Controller.ItensCompraController();
        Controller.CompraController cmp_c = new Controller.CompraController();
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

            dao.ListaItensCompra(icmp_m).Fill(dtItens);

            dgvItemPedido.DataSource = dtItens;
            dgvItemPedido.Columns["CODIGO"].Visible = false;
            dgvItemPedido.Columns["PRODUTO"].Visible = true;
            dgvItemPedido.Columns["MARCA"].Visible = true;
            dgvItemPedido.Columns["TAMANHO"].Visible = true;
            dgvItemPedido.Columns["UNIDADE_MEDIDA"].Visible = true;
            dgvItemPedido.Columns["QUANTIDADE_UNITARIO"].Visible = true;
            dgvItemPedido.Columns["VALOR_UNITARIO"].Visible = true;
            dgvItemPedido.Columns["VALOR_TOTAL_UNITARIO"].Visible = true;
        }

        public void LimpaDGV()
        {
            dgvItemPedido.DataSource = null; //REMOVERA O DATASOURCE
            //dgvItemPedido.Columns.Clear(); //REMOVERA AS COLUNAS
            dgvItemPedido.Rows.Clear();    //REMOVERA AS LINHAS
            dgvItemPedido.Refresh();    //ATUALIZARA O DGV
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

        private void FormCompra_Load(object sender, EventArgs e)
        {
            // CARREGARA OS PRODUTOS NO COMBOBOX
            ListaProduto();
            // TIRAR LINHA EM BRANCO DO DATA_GRID_VIEW
            dgvItemPedido.AllowUserToAddRows = false;

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



        #region [COMPRAS]
        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            // CODIGO RECEBERA O ID DO SUPOSTO PROXIMO ID_ITENS_COMPRA
            int codigo = Convert.ToInt32(dao.BuscaRegistroCompra());
            int quantidadeTotal = 0;
            decimal valorTotal = 0;

            foreach (DataGridViewRow row in dgvItemPedido.Rows)
            {
                // PEGARA O ID DO PRODUTO NA TABELA
                int id = prd_m.IdProduto = Convert.ToInt32(row.Cells["IDPRODUTO"].Value);
                
                // PEGARA A QUANTIDADE ATUAL DO PRODUTO NO ESTOQUE, APARTIR DO ID DO PRODUTO
                int quantidade = dao.BuscarProdutoEspecifico(prd_m);
               
                // SOMARA A QUANTIDADE QUE TINHA EM ESTOQUE + QUANTIDADE DE ENTRADA
                quantidade += Convert.ToInt32(row.Cells["QUANTIDADE_UNITARIO"].Value);

                //INSERIR OS ITENS DA TABELA DE ITENS COMPRA
                icmp_c.InsereItensCompra(codigo, Convert.ToInt32(row.Cells["IDPRODUTO"].Value), Convert.ToInt32(row.Cells["QUANTIDADE_UNITARIO"].Value), Convert.ToDecimal(row.Cells["VALOR_UNITARIO"].Value));
                
                // SOMARA TODAS A QUANTIDADE E VALORES UNITARIOS DA TABELA, FORMANDO UM QUANTIDADE TOTAL E VALOR TOTAL
                quantidadeTotal += Convert.ToInt32(row.Cells["QUANTIDADE_UNITARIO"].Value);
                valorTotal += Convert.ToDecimal(row.Cells["VALOR_TOTAL_UNITARIO"].Value);

                //ADICIONARA A QUANTIDADE NO ESTOQUE, DE ACORDO COM O ID DO PRODUTO
                prd_c.AlteraQuantidadeProduto(id, quantidade);
            }

            //IRA INSERIR 
            cmp_c.InsereCompra(codigo, quantidadeTotal, valorTotal);

            // LIMPARA O DATA GRID VIEW
            LimpaDGV();

        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region [ITENS_COMPRA]
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

            this.dgvItemPedido.Rows.Add(Convert.ToInt32(comboBoxProdutoInformation.SelectedValue), informacaoProduto, textBoxValor.Text, textBoxQuantidade.Text, Convert.ToDecimal(textBoxValor.Text) * Convert.ToInt32(textBoxQuantidade.Text));

            dgvItemPedido.Refresh();

            comboBoxProdutoInformation.Select();

            textBoxQuantidade.Text = "1";
        }

        private void buttonExcluirItem_Click(object sender, EventArgs e)
        {
            int linha_selecionada = dgvItemPedido.CurrentRow.Index;

            if (linha_selecionada >= 0)
            {
                dgvItemPedido.Rows.RemoveAt(linha_selecionada);
                dgvItemPedido.Refresh();
            }
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




