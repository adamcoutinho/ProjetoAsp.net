using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
 public   class SessionFactory
    {
        public static void getSql(SqlCommand cmd,String sql)
        {
            cmd.Connection = FactoryManager.getConnection();
            // permite receber string
            cmd.CommandType = CommandType.Text;
            // comando para receber string sql
            cmd.CommandText = sql;
            // responsavel pela transação
            cmd.Connection.Open();// inicia transação
            int i = cmd.ExecuteNonQuery();
            cmd.Connection.Close();// fecha transação        
        }
    }
}
