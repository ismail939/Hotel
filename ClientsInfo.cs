/*
 * Created by SharpDevelop.
 * User: youss
 * Date: 6/7/2025
 * Time: 11:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hotel
{
	/// <summary>
	/// Description of ClientsInfo.
	/// </summary>
	public partial class ClientsInfo : Form
	{
		SqlConnection Con = new SqlConnection(@"Server=localhost\SQLEXPRESS01;Database=hoteldb;Trusted_Connection=True;");
		public void populate()
		{
			Con.Open();
			string query = "select * from client_tbl";
			SqlDataAdapter da = new SqlDataAdapter(query, Con);
			var ds = new DataSet();
			da.Fill(ds);
			dataGridViewClients.DataSource = ds.Tables[0];
			Con.Close();
		}
		public ClientsInfo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Timer1Tick(object sender, EventArgs e)
		{
			lblDate.Text = DateTime.Now.ToLongTimeString();
		}
		
		void ClientsInfoLoad(object sender, EventArgs e)
		{
			lblDate.Text = DateTime.Now.ToLongTimeString();
			timer1.Start();
			populate();
		}
		
		void BtnAddClick(object sender, EventArgs e)
		{
			Con.Open();
			if(CheckInput()=="")
			{
				SqlCommand cmd = new SqlCommand(string.Format("insert into client_tbl values('{0}', '{1}', '{2}')", textBoxClientName.Text, comboBoxCountry.SelectedItem, textBoxPhoneNumber.Text), Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Client Added Successfully");
				ClearAll();
			}
			else
			{
				MessageBox.Show(CheckInput());
			}
			Con.Close();
			populate();
		}
		string CheckInput()
		{
			string output="";

			// checking the ClientName
			bool isValid = Regex.IsMatch(textBoxClientName.Text, @"^[a-zA-Z\s'-]+$");
			if(!isValid)
			{
				output+="Client Name shouldn't contain any special characters or be empty!\n";
				textBoxClientName.Text = "";
			}
			// checking PhoneNumber
			isValid = Regex.IsMatch(textBoxPhoneNumber.Text, @"^01[0-25][0-9]{8}$");
			if(!isValid)
			{
				output+="Phone number should be an egyptian phone number starting with 010, 012, 011 or 015 and is 11 number long!\n";
				textBoxPhoneNumber.Text = "";
			}
			// checking Country
			if(comboBoxCountry.SelectedItem==null)
			{
				output+="You should select a country!\n";
			}
			return output;
				
		}
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			Con.Open();
			if(lblClientId.Text==""){
				MessageBox.Show("Select a client to delete!");
				Con.Close();
				return;
			}
			string query = string.Format("delete from client_tbl where clientId = {0}", lblClientId.Text);
			SqlCommand cmd = new SqlCommand(query, Con);
			int rowsAffected = cmd.ExecuteNonQuery();
			if(rowsAffected>0)
			{
				MessageBox.Show("Client deleted successfully!");
				lblClientId.Text="";
			}
			else
			{
				MessageBox.Show("Client doesn't exist!");
			}
			Con.Close();
			ClearAll();
			populate();
		}
		
		void ClearAll()
		{
			textBoxClientName.Text = "";
			textBoxPhoneNumber.Text = "";
			comboBoxCountry.SelectedItem=null;
		}
		
		void DataGridViewClientsCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int r = e.RowIndex;
			if(r >=0)
			{
				lblClientId.Text = dataGridViewClients.Rows[r].Cells[0].Value.ToString();
				textBoxClientName.Text = dataGridViewClients.Rows[r].Cells[1].Value.ToString();
				comboBoxCountry.SelectedItem = dataGridViewClients.Rows[r].Cells[2].Value.ToString();
				textBoxPhoneNumber.Text=dataGridViewClients.Rows[r].Cells[3].Value.ToString();
			}
			
		}
		
		void BtnUpdateClick(object sender, EventArgs e)
		{
			if(CheckInput()=="")
			{
				Con.Open();
				string query = string.Format("update client_tbl set clientName = '{0}', clientPhone = '{1}', clientCountry = '{2}' where clientId = {3}", textBoxClientName.Text, textBoxPhoneNumber.Text, comboBoxCountry.SelectedItem, lblClientId.Text);
//				MessageBox.Show(query);
//				return;
				SqlCommand cmd = new SqlCommand(query, Con);
				int rowsAffected = cmd.ExecuteNonQuery();
				Con.Close();
				if(rowsAffected==1)
				{
					MessageBox.Show("Client Updated Successfully!");
					ClearAll();
					populate();
				}
				else
				{
					MessageBox.Show("Client doesn't exist!");
				}
				
			}
			else
			{
				MessageBox.Show(CheckInput());
			}
		}
		
		void PictureBoxRefreshClick(object sender, EventArgs e)
		{
			populate();
		}
		
		void BtnSearchClick(object sender, EventArgs e)
		{
			Con.Open();
			string query = string.Format("select * from client_tbl where clientName like '{0}%'", textBoxSearchClientName.Text);
			SqlDataAdapter da = new SqlDataAdapter(query, Con);
			var ds = new DataSet();
			da.Fill(ds);
			dataGridViewClients.DataSource = ds.Tables[0];
			Con.Close();
		}
		
		
		void Label6Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
