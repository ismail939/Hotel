/*
 * Created by SharpDevelop.
 * User: youss
 * Date: 6/7/2025
 * Time: 9:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel
{
	/// <summary>
	/// Description of ChoicesForm.
	/// </summary>
	public partial class ChoicesForm : Form
	{
		public ChoicesForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
		
		void Label6Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void PictureBox4Click(object sender, EventArgs e)
		{
			MainForm login = new MainForm();
			login.Show();
			this.Hide();
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			ClientsInfo ClientsInfoForm	= new ClientsInfo();
			ClientsInfoForm.Show();
			this.Hide();
		}
	}
}
