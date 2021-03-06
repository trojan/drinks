﻿using System;
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
        // Criara o bd
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

        // Criara as tabelas dentro do bd
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
                 "idNivelAcesso         INT IDENTITY (1,1) CONSTRAINT pkIdNivelAcesso PRIMARY KEY NOT NULL,  " +
                 "descricao             nvarchar(15));",

                 "CREATE TABLE USUARIO( " +
                 "idUsuario         INT IDENTITY (1,1) CONSTRAINT pkIdUsuario PRIMARY KEY NOT NULL,  " +
                 "login             nvarchar(50),  " +
                 "senha             nvarchar(20),  " +
                 "idNivelAcesso     int, " +
                 "status            int, " +
                 "foreign key (idNivelAcesso) references NIVEL_ACESSO (idNivelAcesso));",

                 "CREATE TABLE MARCA( " +
                 "idMarca           INT IDENTITY (1,1) CONSTRAINT pkIdMarca PRIMARY KEY NOT NULL,  " +
                 "descricao         nvarchar(20)," +
                 "status                int);",

                 "CREATE TABLE UNIDADE_MEDIDA( " +
                 "idUnidadeMedida       INT IDENTITY (1,1) CONSTRAINT pkIdUnidadeMedida PRIMARY KEY NOT NULL,  " +
                 "descricao             nvarchar(15)," +
                 "status                int);",

                 "CREATE TABLE TAMANHO( " +
                 "idTamanho             INT IDENTITY (1,1) CONSTRAINT pkIdTamanho PRIMARY KEY NOT NULL,  " +
                 "descricao             nvarchar(15), " +
                 "status                int);",

                 "CREATE TABLE ESTOQUE( " +
                 "idProduto             INT IDENTITY (1,1) CONSTRAINT pkIdProduto PRIMARY KEY NOT NULL,  " +
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
                 "idItensCompras           INT IDENTITY (1,1) CONSTRAINT pkIdItensCompras PRIMARY KEY NOT NULL,  " +
                 "idProduto                int, " +
                 "quantidadeUnitario       int, " +
                 "valorUnitario            decimal(10, 2), " +
                 "foreign key (idProduto) references ESTOQUE (idProduto)); ",

                 "CREATE TABLE COMPRAS ( " +
                 "idCompras             INT IDENTITY (1,1) CONSTRAINT pkIdCompras PRIMARY KEY NOT NULL,  " +
                 "idItensCompras        int, " +
                 "quantidadeTotal       int, " +
                 "valorTotal            decimal(10, 2), " +
                 "dataCompras           datetime," +
                 "status                int, " +
                 "foreign key (idItensCompras) references ITENS_COMPRA (idItensCompras)); ",

                 "CREATE TABLE ITENS_VENDAS ( " +
                 "idItensVendas            INT IDENTITY (1,1) CONSTRAINT pkIdItensVendas PRIMARY KEY NOT NULL,  " +
                 "idProduto                int, " +
                 "quantidadeUnitario       int, " +
                 "valorUnitario            decimal(10, 2), " +
                 "foreign key (idProduto) references ESTOQUE (idProduto)); ",

                 "CREATE TABLE VENDAS ( " +
                 "idVendas              INT IDENTITY (1,1) CONSTRAINT pkIdVendas PRIMARY KEY NOT NULL,  " +
                 "idItensVendas         int, " +
                 "quantidadeTotal       int, " +
                 "valorTotal            decimal(10, 2), " +
                 "dataVendas            datetime, " +
                 "status                int, " +
                 "foreign key (idItensVendas) references ITENS_VENDAS (idItensVendas));"
            };

            foreach (string cmmd in comandos)
            {
                SqlCeCommand cmd = new SqlCeCommand(cmmd, conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();

        }

        // verificara se as tabelas foram criadas
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
                SqlCeCommand verify;
                string querySql = "SELECT Count(*) FROM INFORMATION_SCHEMA.TABLES";
                verify = new SqlCeCommand(querySql, conn);
                verify.ExecuteNonQuery();
                int num = Convert.ToInt32(verify.ExecuteScalar());
                conn.Close();
                return num;
            }
            catch
            {
                return 0;
            }

        }



        //+------------------+//
        //|       CRUD       |//
        //+------------------+//


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
            else if (und != null)   // INSERIR OS DADOS NA TABELA UNIDADE_MEDIDA
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
            else if (tmh != null)   // INSERIR OS DADOS NA TABELA TAMANHO
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
                    string querySql = "UPDATE ESTOQUE SET idMarca=@idMarca, descricao=@descricaoProduto, idUnidadeMedida=@idUnidadeMedida, idTamanho=@idTamanho, valorUnitario=@valorUnitario WHERE idProduto = " + prd.IdProduto + ";";
                    SqlCeCommand altera = new SqlCeCommand(querySql, conn);
                    altera.Parameters.AddWithValue("@idMarca", prd.IdMarca);
                    altera.Parameters.AddWithValue("@descricaoProduto", prd.DescricaoProduto);
                    altera.Parameters.AddWithValue("@idUnidadeMedida", prd.IdUnidadeMedida);
                    altera.Parameters.AddWithValue("@idTamanho", prd.IdTamanho);
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
                        string querySql = "SELECT idProduto AS CODIGO, MARCA.descricao AS MARCA, ESTOQUE.descricao AS PRODUTO, TAMANHO.descricao AS TAMANHO, UNIDADE_MEDIDA.descricao AS UNIDADE_MEDIDA, quantidade AS QUANTIDADE, valorUnitario AS VALOR_UNITARIO, quantidade*valorUnitario AS VALOR_TOTAL_UNITARIO FROM ESTOQUE INNER JOIN MARCA ON (ESTOQUE.idMarca = MARCA.idMarca) INNER JOIN UNIDADE_MEDIDA ON (ESTOQUE.idUnidadeMedida = UNIDADE_MEDIDA.idUnidadeMedida) INNER JOIN TAMANHO ON (ESTOQUE.idTamanho = TAMANHO.idTamanho) WHERE ESTOQUE.status = 1 ORDER BY PRODUTO;";
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

    }
}