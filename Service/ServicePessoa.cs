using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Repository;
using System.Data;

namespace Service
{
   public class ServicePessoa
    {
        private RepositorioPessoa dao = new RepositorioPessoa();

        public void salvar(Pessoa p)
        {          
                dao.salvar(p);            
        }
        public DataTable getListarTodos()
        {
            return dao.getConsultarTodos();
        }
        public void deletar(Pessoa p)
        {
            dao.deletar(p);
        }
        public Pessoa getPessoa(int id)
        {
            return dao.findById(id);
        }
    }
}
