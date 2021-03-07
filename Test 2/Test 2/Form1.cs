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

namespace Test_2
{

    public partial class Form1 : Form
    {
        string path = @"../../ShowUser.txt";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {
            
        }

        private void Nmae1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string radio1 = "";
            string radio2 = "";
            string name = txtNmae.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string id = txtID.Text;
            string password = txtPassword.Text;
           


            //groupBox1
            if (radioButtonStodent.Checked)
            {
                radio1 = radioButtonStodent.Text;
            }
            if (radioButtonTeacher.Checked)
            {
                radio1 = radioButtonTeacher.Text;
            }
            //radiobuttenCourse
            if (btnC.Checked)
            {
                radio2 = btnC.Text;
            }
            if (btnF.Checked)
            {
                radio2 = btnC.Text;
            }
            if (btnR.Checked)
            {
                radio2 = btnF.Text;
            }
            if (btnJ.Checked)
            {
                radio2 = btnJ.Text;
            }
           

            Student s1 = new Student(dateOfRegister.Value,txtNmae.Text,txtLastName.Text,txtEmail.Text,txtID.Text,txtPassword.Text,radio1,radio2);

            File.AppendAllText(@"../../ShowUser.txt", s1.ToString());
            MessageBox.Show("Succeeded");
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            this.Hide();//החבאת החלון הראשון
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText(path);//פתיחת אובייקט לקריאת הקובץ טקסט
            string radio3 = "";
            string radio4 = "";
            //groupBox1
            if (radioButtonStodent.Checked)
            {
                radio3 = radioButtonStodent.Text;
            }
            if (radioButtonTeacher.Checked)
            {
                radio3 = radioButtonTeacher.Text;
            }
            //radiobuttenCourse
            if (btnC.Checked)
            {
                radio4 = btnC.Text;
            }
            if (btnF.Checked)
            {
                radio4 = btnC.Text;
            }
            if (btnR.Checked)
            {
                radio4 = btnF.Text;
            }
            if (btnJ.Checked)
            {
                radio4 = btnJ.Text;
            }

            string Line;
            string Users = "";


            while ((Line = sr.ReadLine()) != null)//ברגע שהגעת לנל הקובץ ניגמר
            {
                if (!Line.Contains(textBox1.Text))
                {
                    Users += Line + Environment.NewLine;//יצירה שורה חדשה אבל לא ריקה
                }

                else
                {
                    Line = "Name:" + txtNmae.Text + "   " + "Last Name:" + txtLastName.Text + "   " + "Registration Date" + dateOfRegister.Value + "   " + "Email:" + txtEmail.Text + "   " + "Password" + txtPassword.Text + "   " + "ID:" + txtID.Text + "   " + "Profession:" + radio3 + "   " + "specitlty:" + radio4 + "\n" + "\n\n\n";
                    Users += Line + Environment.NewLine;
                    Line = sr.ReadLine();
                }

            }

            sr.Close();
            File.WriteAllText(path,Users);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText(path);
            string Line = "";
            string users = "";

            while ((Line = sr.ReadLine()) != null)
            {
                if (!Line.Contains(textBox1.Text))
                {
                    users += Line + Environment.NewLine;//יצירה שורה חדשה אבל לא ריקה
                }

                else
                {
                    Line = sr.ReadLine();
                }

            }

            sr.Close();
            File.WriteAllText(path, users);
        }
    }
}
