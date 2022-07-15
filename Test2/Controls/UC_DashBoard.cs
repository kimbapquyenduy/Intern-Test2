using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2.Controls
{
    public partial class UC_DashBoard : UserControl
    {
        public UC_DashBoard()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_DashBoard_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridView1.Rows.Add(new object[] {1,"Cam","Xoài","Ổi","1000/1000","Táo","Run/Stop" });
           
        }
    }
}
