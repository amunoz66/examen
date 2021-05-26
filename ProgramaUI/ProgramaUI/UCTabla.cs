using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaUI
{
    public partial class UCTabla : UserControl
    {

        private DataTable dt;

        public UCTabla(DataTable dt)
        {
            InitializeComponent();
            //dgv = new DataGridView();
            dataGridView1.DataSource = dt;

        }

    }
}
