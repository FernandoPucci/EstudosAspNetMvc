using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TesteAdoNetRest.Factory;
using TesteAdoNetRest.Models;

namespace TesteAdoNetRest.Dal
{
    public class ProdutoDal
    {

        public Produto GetProdutoById(long Id)
        {

            OracleConnection conn = ConnectionFactory.GetConnection();
            Produto produto = null;

            using (conn)
            {
                try
                {

                    conn.Open();

                    OracleCommand command = new OracleCommand("SELECT ID_PRODUTO, DESCRICAO, VLR_UNIT FROM PRODUTO WHERE ID_PRODUTO = :id", conn);

                    command.Parameters.Add("@id", Id);

                    OracleDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            produto = new Produto();

                            produto.IdProduto = reader.GetInt64(0);
                            produto.Descricao = reader.GetString(1);
                            produto.ValorUnitario = reader.GetDouble(2);

                        }
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    throw ex;

                }

            }

            return produto;

        }


        public List<Produto> GetProdutos()
        {

            OracleConnection conn = ConnectionFactory.GetConnection();
            Produto produto = null;

            List<Produto> listaSaida = null;

            using (conn)
            {
                try
                {

                    conn.Open();

                    OracleCommand command = new OracleCommand("SELECT ID_PRODUTO, DESCRICAO, VLR_UNIT FROM PRODUTO ", conn);

                    OracleDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (listaSaida == null)
                            {

                                listaSaida = new List<Produto>();

                            }

                            produto = new Produto();

                            produto.IdProduto = reader.GetInt64(0);
                            produto.Descricao = reader.GetString(1);
                            produto.ValorUnitario = reader.GetDouble(2);

                            listaSaida.Add(produto);
                        }
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    throw ex;

                }

            }

            return listaSaida;

        }

    }
}