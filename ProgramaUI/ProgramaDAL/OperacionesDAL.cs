using ProgramaUtilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaDAL
{
    public class OperacionesDAL
    {

        private DataTable dt;
        private SqlConnection con;

        public SqlConnection Conectar(ProgramaVO programaVO)
        {
            try
            {
                con = new SqlConnection(programaVO.Cadena);
                con.Open();
                MessageBox.Show("Conectado a la base de datos");
            }
            catch
            {
                MessageBox.Show("La conexión a la base de datos no se ha podido realizar");
            }

            return con;
        }
        public DataTable CrearDataTable(SqlDataAdapter da)
        {
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
