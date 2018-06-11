using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlServerCe;

namespace Drinks.DAO
{
    class DAO
    {
        // CRIARA O BD
        public void CreateDB()
        {
            // Criara a pasta do bd
            string folder = "bd";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            //  Criar o arquivo bd (*.sdf)
            if (!File.Exists(@"bd\drinks.sdf"))
            {
                string path = @"Data Source = bd\drinks.sdf";
                SqlCeEngine engine = new SqlCeEngine(path);
                engine.CreateDatabase();
                engine.Dispose();
            }
        }

        // CRIARA AS TABELAS DENTRO DO BD
        public void CreateTB()
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string[] comandos = {
                "CREATE TABLE NIVEL_ACESSO(" +
                 "idNivelAcesso         int IDENTITY (1,1) CONSTRAINT pkIdNivelAcesso PRIMARY KEY NOT NULL,  " +
                 "descricao             nvarchar(15));",

                 "CREATE TABLE USUARIO( " +
                 "idUsuario         int IDENTITY (1,1) CONSTRAINT pkIdUsuario PRIMARY KEY NOT NULL,  " +
                 "login             nvarchar(20),  " +
                 "senha             nvarchar(20),  " +
                 "idNivelAcesso     int, " +
                 "status            int, " +
                 "foreign key (idNivelAcesso) references NIVEL_ACESSO (idNivelAcesso));",

                 "CREATE TABLE FORNECEDOR( " +
                 "cnpj                  bigint CONSTRAINT pkFornecedor PRIMARY KEY NOT NULL, " +
                 "razaoSocial           nvarchar(60), " +
                 "cep                   nvarchar(9), " +
                 "endereco              nvarchar(60), " +
                 "numero                nvarchar(7), " +
                 "bairro                nvarchar(30), " +
                 "cidade                nvarchar(55), " +
                 "uf                    nvarchar(2), " +
                 "dddTelefone           int, " +
                 "telefone              int, " +
                 "dddCelular            int, " +
                 "celular               nvarchar(9)," +
                 "nomeFantasia          nvarchar(30), " +
                 "inscricaoEstadual     bigint, " +
                 "email                 nvarchar(60), " +
                 "status                int);",

                 "CREATE TABLE MARCA( " +
                 "idMarca           int IDENTITY (1,1) CONSTRAINT pkIdMarca PRIMARY KEY NOT NULL,  " +
                 "descricao         nvarchar(20)," +
                 "status            int);",

                 "CREATE TABLE TAMANHO( " +
                 "idTamanho             int IDENTITY (1,1) CONSTRAINT pkIdTamanho PRIMARY KEY NOT NULL,  " +
                 "descricao             nvarchar(20), " +
                 "status                int);",

                 "CREATE TABLE UNIDADE_MEDIDA( " +
                 "idUnidadeMedida       int IDENTITY (1,1) CONSTRAINT pkIdUnidadeMedida PRIMARY KEY NOT NULL,  " +
                 "descricao             nvarchar(20)," +
                 "status                int);",

                 "CREATE TABLE ESTOQUE( " +
                 "idProduto             int IDENTITY (1,1) CONSTRAINT pkIdProduto PRIMARY KEY NOT NULL,  " +
                 "idMarca               int, " +
                 "descricao             nvarchar(60), " +
                 "idUnidadeMedida       int, " +
                 "idTamanho             int, " +
                 "quantidade            int, " +
                 "valorUnitario         decimal(10, 2), " +
                 "valorTotalUnitario    decimal(10, 2), " +
                 "valorTotal            decimal(10, 2), " +
                 "status                int, " +
                 "foreign key (idMarca) references MARCA (idMarca), " +
                 "foreign key (idUnidadeMedida) references UNIDADE_MEDIDA (idUnidadeMedida), " +
                 "foreign key (idTamanho) references TAMANHO (idTamanho)); ",

                 "CREATE TABLE ITENS_COMPRA ( " +
                 "idItensCompra            int NOT NULL, " +
                 "idProduto                int, " +
                 "quantidadeUnitario       int, " +
                 "valorUnitario            decimal(10, 2), " +
                 "foreign key (idProduto) references ESTOQUE (idProduto)); ",

                 "CREATE TABLE COMPRAS ( " +
                 "idCompra              int IDENTITY (1,1) CONSTRAINT pkIdCompra PRIMARY KEY NOT NULL,  " +
                 "idItensCompra         int, " +
                 "quantidadeTotal       int, " +
                 "valorTotal            decimal(10, 2), " +
                 "dataCompra            datetime," +
                 "status                int); ",

                 "CREATE TABLE ITENS_VENDA ( " +
                 "idItensVenda             int NOT NULL,  " +
                 "idProduto                int, " +
                 "quantidadeUnitario       int, " +
                 "valorUnitario            decimal(10, 2), " +
                 "foreign key (idProduto) references ESTOQUE (idProduto)); ",

                 "CREATE TABLE VENDAS ( " +
                 "idVenda               int IDENTITY (1,1) CONSTRAINT pkIdVendas PRIMARY KEY NOT NULL,  " +
                 "idItensVenda          int, " +
                 "quantidadeTotal       int, " +
                 "valorTotal            decimal(10, 2), " +
                 "dataVenda             datetime, " +
                 "status                int); "
            };

