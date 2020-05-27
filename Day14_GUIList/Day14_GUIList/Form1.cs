using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Day14_GUIList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(FieldInput.Text))
            {
                //nekas nenotiek
            }
            else
            {
                LstTest.Items.Add(FieldInput.Text);
            }
            
        }

        private void button2_Click(object sender, EventArgs e) // button delete
        {
            foreach (ListViewItem item in LstTest.SelectedItems)
            {
                LstTest.Items.Remove(item);
            }
        }

        private void FieldInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LstTest.SelectedItems)
            {
                item.Text = FieldInput.Text;
            }
        }
    }
}
