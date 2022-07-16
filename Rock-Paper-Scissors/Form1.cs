using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		string[] array= {"Rock","Paper", "Scissors"};
		Random r = new Random();
		int random;
		int YouWin = 0;
		int CWin = 0;
	
		private void button1_Click(object sender, EventArgs e)
		{
			random = r.Next(0, 3);
			button1.BackColor = Color.Green;
			if (array[random]=="Rock")
			{
				label3.Text = "Rock";
				MessageBox.Show("draw");
			}
			if (array[random] == "Paper")
			{
				label3.Text = "Paper";
				MessageBox.Show("Computer Win");
				CWin += 1;
				
			}
			if (array[random] == "Scissors")
			{
				label3.Text = "Scissors";
				MessageBox.Show("You Win");
				YouWin += 1;
				
			}
			label7.Text = Convert.ToString(CWin);
			label6.Text = Convert.ToString(YouWin);

		}

		private void button2_Click(object sender, EventArgs e)//kağıt
		{
			random = r.Next(0, 3);
			button2.BackColor = Color.Green;
			if (array[random] == "Rock")
			{
				label3.Text = "Rock";
				MessageBox.Show("You Win");
				YouWin += 1;
			}
			if (array[random] == "Paper")
			{
				label3.Text = "Paper";
				MessageBox.Show("draw");
			}
			if (array[random] == "Scissors")
			{
				label3.Text = "Scissors";
				MessageBox.Show("Computer Win");
				CWin += 1;

			}
			label7.Text = Convert.ToString(CWin);
			label6.Text = Convert.ToString(YouWin);
		}

		private void button3_Click(object sender, EventArgs e)//makas
		{
			random = r.Next(0, 3);
			button3.BackColor = Color.Green;
			if (array[random] == "Rock")
			{
				label3.Text = "Rock";
				MessageBox.Show("You Win");
				YouWin += 1;
			}
			if (array[random] == "Paper")
			{
				label3.Text = "Paper";
				MessageBox.Show("Computer Win");
				CWin += 1;

			}
			if (array[random] == "Scissors")
			{
				label3.Text = "Scissors";
				MessageBox.Show("draw");
			}
			label7.Text = Convert.ToString(CWin);
			label6.Text = Convert.ToString(YouWin);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			button1.BackColor = Color.White;
			button2.BackColor = Color.White;
			button3.BackColor = Color.White;
			label3.Text = "";
		}
	}
}
