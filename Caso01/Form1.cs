using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace Caso01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Caso01"].ConnectionString);

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaEmpleados();
        }

        public void ListaPedidos()
        {
            using (SqlDataAdapter df = new SqlDataAdapter("Usp_Listado_Pedidos", cn))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;

                using (DataSet Da = new DataSet())
                {
                    df.Fill(Da, "Ped");
                    DgPedidos.DataSource = Da.Tables["Ped"];
                    LblTotalPedidos.Text = Da.Tables["Ped"].Rows.Count.ToString();
                }
            }
        }

        public void ListaEmpleados()
        {
            using (SqlCommand cmd = new SqlCommand("Usp_Nombre_Apellidos_Empleado", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataTable df = new DataTable();
                    
                    da.Fill(df);
                    CboEmpleado.DataSource = df;
                    CboEmpleado.DisplayMember = "Empleado";
                    CboEmpleado.ValueMember = "Empleado";
                }
            }
        }

        private void CboEmpleado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Usp_Listado_Pedidos", cn))
            {
                using (SqlDataAdapter Da = new SqlDataAdapter())
                {
                    Da.SelectCommand = cmd;
                    Da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Da.SelectCommand.Parameters.AddWithValue("@apellidoNombre", CboEmpleado.SelectedValue);

                    using (DataSet df = new DataSet())
                    {
                        Da.Fill(df, "Completo");

                        DgPedidos.DataSource = df.Tables["Completo"];
                        LblTotalPedidos.Text = df.Tables["Completo"].Rows.Count.ToString();
                    }
                }
            }
        }
    }
}
