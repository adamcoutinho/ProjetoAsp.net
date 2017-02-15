using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace Repository
{
    public class RepositorioPessoa
    {        

        public void salvar(Pessoa p)
        {
            SqlCommand cmd = new SqlCommand();

            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO PESSOAS (nome,idade,dataNascimento) values ");
            sql.Append(" ( @nome,@idade,@dataNascimento );");
            //inicializa a leitura do strinbuilder
            cmd.CommandType = CommandType.Text;
            //recebendo a sql do strinbuilder para o metodo CommandText
            cmd.CommandText = sql.ToString();
            cmd.Connection = FactoryManager.getConnection();           
            cmd.Parameters.Add(new SqlParameter("@nome", p.nome));
            cmd.Parameters.Add(new SqlParameter("@idade", p.idade));
            cmd.Parameters.Add(new SqlParameter("@dataNascimento", p.dataNascimento));            
            // responsavel pela transação
            cmd.Connection.Open();
            int i = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        public void atualizar(Pessoa p)
        {
            SqlCommand cmd = new SqlCommand();
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO PESSOA ");
            sql.Append(" ( ?,?,?,? )");

            cmd.Connection = FactoryManager.getConnection();

            cmd.Parameters.Add(new SqlParameter("@nome", p.nome));
            cmd.Parameters.Add(new SqlParameter("@idade", p.idade));

            // responsavel pela transação
            cmd.Connection.Open();
            int i = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        
        public void deletar(Pessoa p)
        {
            SqlCommand cmd = new SqlCommand();

            StringBuilder sql = new StringBuilder();
            

            cmd.Connection = FactoryManager.getConnection();


            // responsavel pela transação
            cmd.Connection.Open();
            int i = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public Pessoa findById(int id)
        {
            StringBuilder sql = new StringBuilder();

            SqlCommand cmd = new SqlCommand(sql.ToString(), FactoryManager.getConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            Pessoa p = null;
            while (reader.Read())
            {
                p = new Pessoa();
                atribuiValores(p,reader);
            }
            return p;
        }

        private void atribuiValores(Pessoa p,SqlDataReader reader)
        {
            p.nome = reader["@nome"].ToString();
            
        }
    }
}
