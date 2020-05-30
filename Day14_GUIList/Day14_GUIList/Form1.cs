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
        private List<String> OldList;
        public Form1()
        {
            InitializeComponent();
            OldList = new List<string>();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            ToStringList();
            if (String.IsNullOrWhiteSpace(FieldInput.Text))
            {
                //nekas nenotiek
            }
            else if(!IsDuplicate())
            {
                LstTest.Items.Add(FieldInput.Text);
            }
            else
            {
                //nekas nenotiek
            }

        }

        private void button2_Click(object sender, EventArgs e) // button delete
        {
            ToStringList();
            foreach (ListViewItem item in LstTest.SelectedItems)
            {
                LstTest.Items.Remove(item);
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            ToStringList();
            if (!IsDuplicate())
            {
                LstTest.SelectedItems[0].Text = FieldInput.Text;
            }

        }

        private bool CheckForDuplicates(String element)
        {
            LstTest.SelectedItems[0].Text = FieldInput.Text;

            return false;
        }

        private bool IsDuplicate()
        {
            foreach(ListViewItem item in LstTest.Items)
            {
                if (FieldInput.Text == item.Text)
                {

                    return true;
                }
            }
            return false;
        }

        private void ToStringList()
        {
            OldList.Clear();
            foreach (ListViewItem item in LstTest.Items)
            {
                OldList.Add(item.Text);
            }
        }
        private void ToListView()
        {
            LstTest.Items.Clear();
            foreach (String element in OldList)
            {
                LstTest.Items.Add(element);
            }
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            ToListView();
        }
    }
}
