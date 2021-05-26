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
    public partial class UCGrafica : UserControl
    {
        public UCGrafica(DataTable dt)
        {
            InitializeComponent();
            chart2.DataSource = dt;
            chart2.DataBindTable(dt.DefaultView, "EmployeeID");
            //chart2.Series["seriesName"].XValueMember = "EmployeeID";
            //chart2.Series["seriesName"].YValueMembers = "total";
            chart2.DataBind();
        }
    }
}
