using ProgramaBLL;
using ProgramaUtilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaUI
{
    public partial class Form1 : Form
    {
        private SqlDataAdapter da;
        private DataTable dt;
        private SqlConnection con;
        private DataGridView dgv;
        private TableLayoutPanel tlp;
        private UCTabla tablaUC;
        private UCGrafica graficaUC;
        private string consulta;
        private string cadena;
        public Form1()
        {
            InitializeComponent();
            cadena = "Data Source =server16; Initial Catalog =Northwind; Persist Security Info = True; User ID =am; Password = 666666";
            tlp = tlp0;

            ProgramaVO programaVO = new ProgramaVO(cadena);
            //crea la conexion en el DAL a través de BLL
            OperacionesBLL opBLL = new OperacionesBLL();
            con = opBLL.CrearConexion(programaVO);
            // Crea un datatable en el DAL a través del BLL
            //consulta = "SELECT * FROM Northwind.dbo.Orders";
            consulta = "SELECT EmployeeID, SUM(Freight) as total FROM Northwind.dbo.Orders GROUP BY EmployeeID ORDER BY EmployeeID";
            da = new SqlDataAdapter(consulta,con);
            dt = opBLL.CrearDataTable(da);
            //Pasamos el datatable al DataGridView
            dgv = new DataGridView();
            //tablaUC.dgv.DataSource = dt;
            tablaUC = new UCTabla(dt);
            //tlp.Controls.Add(tablaUC, 0, 1);
            graficaUC = new UCGrafica(dt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            tlp.Controls.Add(tablaUC, 0, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tlp.Controls.Add(graficaUC, 1, 1);
        }
    }
}
