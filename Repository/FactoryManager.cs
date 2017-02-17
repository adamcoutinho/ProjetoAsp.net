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
        public static SqlConnection getConnection()
        {            
            SqlConnection dataConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["PAYME"].ToString());                                                       
            return dataConnection;

        }
      

    }
}
