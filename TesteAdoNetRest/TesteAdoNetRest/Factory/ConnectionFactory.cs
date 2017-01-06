using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TesteAdoNetRest.Factory
{
    public class ConnectionFactory
    {
        public static OracleConnection GetConnection()
        {

            string connStr = GetConnectionStringByProvider("Oracle.DataAccess.Client");

            return new OracleConnection() { ConnectionString = connStr };

        }

        // Retrieve a connection string by specifying the providerName.
        // Assumes one connection string per provider in the config file.
        private static string GetConnectionStringByProvider(string providerName)
        {
            // Return null on failure.
            string returnValue = null;

            // Get the collection of connection strings.
            ConnectionStringSettingsCollection settings =
                ConfigurationManager.ConnectionStrings;

            // Walk through the collection and return the first 
            // connection string matching the providerName.
            if (settings != null)
            {

                foreach (ConnectionStringSettings cs in settings)
                {
                    if (cs == null)
                    {
                        continue;
                    }
                    if (cs.ProviderName == providerName)
                    {
                        returnValue = cs.ConnectionString;
                    }
                    else { continue; }
                    break;
                }
            }
            return returnValue;
        }





    }
}