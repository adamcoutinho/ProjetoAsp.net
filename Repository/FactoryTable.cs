using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Repository
{
   public  class FactoryTable
    {
        private static DataTable dataTable = new DataTable();
        private static DataSet dataSet = new DataSet();
        public static DataTable getDataSource(SqlCommand cmd)
        {
            cmd.Connection = FactoryManager.getConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
