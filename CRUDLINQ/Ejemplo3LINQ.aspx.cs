using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.Linq;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.Services.Description;

namespace CRUDLINQ
{
    public partial class Ejemplo3LINQ : System.Web.UI.Page
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Muestra2ConnectionString"].ConnectionString);
        public static string sID = "-1";
        public static string sOpc = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    sID = Request.QueryString["id"].ToString();
                    Obtener();

                }
                if (Request.QueryString["op"] != null)
                {
                    sOpc = Request.QueryString["op"].ToString();
                    switch (sOpc)
                    {
                        case "C":
                            this.lblTitulo.Text = "Ingresar nuevo usuario";
                            this.btnCrear.Visible = true;
                            break;
                        case "R":
                            this.lblTitulo.Text = "Consulta de Usuario";
                            break;
                        case "U":
                            this.lblTitulo.Text = "Actualizar usuario";
                            this.btnActualizar.Visible = true;
                            break;
                        case "D":
                            this.lblTitulo.Text = "Eliminar usuario";
                            this.btnEliminar.Visible = true;
                            break;
                    }
                }
            }

        }

        private void  Obtener()
        {

            MuestraDataContext dbContext = new MuestraDataContext();

            SqlDataAdapter da = new SqlDataAdapter("sp_leer", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value=sID;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if(ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if(dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    txtNombre.Text = dr[1].ToString();
                    txtApellido.Text = dr[2].ToString();
                    txtGenero.Text = dr[3].ToString();
                    txtSalario.Text = dr[4].ToString();
                    DDLIdDept.Text = dr[5].ToString();
                }
                else
                {
                    Console.WriteLine("xd");
                }
            }
            
            
            
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            Obtener();

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using(MuestraDataContext dbContext = new MuestraDataContext())
            {
                SqlCommand cmd = new SqlCommand("sp_eliminarE",con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = sID;
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("default.aspx");
            }
            
            
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            using(MuestraDataContext dbContext = new MuestraDataContext())
            {
                SqlCommand cmd = new SqlCommand("sp_crearE",con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Nombre",SqlDbType.VarChar).Value = txtNombre.Text;
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = txtApellido.Text;
                cmd.Parameters.Add("@Genero", SqlDbType.VarChar).Value = txtGenero.Text;
                cmd.Parameters.Add("@Salario", SqlDbType.Money).Value = txtSalario.Text;
                cmd.Parameters.Add("@idDept", SqlDbType.Int).Value = DDLIdDept.Text;
                cmd.ExecuteNonQuery();
                Response.Redirect("default.aspx");
                con.Close();
            }

            Obtener();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            using (MuestraDataContext dbContext = new MuestraDataContext())
            {
                SqlCommand cmd = new SqlCommand("sp_actualizarE",con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = sID;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtNombre.Text;
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = txtApellido.Text;
                cmd.Parameters.Add("@Genero", SqlDbType.VarChar).Value = txtGenero.Text;
                cmd.Parameters.Add("@Salario", SqlDbType.Money).Value = txtSalario.Text;
                cmd.Parameters.Add("@idDept", SqlDbType.Int).Value = DDLIdDept.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("default.aspx");
            }

            Obtener();

        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        
    }
}