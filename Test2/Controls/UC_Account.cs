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
    public partial class UC_Account : UserControl
    {
        public UC_Account()
        {
            InitializeComponent();
        }

        private void UC_Account_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridView1.Rows.Add(new object[] { 1, "Nội Thất", "Thú Cưng", "Xây Dựng", "Pet", "Táo", "1000/1000","Login/Out" });
        }
    }
}
