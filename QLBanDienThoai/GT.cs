using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanDienThoai
{
    public partial class GT : Form
    {
        public GT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         Main a= new Main();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
