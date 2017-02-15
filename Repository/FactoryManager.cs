using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace Repository
{
    public class FactoryManager
    {
        public SqlCommand dataCommand = new SqlCommand();
        private string retorno = string.Empty;

        public SqlTransaction transaction = null;
        public SqlConnection connection = null;
        public SqlCommand commandSql = null;
        //public static string connectionString = "Persist Security Info=False;User ID=SA;Initial Catalog=CADASTRO;Data Source=LAPTOP-RJLV96Q0;Database=PAYME";
        public static string _database;
        


        //FactoryManager()
        //{
        //    SqlConnection dataConnection = new SqlConnection();

        //    dataCommand.Connection = dataConnection;
        //    dataCommand.CommandType = CommandType.Text;
        //}
        public static SqlConnection getConnection()
        {
            
            SqlConnection dataConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["PAYME"].ToString());
            //dataConnection.ConnectionString = _database;                                              
            return dataConnection;

        }
      

    }
}
