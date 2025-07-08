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
    public partial class _default : System.Web.UI.Page
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Muestra2ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla();
                
            }
            
        }

        void BuscarRegistro(string criterio) 
        {
            SqlCommand cmd = new SqlCommand("sp_buscarE", con); 
            cmd.CommandType = CommandType.StoredProcedure; 
            cmd.Parameters.AddWithValue("@Criterio", criterio); 
            con.Open(); 
            SqlDataAdapter da = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable(); da.Fill(dt); 
            gvusuarios.DataSource = dt; 
            gvusuarios.DataBind(); 
            con.Close();
        }
        void CargarTabla()
        {
            SqlCommand cmd = new SqlCommand("sp_loadE", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvusuarios.DataSource = dt;
            gvusuarios.DataBind();
            con.Close();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string id;
            Button BtnConsultar = (Button)sender;
            GridViewRow selectedrow = (GridViewRow)BtnConsultar.NamingContainer;
            id = selectedrow.Cells[1].Text;
            Response.Redirect("~/Ejemplo3LINQ.aspx?id=" + id + "&op=D");
        }
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string id;
            Button BtnConsultar = (Button)sender;
            GridViewRow selectedrow = (GridViewRow)BtnConsultar.NamingContainer;
            id = selectedrow.Cells[1].Text;
            Response.Redirect("~/Ejemplo3LINQ.aspx?id=" + id + "&op=U");
        }
        protected void btnRead_Click(object sender, EventArgs e)
        {
            string id;
            Button BtnConsultar = (Button)sender;
            GridViewRow selectedrow = (GridViewRow)BtnConsultar.NamingContainer;
            id = selectedrow.Cells[1].Text;
            Response.Redirect("~/Ejemplo3LINQ.aspx?id=" + id + "&op=R");
        }
        protected void Btncrear_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ejemplo3LINQ.aspx?op=C");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarRegistro(txtBuscar.Text);
        }
    }
    
}