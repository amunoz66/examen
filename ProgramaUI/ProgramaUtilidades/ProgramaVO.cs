using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaUtilidades
{
    public class ProgramaVO
    {
        private string cadena;

        public ProgramaVO(string cadena)
        {
            this.Cadena = cadena;
        }

        public string Cadena { get => cadena; set => cadena = value; }
    }
}
