using ProgramaDAL;
using ProgramaUtilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaBLL
{
    public class OperacionesBLL
   {

        private SqlConnection conexion;
        private DataTable dt;

        public SqlConnection CrearConexion(ProgramaVO programaVO) 
        {
            OperacionesDAL opDAL = new OperacionesDAL();
            conexion = opDAL.Conectar(programaVO);
            return conexion;
        }

        public DataTable CrearDataTable(SqlDataAdapter da)
        {
            OperacionesDAL opDAL = new OperacionesDAL();
            dt = opDAL.CrearDataTable(da);
            return dt;
        }

    }
}
