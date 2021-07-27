using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UserControl1 userControl1 = new UserControl1();
        private void button1_Click(object sender, EventArgs e)
        {
            userControl1.Location = new Point(200, 0);
            this.Controls.Add(userControl1);
            this.Controls.Remove(userControl2);
        }

        UserControl2 userControl2 = new UserControl2();
        private void button2_Click(object sender, EventArgs e)
        {
            userControl2.Location = new Point(200, 0);
            this.Controls.Remove(userControl1);
            this.Controls.Add(userControl2);
        }
    }
}
