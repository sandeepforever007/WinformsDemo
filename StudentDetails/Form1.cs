using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDetails
{
	public partial class Form1 : Form
	{
		List<Student> studentDetails = new List<Student>();
		
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Student students = new Student
			{
				FirstName = textBox1.Text,
				LastName = textBox2.Text,
				City = textBox3.Text,
				Phone = Convert.ToDouble(textBox4.Text)
			};
			studentDetails.Add(students);
			//List<Student> studentDetails = new List<Student>
			//{
			//	new Student() {FirstName = textBox1.Text, LastName = textBox2.Text, City = textBox3.Text, Phone =Convert.ToDouble(textBox4.Text) }
			//};
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = studentDetails;
			
		}
	}
}
