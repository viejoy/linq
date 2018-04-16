using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace BSCSActivity
{
    public partial class Form1 : Form
    {
        private static IList getRecords;
        private static List<tcours> getListCourses;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getRecords = getStudents();
            
            getListCourses = getCourse();
            comboBox1.DataSource = getListCourses;
            comboBox1.DisplayMember = "COURSE_NAME";
            comboBox1.ValueMember = "COURSE_ID";
            listnotFound();

        }

        void listFound()
        {
            var getrecords = (from c in ContextObject.context.tstudents.OfType<tstudent>()              
                              where c.LAST_NAME == textBox4.Text ||
                              c.FIRST_NAME == textBox4.Text ||
                               c.ADDRESS == textBox4.Text ||
                              c.LAST_NAME.Contains(textBox4.Text) ||
                              c.FIRST_NAME.Contains(textBox4.Text) ||
                              c.ADDRESS.Contains(textBox4.Text)
                              select c).ToList();

            dataGridView1.DataSource = getrecords;
        }
        
        List<tcours> getCourse()
        {
            var getrecords = (from c in ContextObject.context.tcourses.OfType<tcours>() select c).ToList();
            return getrecords;
        }
       
        private static IList getStudents()
        {
            var getrecords = (from c in ContextObject.context.tstudents.OfType<tstudent>() 
                              select new {
                                  c.STUDENT_ID,
                                  c.FIRST_NAME,
                                  c.LAST_NAME,
                                  c.ADDRESS,
                                  c.tcour.COURSE_NAME
                               }).ToList();
            return getrecords;
        }

        void listnotFound()
        {
            dataGridView1.DataSource = getStudents();
        }

        public static int cellSelected;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellSelected = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var getrecords = (from c in ContextObject.context.tstudents.OfType<tstudent>()
                              where c.STUDENT_ID == cellSelected
                              select c).First();
            textBox2.Text = getrecords.FIRST_NAME;
            textBox1.Text = getrecords.LAST_NAME;
            textBox3.Text = getrecords.ADDRESS;
            comboBox1.Text = getrecords.tcour.COURSE_NAME;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tstudent studentsAdd = new tstudent();
            studentsAdd.FIRST_NAME = textBox2.Text;
            studentsAdd.LAST_NAME = textBox1.Text;
            studentsAdd.ADDRESS = textBox3.Text;
            studentsAdd.tcour = getListCourses[Convert.ToInt32(combovalue)-1] as tcours;
            ContextObject.context.AddTotstudents(studentsAdd);
            ContextObject.context.SaveChanges();
            listnotFound();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContextObject.context.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var getrecords = (from c in ContextObject.context.tstudents.OfType<tstudent>()
                              where c.STUDENT_ID == cellSelected
                              select c).First();
            getrecords.FIRST_NAME = textBox2.Text;
            getrecords.LAST_NAME = textBox1.Text;
            getrecords.ADDRESS = textBox3.Text;
            getrecords.tcour = getListCourses[Convert.ToInt32(combovalue) - 1] as tcours;
            ContextObject.context.SaveChanges();
            listnotFound();
            
        }
        
        private static String combovalue;
        
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            combovalue =comboBox1.SelectedValue.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var getrecords = (from c in ContextObject.context.tstudents.OfType<tstudent>()
                              where c.STUDENT_ID == cellSelected
                              select c).First();
            ContextObject.context.DeleteObject(getrecords);
            ContextObject.context.SaveChanges();
            listnotFound();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.TextLength > 0)
            {
                listFound();
            }
            else
            {
                listnotFound();
            }
        }
       

      
    }
}
