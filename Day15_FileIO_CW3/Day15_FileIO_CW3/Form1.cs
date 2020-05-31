using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day15_FileIO_CW3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void Read(String fileName, List<String> lst)
        {
            String line;
            try
            {
                
                StreamReader sr = new StreamReader($@"D:\Riga Coding School\Day15_FileIO\ClassWork2\{fileName}.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    lst.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                
            }
            catch (Exception)
            {

                Console.WriteLine("Nav atrasts fails!");
            }
        }

        private void BtnText1_Click(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            Read("Test", lst);

            BoxForText.Text = File.ReadAllText($@"D:\Riga Coding School\Day15_FileIO\ClassWork2\Test.txt");

        }

        private void BtnText2_Click(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            Read("Test_new", lst);

            BoxForText.Text = File.ReadAllText($@"D:\Riga Coding School\Day15_FileIO\ClassWork2\Test_new.txt");
        }
    }
}
