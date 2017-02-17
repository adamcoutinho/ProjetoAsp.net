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

        SqlCommand cmd = new SqlCommand();
        public void salvar(Pessoa p)
        {
           

            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO PESSOAS (nome,idade,dataNascimento) values ");
            sql.Append(" ( @nome,@idade,@dataNascimento );");
                                         
            cmd.Parameters.Add(new SqlParameter("@nome", p.nome));
            cmd.Parameters.Add(new SqlParameter("@idade", p.idade));
            cmd.Parameters.Add(new SqlParameter("@dataNascimento", p.dataNascimento));
            SessionFactory.getSql(cmd, sql.ToString());
        }
        public void atualizar(Pessoa p)
        {
            
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE PESSOAS SET IDADE=@IDADE, NOME= @NOME,DATANASCIMENTO=@DATANASC ");
            sql.Append(" WHERE ID = @ID_UPDATE");           
            cmd.Parameters.Add(new SqlParameter("@IDADE", p.idade));
            cmd.Parameters.Add(new SqlParameter("@NOME", p.nome));
            cmd.Parameters.Add(new SqlParameter("@DATANASC", p.dataNascimento));
            cmd.Parameters.Add(new SqlParameter("@ID_UPDATE", p.id));
            cmd.Connection = FactoryManager.getConnection();
            // responsavel pela transação
            cmd.Connection.Open();
            int i = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        
        public void deletar(Pessoa p)
        {

            String sql = "DELETE FROM PESSOAS WHERE ID = @ID ;";
            cmd.Parameters.Add(new SqlParameter("@ID", p.id));
            SessionFactory.getSql(cmd, sql);
        }
        public Pessoa findById(int id)
        {

            String sql = "SELECT * FROM PESSOAS where ID = @ID_PESSOA ;";            
            cmd.Connection = FactoryManager.getConnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@ID_PESSOA", id));
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            
            Pessoa p = null;
            while (reader.Read())
            {
                p = new Pessoa();
                atribuiValores(p,reader);
            }
            return p;
        }
        public DataTable getConsultarTodos()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from PESSOAS");
            cmd.CommandText = sql.ToString();
            return FactoryTable.getDataSource(cmd);
        }
        private void atribuiValores(Pessoa p,SqlDataReader reader)
        {
            p.id = int.Parse(reader["id"].ToString());
            p.nome = reader["nome"].ToString();
            p.dataNascimento = DateTime.Parse(reader["dataNascimento"].ToString());
        }
    }
}
