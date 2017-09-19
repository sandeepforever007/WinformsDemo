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
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			List<Student> studentDetails = new List<Student>
			{
				new Student() {FirstName = textBox1.Text, LastName = textBox2.Text, City = textBox3.Text, Phone =Convert.ToDouble(textBox4.Text) }
			};
			dataGridView1.DataSource = studentDetails;
		}
	}
}
