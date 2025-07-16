/*
 * Created by SharpDevelop.
 * User: youss
 * Date: 6/6/2025
 * Time: 4:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Hotel
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		SqlConnection Con = new SqlConnection(@"Server=localhost\SQLEXPRESS01;Database=hoteldb;Trusted_Connection=True;");
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Con.Open();
			SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from staff_tbl where staffName='"+textBoxUserName.Text+"' and staffPassword = '"+textBoxPassword.Text+"'", Con);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			if(dt.Rows[0][0].ToString()=="1")
			{
				ChoicesForm cf = new ChoicesForm();
				cf.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Wrong username or password!");
			}
			Con.Close();
		}
		
		void Label6Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
