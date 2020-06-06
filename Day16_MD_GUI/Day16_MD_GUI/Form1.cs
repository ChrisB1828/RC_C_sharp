using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Day16_MD_GUI
{
    public partial class Form1 : Form
    {
        private List<Student> listOfStudents = new List<Student>();
        private List<string> listOfStudentsString = new List<string>();
        private List<string> tempList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e) 
        {
            if (String.IsNullOrWhiteSpace(TxtName.Text))
            {
                //nekas nenotiek
            }
            else if (String.IsNullOrWhiteSpace(TxtSurname.Text))
            {
                //nekas nenotiek
            }
            else if ((String.IsNullOrWhiteSpace(TxtCours.Text)))
            {
                //nekas nenotiek
            }
            else
            {
                String name = TxtName.Text;
                String surname = TxtSurname.Text;
                String course = TxtCours.Text;
                int courseInt = Convert.ToInt32(course);
                listOfStudents.Add(new Student(name, surname, courseInt));
                LstStudent.Items.Add($"{name} {surname} {course}");
                String combined = $"{name},{surname},{course}";
                listOfStudentsString.Add(combined);
            }
            ListUpdate();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LstStudent.SelectedItems)
            {
                LstStudent.Items.Remove(item);
            }
            ListUpdate();
        }
        private void BtnReadFile_Click(object sender, EventArgs e)
        {
            LstStudent.Items.Clear();
            listOfStudents.Clear();
            
            ReadFile(listOfStudents);
            foreach (var student in listOfStudents)
            {
                string name = student.getName();
                string surname = student.getSurname();
                int cours = student.getCourse();

                LstStudent.Items.Add($"{name} {surname} {cours}");
            }
            
        }
        private void ListUpdate()
        {     
            listOfStudents.Clear();
            listOfStudentsString.Clear();

            
            foreach (ListViewItem item in LstStudent.Items)
            {
                tempList.Add(item.Text);
            }
            
            foreach (string element in tempList)
            {
                string student = element;
                string[] split = student.Split(' ');
                string name = split[0];
                string surname = split[1];
                string cours = split[2];
                int coursInt = Convert.ToInt32(cours);

                listOfStudents.Add(new Student(name, surname, coursInt));

                string combined = $"{name},{surname},{cours}";
                listOfStudentsString.Add(combined);
            }
            Write(listOfStudentsString);
            tempList.Clear();
        }
        static void Write(List<String> listOfStudentsString, bool tOrF = false)
        {
            StreamWriter sw = new StreamWriter(@"D:\Riga Coding School\RC_C_sharp\Day16_Files\Faili\Student_List.text", tOrF);
            foreach (string student in listOfStudentsString)
            {
                sw.WriteLine(student);
            }
            sw.Close();
        }
        static void ReadFile(List<Student> listOfStudents)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(@"D:\Riga Coding School\RC_C_sharp\Day16_Files\Faili\Student_List.text");
                line = sr.ReadLine();

                while (line != null)
                {
                    string[] split = line.Split(',');
                    string name = split[0];
                    string surname = split[1];
                    int course = Convert.ToInt32(split[2]);

                    Student student = new Student(name, surname, course);

                    listOfStudents.Add(student);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Nav atrasts fails!");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string name = EditName.Text;
            string surname = EditSurname.Text;
            string cours = EditCours.Text;
            LstStudent.SelectedItems[0].Text = $"{name} {surname} {cours}";
            ListUpdate();
        }
    }
}
