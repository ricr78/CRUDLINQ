using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDLINQ
{
    public partial class TablaDept : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                CargarTabla();
        }
        private void CargarTabla()
        {
            MuestraDataContext dbContext = new MuestraDataContext();
            
            gvDepart.DataSource = dbContext.Departamentos;
            gvDepart.DataBind();
            
        }
        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("TablaDept.aspx");
        }
    }
}