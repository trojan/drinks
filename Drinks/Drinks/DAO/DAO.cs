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
        //public string base_dados = "drinks.sdf";

        // Create database
        public void CreateDB()
        {
            // Create database folder
            string folder = "bd";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            //  Create database file (*.sdf)
            if (!File.Exists(@"bd\drinks.sdf"))
            {
                string path = @"Data Source = bd\drinks.sdf";
                SqlCeEngine engine = new SqlCeEngine(path);
                engine.CreateDatabase();
                engine.Dispose();
            }
        }

        // Create table
        public void CreateTB()
        {
            string connStr = @"Data Source = bd\drinks.sdf";
            SqlCeConnection conn = new SqlCeConnection(connStr);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            //List<string> comandos = new List<string>();
            string[] comandos = {
                "CREATE TABLE NIVEL_ACESSO(" +
                 "idNivelAcesso         INT IDENTITY (1,1) CONSTRAINT pkIdNivelAcesso PRIMARY KEY NOT NULL,  " +
                 "descricao             nvarchar(15));",

                 "CREATE TABLE USUARIO( " +
                 "idUsuario         INT IDENTITY (1,1) CONSTRAINT pkIdUsuario PRIMARY KEY NOT NULL,  " +
                 "login             nvarchar(50),  " +
                 "senha             nvarchar(20),  " +
                 "idNivelAcesso     int, " +
                 "foreign key (idNivelAcesso) references NIVEL_ACESSO (idNivelAcesso));",

                 "CREATE TABLE MARCA( " +
                 "idMarca            INT IDENTITY (1,1) CONSTRAINT pkIdMarca PRIMARY KEY NOT NULL,  " +
                 "descricao          nvarchar(20)); ",

                 "CREATE TABLE UNIDADE_MEDIDA( " +
                 "idUnidadeMedida        INT IDENTITY (1,1) CONSTRAINT pkIdUnidadeMedida PRIMARY KEY NOT NULL,  " +
                 "descricao              nvarchar(15)); ",

                 "CREATE TABLE TAMANHO( " +
                 "idTamanho             INT IDENTITY (1,1) CONSTRAINT pkIdTamanho PRIMARY KEY NOT NULL,  " +
                 "descricao             nvarchar(15)); ",

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
                 "dataCompra datetime," +
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
                 "dataVenda             datetime, " +
                 "foreign key (idItensVendas) references ITENS_VENDAS (idItensVendas));"
            };

            foreach (string cmmd in comandos)
            {
                SqlCeCommand cmd = new SqlCeCommand(cmmd, conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();

        }

        // Check for table existence
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

    }
}
