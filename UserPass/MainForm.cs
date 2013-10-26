using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UserPass
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();
			
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (text_user.Text == "Nestor" && double.Parse(text_pass.Text) == 123)
			{
				MessageBox.Show("Bienvenido");
				this.Close();
			}
			else
			{
				MessageBox.Show("Lo siento pero uno de los campos es Incorrecto");
			}
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
			
		}
	}
}
