using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service;

namespace PayMeCard
{
    public partial class CadPessoas : System.Web.UI.Page
    {
        private ServicePessoa crudPessoa = new Service.ServicePessoa();
        private Pessoa pessoa;
      
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
       public void consult()
        {
            //StringBuilder sql = new StringBuilder();
            //sql.Append("SELECT * FROM PESSOAS ;");
            //SqlCommand cmd = new SqlCommand(sql.ToString(), FactoryManager.getConnection());
            //cmd.Connection.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{

            //    Console.Write(reader["nome"].ToString());
            //}
            //reader.Close();
            //cmd.Connection.Close();
        }

        protected void btSalvar_Click(object sender, EventArgs e)
        {
            this.pessoa = new Pessoa();
            this.pessoa.nome = txtName.Text;
            this.pessoa.idade = Convert.ToInt16(txtIdade.Text);
            this.pessoa.dataNascimento = Convert.ToDateTime(txtDate.SelectedDate);
            this.crudPessoa.salvar(pessoa);
            
        }
    }
}