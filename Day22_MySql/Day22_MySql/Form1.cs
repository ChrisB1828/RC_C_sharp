using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day22_MySql
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnShowEmployees_Click(object sender, EventArgs e)
        {
            
           
            DBConnection con = new DBConnection();
            con.GetEmployees();
        }
    }
}
