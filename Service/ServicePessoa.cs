using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Repository;
namespace Service
{
   public class ServicePessoa
    {
        private RepositorioPessoa dao = new RepositorioPessoa();

        public void salvar(Pessoa p)
        {
          

                dao.salvar(p);

            
        }
    }
}