            foreach (string cmmd in comandos)
            {
                SqlCeCommand cmd = new SqlCeCommand(cmmd, conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();

        }

        // VERIFICARA SE AS TABELAS FORAM CRIADAS
        public int CheckTB()
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            try
            {

                SqlCeCommand verifica = new SqlCeCommand("SELECT Count(*) FROM INFORMATION_SCHEMA.TABLES", conn);
                verifica.ExecuteNonQuery();
                int num = Convert.ToInt32(verifica.ExecuteScalar());
                conn.Close();
                return num;
            }
            catch
            {
                return 0;
            }

        }




        //+-------------------------------+//
        //|           FORNECEDOR          |//
        //+-------------------------------+//

        public bool InserirFornecedor(Model.FornecedorModel fnd)
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            try
            {
                conn.Open();
                string querySql = "INSERT INTO FORNECEDOR (cnpj, razaoSocial, cep, endereco, numero, bairro, cidade, uf, dddTelefone, telefone, dddCelular, celular, nomeFantasia, inscricaoEstadual, email, status) VALUES (@cnpj, @razaoSocial, @cep, @endereco, @numero, @bairro, @cidade, @uf, @dddTelefone, @telefone, @dddCelular, @celular, @nomeFantasia, @inscricaoEstadual, @email, @status);";
                SqlCeCommand insere = new SqlCeCommand(querySql, conn);
                insere.Parameters.AddWithValue("@cnpj", fnd.Cnpj);
                insere.Parameters.AddWithValue("@razaoSocial", fnd.RazaoSocial);
                insere.Parameters.AddWithValue("@cep", fnd.Cep);
                insere.Parameters.AddWithValue("@endereco", fnd.Endereco);
                insere.Parameters.AddWithValue("@numero", fnd.Numero);
                insere.Parameters.AddWithValue("@bairro", fnd.Bairro);
                insere.Parameters.AddWithValue("@cidade", fnd.Cidade);
                insere.Parameters.AddWithValue("@uf", fnd.Uf);
                insere.Parameters.AddWithValue("@dddTelefone", fnd.DDDTelefone);
                insere.Parameters.AddWithValue("@telefone", fnd.Telefone);
                insere.Parameters.AddWithValue("@dddCelular", fnd.DDDCelular);
                insere.Parameters.AddWithValue("@celular", fnd.Celular);
                insere.Parameters.AddWithValue("@nomeFantasia", fnd.NomeFantasia);
                insere.Parameters.AddWithValue("@inscricaoEstadual", fnd.InscricaoEstadual);
                insere.Parameters.AddWithValue("@email", fnd.Email);
                insere.Parameters.AddWithValue("@status", 1);
                insere.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AlterarFonecedor(Model.FornecedorModel fnd)
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            try
            {
                conn.Open();
                string querySql = "UPDATE FORNECEDOR SET razaoSocial=@razaoSocial, cep=@cep, endereco=@endereco, numero=@numero, bairro=@bairro, cidade=@cidade, uf=@uf, dddTelefone=@dddTelefone, telefone=@telefone, dddCelular=@dddCelular, celular=@celular, nomeFantasia=@nomeFantasia, inscricaoEstadual=@inscricaoEstadual, email=@email WHERE cnpj = " + fnd.Cnpj + ";";
                SqlCeCommand altera = new SqlCeCommand(querySql, conn);
                altera.Parameters.AddWithValue("@razaoSocial", fnd.RazaoSocial);
                altera.Parameters.AddWithValue("@cep", fnd.Cep);
                altera.Parameters.AddWithValue("@endereco", fnd.Endereco);
                altera.Parameters.AddWithValue("@numero", fnd.Numero);
                altera.Parameters.AddWithValue("@bairro", fnd.Bairro);
                altera.Parameters.AddWithValue("@cidade", fnd.Cidade);
                altera.Parameters.AddWithValue("@uf", fnd.Uf);
                altera.Parameters.AddWithValue("@dddTelefone", fnd.DDDTelefone);
                altera.Parameters.AddWithValue("@telefone", fnd.Telefone);
                altera.Parameters.AddWithValue("@dddCelular", fnd.DDDCelular);
                altera.Parameters.AddWithValue("@celular", fnd.Celular);
                altera.Parameters.AddWithValue("@nomeFantasia", fnd.NomeFantasia);
                altera.Parameters.AddWithValue("@inscricaoEstadual", fnd.InscricaoEstadual);
                altera.Parameters.AddWithValue("@email", fnd.Email);
                altera.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public SqlCeDataAdapter ListarFornecedor(string busca_seletiva, Model.FornecedorModel fnd)
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            if (busca_seletiva == null)
            {
                try
                {
                    string querySql = "SELECT cnpj AS CNPJ, razaoSocial AS RAZAO_SOCIAL, cep AS CEP, endereco AS ENDERECO, numero AS NUMERO, bairro AS BAIRRO, cidade AS CIDADE, uf AS UF, dddTelefone AS DDD_TELEFONE, telefone AS TELEFONE, dddCelular AS DDD_CELULAR, celular AS CELULAR, nomeFantasia AS NOME_FANTASIA, inscricaoEstadual AS INSCRICAO_ESTADUAL, email AS EMAIL  FROM FORNECEDOR WHERE status = 1 ORDER BY RAZAO_SOCIAL;";
                    SqlCeCommand lista = conn.CreateCommand();
                    lista.CommandText = querySql;
                    SqlCeDataAdapter adp = new SqlCeDataAdapter(lista);
                    conn.Close();
                    return adp;
                }
                catch
                {
                    return null;
                }

            }
            else
            {
                try
                {
                    SqlCeCommand lista = new SqlCeCommand(busca_seletiva, conn);
                    SqlCeDataAdapter adp = new SqlCeDataAdapter(lista);
                    conn.Close();
                    return adp;
                }
                catch
                {
                    return null;
                }
            }
        }
        
        public bool ExcluirFornecedor(Model.FornecedorModel fnd)
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            try
            {
                conn.Open();
                string querySql = "UPDATE FORNECEDOR SET status=@status WHERE cnpj = " + fnd.Cnpj + ";";
                SqlCeCommand exclui = new SqlCeCommand(querySql, conn);
                exclui.Parameters.AddWithValue("@status", 0);
                exclui.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }



        //+-------------------------------+//
        //|            BASICO             |//
        //+-------------------------------+//

        // INSERÇÃO DE DADOS
        public bool InserirDados(Model.MarcaModel mrc, Model.UnidadeMedidaModel und, Model.TamanhoModel tmh, Model.ProdutoModel prd)
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            if (mrc != null)        // INSERIR OS DADOS NA TABELA MARCA
            {
                #region [MARCA]
                try
                {
                    conn.Open();
                    string querySql = "INSERT INTO MARCA (descricao, status) VALUES (@descricaoMarca, @statusMarca)";
                    SqlCeCommand insere = new SqlCeCommand(querySql, conn);
                    insere.Parameters.AddWithValue("@descricaoMarca", mrc.DescricaoMarca);
                    insere.Parameters.AddWithValue("@statusMarca", 1);
                    insere.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
                #endregion
            }
            else if (und != null)       // INSERIR OS DADOS NA TABELA UNIDADE_MEDIDA
            {
                #region [UNIDADE_MEDIDA]
                try
                {
                    conn.Open();
                    string querySql = "INSERT INTO UNIDADE_MEDIDA (descricao, status) VALUES (@descricaoUnidadeMedida, @statusUnidadeMedida)";
                    SqlCeCommand insere = new SqlCeCommand(querySql, conn);
                    insere.Parameters.AddWithValue("@descricaoUnidadeMedida", und.DescricaoUnidadeMedida);
                    insere.Parameters.AddWithValue("@statusUnidadeMedida", 1);
                    insere.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
                #endregion
            }
            else if (tmh != null)           // INSERIR OS DADOS NA TABELA TAMANHO
            {
                #region [TAMANHO]
                try
                {
                    conn.Open();
                    string querySql = "INSERT INTO TAMANHO (descricao, status) VALUES (@descricaoTamanho, @statusTamanho)";
                    SqlCeCommand insere = new SqlCeCommand(querySql, conn);
                    insere.Parameters.AddWithValue("@descricaoTamanho", tmh.DescricaoTamanho);
                    insere.Parameters.AddWithValue("@statusTamanho", 1);
                    insere.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
                #endregion
            }
            else                    // INSERIR OS DADOS NA TABELA ESTOQUE
            {
                #region [PRODUTOS]
                try
                {
                    conn.Open();
                    string querySql = "INSERT INTO ESTOQUE (idMarca, descricao, idUnidadeMedida, idTamanho, quantidade, valorUnitario, status) VALUES (@idMarca, @descricaoProduto, @idUnidadeMedida, @idTamanho, @quantidadeProduto, @valorUnitario, @statusProduto)";
                    SqlCeCommand insere = new SqlCeCommand(querySql, conn);
                    insere.Parameters.AddWithValue("@idMarca", prd.IdMarca);
                    insere.Parameters.AddWithValue("@descricaoProduto", prd.DescricaoProduto);
                    insere.Parameters.AddWithValue("@idUnidadeMedida", prd.IdUnidadeMedida);
                    insere.Parameters.AddWithValue("@idTamanho", prd.IdTamanho);
                    insere.Parameters.AddWithValue("@quantidadeProduto", 0);
                    insere.Parameters.AddWithValue("@valorUnitario", prd.ValorUnitario);
                    insere.Parameters.AddWithValue("@statusProduto", 1);
                    insere.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
                #endregion
            }

        }

        // ALTERAR DADOS
        public bool AlterarDados(Model.MarcaModel mrc, Model.UnidadeMedidaModel und, Model.TamanhoModel tmh, Model.ProdutoModel prd)
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            if (mrc != null)        // ALTERAR OS DADOS NA TABELA MARCA
            {
                #region [MARCA]
                try
                {
                    conn.Open();
                    string querySql = "UPDATE MARCA SET descricao=@descricaoMarca WHERE idMarca = " + mrc.IdMarca + ";";
                    SqlCeCommand altera = new SqlCeCommand(querySql, conn);
                    altera.Parameters.AddWithValue("@descricaoMarca", mrc.DescricaoMarca);
                    altera.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
                #endregion
            }
            else if (und != null)   // ALTERAR OS DADOS NA TABELA UNIDADE_MEDIDA
            {
                #region [UNIDADE_MEDIDA]
                try
                {
                    conn.Open();
                    string querySql = "UPDATE UNIDADE_MEDIDA SET descricao=@descricaoUnidadeMedida WHERE idUnidadeMedida = " + und.IdUnidadeMedida + ";";
                    SqlCeCommand altera = new SqlCeCommand(querySql, conn);
                    altera.Parameters.AddWithValue("@descricaoUnidadeMedida", und.DescricaoUnidadeMedida);
                    altera.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
                #endregion
            }
            else if (tmh != null)   // ALTERAR OS DADOS NA TABELA TAMANHO
            {
                #region [TAMANHO]
                try
                {
                    conn.Open();
                    string querySql = "UPDATE TAMANHO SET descricao=@descricaoTamanho WHERE idTamanho = " + tmh.IdTamanho + ";";
                    SqlCeCommand altera = new SqlCeCommand(querySql, conn);
                    altera.Parameters.AddWithValue("@descricaoTamanho", tmh.DescricaoTamanho);
                    altera.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
                #endregion
            }
            else                    // ALTERAR OS DADOS NA TABELA ESTOQUE
            {
                #region [PRODUTOS]
                try
                {
                    conn.Open();
                    string querySql = "UPDATE ESTOQUE SET idMarca=@idMarca, descricao=@descricaoProduto, idUnidadeMedida=@idUnidadeMedida, idTamanho=@idTamanho, quantidade=@quantidadeUnitario, valorUnitario=@valorUnitario WHERE idProduto = " + prd.IdProduto + ";";
                    SqlCeCommand altera = new SqlCeCommand(querySql, conn);
                    altera.Parameters.AddWithValue("@idMarca", prd.IdMarca);
                    altera.Parameters.AddWithValue("@descricaoProduto", prd.DescricaoProduto);
                    altera.Parameters.AddWithValue("@idUnidadeMedida", prd.IdUnidadeMedida);
                    altera.Parameters.AddWithValue("@idTamanho", prd.IdTamanho);
                    altera.Parameters.AddWithValue("@quantidadeUnitario", prd.Quantidade);
                    altera.Parameters.AddWithValue("@valorUnitario", prd.ValorUnitario);
                    altera.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
                #endregion
            }
        }

        // LISTAR OU BUSCAR DADOS
        public SqlCeDataAdapter ListarDados(string busca_seletiva, Model.MarcaModel mrc, Model.UnidadeMedidaModel und, Model.TamanhoModel tmh, Model.ProdutoModel prd)
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            if (mrc != null)        // LISTAR OU BUSCAR OS DADOS DA TABELA MARCA
            {
                #region [MARCA]
                if (busca_seletiva == null)
                {
                    try
                    {
                        string querySql = "SELECT idMarca AS CODIGO, descricao AS DESCRICAO FROM MARCA WHERE status = 1 ORDER BY DESCRICAO;";
                        SqlCeCommand lista = conn.CreateCommand();
                        lista.CommandText = querySql;
                        SqlCeDataAdapter adp = new SqlCeDataAdapter(lista);
                        conn.Close();
                        return adp;
                    }
                    catch
                    {
                        return null;
                    }

                }
                else
                {
                    try
                    {
                        SqlCeCommand lista = new SqlCeCommand(busca_seletiva, conn);
                        SqlCeDataAdapter adp = new SqlCeDataAdapter(lista);
                        conn.Close();
                        return adp;
                    }
                    catch
                    {
                        return null;
                    }
                }
                #endregion
            }
            else if (und != null)   // LISTAR OU BUSCAR OS DADOS DA TABELA UNIDADE_MEDIDA
            {
                #region [UNIDADE_MEDIDA]
                if (busca_seletiva == null)
                {
                    try
                    {
                        string querySql = "SELECT idUnidadeMedida AS CODIGO, descricao AS DESCRICAO FROM UNIDADE_MEDIDA WHERE status = 1 ORDER BY DESCRICAO";
                        SqlCeCommand lista = conn.CreateCommand();
                        lista.CommandText = querySql;
                        SqlCeDataAdapter adp = new SqlCeDataAdapter(lista);
                        conn.Close();
                        return adp;
                    }
                    catch
                    {
                        return null;
                    }

                }
                else
                {
                    try
                    {
                        SqlCeCommand lista = new SqlCeCommand(busca_seletiva, conn);
                        SqlCeDataAdapter adp = new SqlCeDataAdapter(lista);
                        conn.Close();
                        return adp;
                    }
                    catch
                    {
                        return null;
                    }
                }
                #endregion
            }
            else if (tmh != null)   // LISTAR OU BUSCAR OS DADOS DA TABELA TAMANHO
            {
                #region [TAMANHO]
                if (busca_seletiva == null)
                {
                    try
                    {
                        string querySql = "SELECT idTamanho AS CODIGO, descricao AS DESCRICAO FROM TAMANHO WHERE status = 1 ORDER BY DESCRICAO";
                        SqlCeCommand lista = conn.CreateCommand();
                        lista.CommandText = querySql;
                        SqlCeDataAdapter adp = new SqlCeDataAdapter(lista);
                        conn.Close();
                        return adp;
                    }
                    catch
                    {
                        return null;
                    }

                }
                else
                {
                    try
                    {
                        SqlCeCommand lista = new SqlCeCommand(busca_seletiva, conn);
                        SqlCeDataAdapter adp = new SqlCeDataAdapter(lista);
                        conn.Close();
                        return adp;
                    }
                    catch
                    {
                        return null;
                    }
                }
                #endregion
            }
            else if (prd != null)   // LISTAR OU BUSCAR OS DADOS DA TABELA ESTOQUE
            {
                #region [PRODUTOS]
                if (busca_seletiva == null)
                {
                    try
                    {
                        string querySql = "SELECT idProduto AS CODIGO, ESTOQUE.descricao AS PRODUTO, MARCA.descricao AS MARCA, TAMANHO.descricao AS TAMANHO, UNIDADE_MEDIDA.descricao AS UNIDADE_MEDIDA, quantidade AS QUANTIDADE, valorUnitario AS VALOR_UNITARIO, quantidade*valorUnitario AS VALOR_TOTAL_UNITARIO FROM ESTOQUE INNER JOIN MARCA ON (ESTOQUE.idMarca = MARCA.idMarca) INNER JOIN UNIDADE_MEDIDA ON (ESTOQUE.idUnidadeMedida = UNIDADE_MEDIDA.idUnidadeMedida) INNER JOIN TAMANHO ON (ESTOQUE.idTamanho = TAMANHO.idTamanho) WHERE ESTOQUE.status = 1 ORDER BY PRODUTO;";
                        SqlCeCommand lista = conn.CreateCommand();
                        lista.CommandText = querySql;
                        SqlCeDataAdapter adp = new SqlCeDataAdapter(lista);
                        conn.Close();
                        return adp;
                    }
                    catch
                    {
                        return null;
                    }

                }
                else
                {
                    try
                    {
                        SqlCeCommand lista = new SqlCeCommand(busca_seletiva, conn);
                        SqlCeDataAdapter adp = new SqlCeDataAdapter(lista);
                        conn.Close();
                        return adp;
                    }
                    catch
                    {
                        return null;
                    }
                }
                #endregion
            }
            else                    // NENHUM DADO ENCONTRADO
            {
                return null;
            }
        }

        // EXCLUIR DADOS
        public bool ExcluirDados(Model.MarcaModel mrc, Model.UnidadeMedidaModel und, Model.TamanhoModel tmh, Model.ProdutoModel prd)
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            if (mrc != null)
            {
                #region [MARCA]
                try
                {
                    conn.Open();
                    string querySql = "UPDATE MARCA SET status=@statusMarca WHERE idMarca = " + mrc.IdMarca + ";";
                    SqlCeCommand exclui = new SqlCeCommand(querySql, conn);
                    exclui.Parameters.AddWithValue("@statusMarca", 0);
                    exclui.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
                #endregion
            }
            else if (und != null)
            {
                #region [UNIDADE_MEDIDA]
                try
                {
                    conn.Open();
                    string querySql = "UPDATE UNIDADE_MEDIDA SET status=@statusUnidadeMedida WHERE idUnidadeMedida = " + und.IdUnidadeMedida + ";";
                    SqlCeCommand exclui = new SqlCeCommand(querySql, conn);
                    exclui.Parameters.AddWithValue("@statusUnidadeMedida", 0);
                    exclui.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
                #endregion
            }
            else if (tmh != null)
            {
                #region [TAMANHO]
                try
                {
                    conn.Open();
                    string querySql = "UPDATE TAMANHO SET status=@statusTamanho WHERE idTamanho = " + tmh.IdTamanho + ";";
                    SqlCeCommand exclui = new SqlCeCommand(querySql, conn);
                    exclui.Parameters.AddWithValue("@statusTamanho", tmh.DescricaoTamanho);
                    exclui.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
                #endregion
            }
            else
            {
                #region [PRODUTOS]
                try
                {
                    conn.Open();
                    string querySql = "UPDATE ESTOQUE SET status=@statusProduto WHERE idProduto = " + prd.IdProduto + ";";
                    SqlCeCommand exclui = new SqlCeCommand(querySql, conn);
                    exclui.Parameters.AddWithValue("@statusProduto", prd.ValorUnitario);
                    exclui.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
                #endregion
            }
        }



        //+-----------------------+//
        //|      ITENS COMPRA     |//
        //+-----------------------+//

        public bool InserirItensCompra(Model.ItensCompraModel icmp)
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            #region [ITENS_COMPRA]
            try
            {
                conn.Open();
                string querySql = "INSERT INTO ITENS_COMPRA (idItensCompra, idProduto, quantidadeUnitario, valorUnitario) VALUES (@idItensCompra, @idProduto, @quantidadeUnitario, @valorUnitario)";
                SqlCeCommand insereItensCompra = new SqlCeCommand(querySql, conn);
                insereItensCompra.Parameters.AddWithValue("@idItensCompra", icmp.IdItensCompra);
                insereItensCompra.Parameters.AddWithValue("@idProduto", icmp.IdProduto);
                insereItensCompra.Parameters.AddWithValue("@quantidadeUnitario", icmp.QuantidadeUnitario);
                insereItensCompra.Parameters.AddWithValue("@valorUnitario", icmp.ValorUnitario);
                insereItensCompra.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
            #endregion

        }

        public SqlCeDataAdapter ListaItensCompra(Model.ItensCompraModel icmp)
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            try
            {
                string querySql = "SELECT idItensCompra as CODIGO, ESTOQUE.descricao AS PRODUTO, MARCA.descricao AS MARCA, TAMANHO.descricao AS TAMANHO, UNIDADE_MEDIDA.descricao AS UNIDADE_MEDIDA, ITENS_COMPRA.quantidadeUnitario AS QUANTIDADE_UNITARIO, ITENS_COMPRA.valorUnitario AS VALOR_UNITARIO, ITENS_COMPRA.quantidadeUnitario*ITENS_COMPRA.valorUnitario AS VALOR_TOTAL_UNITARIO FROM ITENS_COMPRA INNER JOIN ESTOQUE ON (ITENS_COMPRA.idProduto = ESTOQUE.idProduto) INNER JOIN MARCA ON (ESTOQUE.idMarca = MARCA.idMarca) INNER JOIN TAMANHO ON (ESTOQUE.idTamanho = TAMANHO.idTamanho) INNER JOIN UNIDADE_MEDIDA ON (ESTOQUE.idUnidadeMedida = UNIDADE_MEDIDA.idUnidadeMedida) ORDER BY CODIGO;";
                SqlCeCommand lista = conn.CreateCommand();
                lista.CommandText = querySql;
                SqlCeDataAdapter adp = new SqlCeDataAdapter(lista);
                conn.Close();
                return adp;
            }
            catch
            {
                return null;
            }


        }



        //+------------------+//
        //|      COMPRAS     |//
        //+------------------+//

        public bool InserirCompra(Model.CompraModel cmp)
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            #region [COMPRA]
            try
            {
                conn.Open();
                string querySql = "INSERT INTO COMPRAS (idItensCompra, quantidadeTotal, valorTotal, dataCompra, status) VALUES (@idItensCompra, @quantidadeTotal, @valorTotal, @dataCompra, @status)";
                SqlCeCommand insereCompra = new SqlCeCommand(querySql, conn);
                insereCompra.Parameters.AddWithValue("@idItensCompra", cmp.IdItensCompra);
                insereCompra.Parameters.AddWithValue("@quantidadeTotal", cmp.QuantidadeTotal);
                insereCompra.Parameters.AddWithValue("@valorTotal", cmp.ValorTotal);
                insereCompra.Parameters.AddWithValue("@dataCompra", cmp.DataCompra);  // inserido
                insereCompra.Parameters.AddWithValue("@status", 1);
                insereCompra.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
            #endregion
        }

        

        //+-----------------------+//
        //|      ITENS VENDA      |//
        //+-----------------------+//

        public bool InserirItensVenda(Model.ItensVendaModel ivnd)
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            #region [ITENS_VENDA]
            try
            {
                conn.Open();
                string querySql = "INSERT INTO ITENS_VENDA (idItensVenda, idProduto, quantidadeUnitario, valorUnitario) VALUES (@idItensVenda, @idProduto, @quantidadeUnitario, @valorUnitario)";
                SqlCeCommand insereItensCompra = new SqlCeCommand(querySql, conn);
                insereItensCompra.Parameters.AddWithValue("@idItensVenda", ivnd.IdItensVenda);
                insereItensCompra.Parameters.AddWithValue("@idProduto", ivnd.IdProduto);
                insereItensCompra.Parameters.AddWithValue("@quantidadeUnitario", ivnd.QuantidadeUnitario);
                insereItensCompra.Parameters.AddWithValue("@valorUnitario", ivnd.ValorUnitario);
                insereItensCompra.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
            #endregion

        }

        public SqlCeDataAdapter ListaItensVenda(Model.ItensVendaModel ivnd)
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            try
            {
                string querySql = "SELECT idItensVenda as CODIGO, ESTOQUE.descricao AS PRODUTO, MARCA.descricao AS MARCA, TAMANHO.descricao AS TAMANHO, UNIDADE_MEDIDA.descricao AS UNIDADE_MEDIDA, ITENS_VENDA.quantidadeUnitario AS QUANTIDADE_UNITARIO, ITENS_VENDA.valorUnitario AS VALOR_UNITARIO, ITENS_VENDA.quantidadeUnitario*ITENS_VENDA.valorUnitario AS VALOR_TOTAL_UNITARIO FROM ITENS_VENDA INNER JOIN ESTOQUE ON (ITENS_VENDA.idProduto = ESTOQUE.idProduto) INNER JOIN MARCA ON (ESTOQUE.idMarca = MARCA.idMarca) INNER JOIN TAMANHO ON (ESTOQUE.idTamanho = TAMANHO.idTamanho) INNER JOIN UNIDADE_MEDIDA ON (ESTOQUE.idUnidadeMedida = UNIDADE_MEDIDA.idUnidadeMedida) ORDER BY CODIGO;";
                SqlCeCommand lista = conn.CreateCommand();
                lista.CommandText = querySql;
                SqlCeDataAdapter adp = new SqlCeDataAdapter(lista);
                conn.Close();
                return adp;
            }
            catch
            {
                return null;
            }


        }



        //+--------------------+//
        //|       VENDAS       |//
        //+--------------------+//

        public bool InserirVenda(Model.VendaModel ivnd)
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            #region [COMPRA]
            try
            {
                conn.Open();
                string querySql = "INSERT INTO VENDAS (idItensVenda, quantidadeTotal, valorTotal, dataVenda, status) VALUES (@idItensVenda, @quantidadeTotal, @valorTotal, @dataVenda, @status)";
                SqlCeCommand insereCompra = new SqlCeCommand(querySql, conn);
                insereCompra.Parameters.AddWithValue("@idItensVenda", ivnd.IdItensVenda);
                insereCompra.Parameters.AddWithValue("@quantidadeTotal", ivnd.QuantidadeTotal);
                insereCompra.Parameters.AddWithValue("@valorTotal", ivnd.ValorTotal);
                insereCompra.Parameters.AddWithValue("@dataVenda", ivnd.DataVenda);
                insereCompra.Parameters.AddWithValue("@status", 1);
                insereCompra.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
            #endregion
        }










        //+-----------------------+//
        //|       ESPECIFICOS     |//
        //+-----------------------+//

        // PEGARA A QUANTIDADE DE PRODUTOS
        public int BuscarProdutoEspecifico(Model.ProdutoModel prd)
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            try
            {
                SqlCeCommand verifica = new SqlCeCommand("SELECT QUANTIDADE FROM ESTOQUE WHERE idProduto = " + prd.IdProduto + ";", conn);
                conn.Open();
                int quantidade = Convert.ToInt32(verifica.ExecuteScalar());
                conn.Close();
                return quantidade;
            }
            catch
            {
                return 0;
            }
        }

        // IRA ALTERAR A QUANTIDADE DO PRODUTO NO ESTOQUE
        public bool AlterarQuantidadeProduto(Model.ProdutoModel prd)
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            #region [PRODUTOS]
            try
            {
                conn.Open();
                string querySql = "UPDATE ESTOQUE SET quantidade=@quantidade WHERE idProduto = " + prd.IdProduto + ";";
                SqlCeCommand altera = new SqlCeCommand(querySql, conn);
                altera.Parameters.AddWithValue("@quantidade", prd.Quantidade);
                altera.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            #endregion

        }

        // PEGARA O ULTIMO ID DE COMPRA E ADICIONARA +1, E O ID_ITENS_COMPRA RECEBERA ESSE VALOR
        public int BuscaRegistroCompra()
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            try
            {
                SqlCeCommand verifica = new SqlCeCommand("SELECT COALESCE(MAX(idCompra),0) +1 AS PROXIMA_COMPRA FROM COMPRAS;", conn);
                conn.Open();
                int idCompra = Convert.ToInt32(verifica.ExecuteScalar());
                conn.Close();
                return idCompra;
            }
            catch
            {
                return 0;
            }
        }

        // PEGARA O ULTIMO ID DE VENDA E ADICIONARA +1, E O ID_ITENS_VENDA RECEBERA ESSE VALOR
        public int BuscaRegistroVenda()
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            try
            {
                SqlCeCommand verifica = new SqlCeCommand("SELECT COALESCE(MAX(idVenda),0) +1 AS PROXIMA_VENDA FROM VENDAS;", conn);
                conn.Open();
                int idVenda = Convert.ToInt32(verifica.ExecuteScalar());
                conn.Close();
                return idVenda;
            }
            catch
            {
                return 0;
            }
        }





















    }
}