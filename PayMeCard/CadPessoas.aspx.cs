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
            showTable();
        }

        public void showTable()
        {
            this.GridViewPessoa.DataSource = this.crudPessoa.getListarTodos();
            this.GridViewPessoa.DataBind();
        }

        protected void btSalvar_Click(object sender, EventArgs e)
        {
            this.pessoa = new Pessoa();
            this.pessoa.nome = txtName.Text;
            this.pessoa.idade = Convert.ToInt16(txtIdade.Text);
            this.pessoa.dataNascimento = Convert.ToDateTime(txtDate.SelectedDate);
            this.crudPessoa.salvar(pessoa);
            showTable();
        }

        protected void btnDate_Click(object sender, EventArgs e)
        {
            this.txtDate.Visible = true;
        }

        protected void txtDate_SelectionChanged(object sender, EventArgs e)
        {
            this.txtValueDate.Text = txtDate.SelectedDate.ToString();
            this.txtDate.Visible = false;
        }

        protected void GridViewPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pessoa = new Pessoa();
            GridViewRow row = this.GridViewPessoa.SelectedRow;
            this.pessoa = this.crudPessoa.getPessoa(int.Parse(row.Cells[1].Text));           
            this.crudPessoa.deletar(this.pessoa);
            showTable();            
        }


    }
}