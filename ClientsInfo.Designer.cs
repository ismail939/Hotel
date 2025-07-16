/*
 * Created by SharpDevelop.
 * User: youss
 * Date: 6/7/2025
 * Time: 11:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Hotel
{
	partial class ClientsInfo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsInfo));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
			this.textBoxClientName = new System.Windows.Forms.TextBox();
			this.comboBoxCountry = new System.Windows.Forms.ComboBox();
			this.dataGridViewClients = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.textBoxSearchClientName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblDate = new System.Windows.Forms.Label();
			this.lblClientInformation = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblClientId = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(54, 298);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(199, 31);
			this.label1.TabIndex = 3;
			this.label1.Text = "Phone Number";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(54, 213);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(181, 31);
			this.label2.TabIndex = 3;
			this.label2.Text = "Client Name";
			// 
			// textBoxPhoneNumber
			// 
			this.textBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPhoneNumber.Location = new System.Drawing.Point(259, 298);
			this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
			this.textBoxPhoneNumber.Size = new System.Drawing.Size(204, 34);
			this.textBoxPhoneNumber.TabIndex = 4;
			// 
			// textBoxClientName
			// 
			this.textBoxClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxClientName.Location = new System.Drawing.Point(259, 210);
			this.textBoxClientName.Name = "textBoxClientName";
			this.textBoxClientName.Size = new System.Drawing.Size(204, 34);
			this.textBoxClientName.TabIndex = 4;
			// 
			// comboBoxCountry
			// 
			this.comboBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxCountry.FormattingEnabled = true;
			this.comboBoxCountry.Items.AddRange(new object[] {
									"Afghanistan  ",
									"Albania  ",
									"Algeria  ",
									"Andorra  ",
									"Angola  ",
									"Antigua and Barbuda  ",
									"Argentina  ",
									"Armenia  ",
									"Australia  ",
									"Austria  ",
									"Azerbaijan  ",
									"Bahamas  ",
									"Bahrain  ",
									"Bangladesh  ",
									"Barbados  ",
									"Belarus  ",
									"Belgium  ",
									"Belize  ",
									"Benin  ",
									"Bhutan  ",
									"Bolivia  ",
									"Bosnia and Herzegovina  ",
									"Botswana  ",
									"Brazil  ",
									"Brunei  ",
									"Bulgaria  ",
									"Burkina Faso  ",
									"Burundi  ",
									"Cabo Verde  ",
									"Cambodia  ",
									"Cameroon  ",
									"Canada  ",
									"Central African Republic  ",
									"Chad  ",
									"Chile  ",
									"China  ",
									"Colombia  ",
									"Comoros  ",
									"Congo (Congo-Brazzaville)  ",
									"Costa Rica  ",
									"Croatia  ",
									"Cuba  ",
									"Cyprus  ",
									"Czech Republic (Czechia)  ",
									"Democratic Republic of the Congo  ",
									"Denmark  ",
									"Djibouti  ",
									"Dominica  ",
									"Dominican Republic  ",
									"Ecuador  ",
									"Egypt  ",
									"El Salvador  ",
									"Equatorial Guinea  ",
									"Eritrea  ",
									"Estonia  ",
									"Eswatini (fmr. \"Swaziland\")  ",
									"Ethiopia  ",
									"Fiji  ",
									"Finland  ",
									"France  ",
									"Gabon  ",
									"Gambia  ",
									"Georgia  ",
									"Germany  ",
									"Ghana  ",
									"Greece  ",
									"Grenada  ",
									"Guatemala  ",
									"Guinea  ",
									"Guinea-Bissau  ",
									"Guyana  ",
									"Haiti  ",
									"Honduras  ",
									"Hungary  ",
									"Iceland  ",
									"India  ",
									"Indonesia  ",
									"Iran  ",
									"Iraq  ",
									"Ireland  ",
									"Israel  ",
									"Italy  ",
									"Jamaica  ",
									"Japan  ",
									"Jordan  ",
									"Kazakhstan  ",
									"Kenya  ",
									"Kiribati  ",
									"Kuwait  ",
									"Kyrgyzstan  ",
									"Laos  ",
									"Latvia  ",
									"Lebanon  ",
									"Lesotho  ",
									"Liberia  ",
									"Libya  ",
									"Liechtenstein  ",
									"Lithuania  ",
									"Luxembourg  ",
									"Madagascar  ",
									"Malawi  ",
									"Malaysia  ",
									"Maldives  ",
									"Mali  ",
									"Malta  ",
									"Marshall Islands  ",
									"Mauritania  ",
									"Mauritius  ",
									"Mexico  ",
									"Micronesia  ",
									"Moldova  ",
									"Monaco  ",
									"Mongolia  ",
									"Montenegro  ",
									"Morocco  ",
									"Mozambique  ",
									"Myanmar (formerly Burma)  ",
									"Namibia  ",
									"Nauru  ",
									"Nepal  ",
									"Netherlands  ",
									"New Zealand  ",
									"Nicaragua  ",
									"Niger  ",
									"Nigeria  ",
									"North Korea  ",
									"North Macedonia (formerly Macedonia)  ",
									"Norway  ",
									"Oman  ",
									"Pakistan  ",
									"Palau  ",
									"Palestine State  ",
									"Panama  ",
									"Papua New Guinea  ",
									"Paraguay  ",
									"Peru  ",
									"Philippines  ",
									"Poland  ",
									"Portugal  ",
									"Qatar  ",
									"Romania  ",
									"Russia  ",
									"Rwanda  ",
									"Saint Kitts and Nevis  ",
									"Saint Lucia  ",
									"Saint Vincent and the Grenadines  ",
									"Samoa  ",
									"San Marino  ",
									"Sao Tome and Principe  ",
									"Saudi Arabia  ",
									"Senegal  ",
									"Serbia  ",
									"Seychelles  ",
									"Sierra Leone  ",
									"Singapore  ",
									"Slovakia  ",
									"Slovenia  ",
									"Solomon Islands  ",
									"Somalia  ",
									"South Africa  ",
									"South Korea  ",
									"South Sudan  ",
									"Spain  ",
									"Sri Lanka  ",
									"Sudan  ",
									"Suriname  ",
									"Sweden  ",
									"Switzerland  ",
									"Syria  ",
									"Taiwan  ",
									"Tajikistan  ",
									"Tanzania  ",
									"Thailand  ",
									"Timor-Leste  ",
									"Togo  ",
									"Tonga  ",
									"Trinidad and Tobago  ",
									"Tunisia  ",
									"Turkey  ",
									"Turkmenistan  ",
									"Tuvalu  ",
									"Uganda  ",
									"Ukraine  ",
									"United Arab Emirates  ",
									"United Kingdom  ",
									"United States of America  ",
									"Uruguay  ",
									"Uzbekistan  ",
									"Vanuatu  ",
									"Vatican City  ",
									"Venezuela  ",
									"Vietnam  ",
									"Yemen  ",
									"Zambia  ",
									"Zimbabwe"});
			this.comboBoxCountry.Location = new System.Drawing.Point(122, 410);
			this.comboBoxCountry.Name = "comboBoxCountry";
			this.comboBoxCountry.Size = new System.Drawing.Size(248, 37);
			this.comboBoxCountry.TabIndex = 5;
			this.comboBoxCountry.Text = "Country";
			// 
			// dataGridViewClients
			// 
			this.dataGridViewClients.AllowUserToAddRows = false;
			this.dataGridViewClients.AllowUserToDeleteRows = false;
			this.dataGridViewClients.AllowUserToResizeColumns = false;
			this.dataGridViewClients.AllowUserToResizeRows = false;
			this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridViewClients.Location = new System.Drawing.Point(516, 210);
			this.dataGridViewClients.Name = "dataGridViewClients";
			this.dataGridViewClients.RowTemplate.Height = 24;
			this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewClients.Size = new System.Drawing.Size(642, 428);
			this.dataGridViewClients.TabIndex = 6;
			this.dataGridViewClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewClientsCellContentClick);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.Black;
			this.btnAdd.Location = new System.Drawing.Point(33, 562);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(120, 56);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(180, 562);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 56);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(330, 562);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(120, 56);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// textBoxSearchClientName
			// 
			this.textBoxSearchClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSearchClientName.Location = new System.Drawing.Point(679, 156);
			this.textBoxSearchClientName.Name = "textBoxSearchClientName";
			this.textBoxSearchClientName.Size = new System.Drawing.Size(248, 34);
			this.textBoxSearchClientName.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(516, 159);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(181, 31);
			this.label4.TabIndex = 3;
			this.label4.Text = "Client Name";
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(953, 152);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(115, 42);
			this.btnSearch.TabIndex = 7;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.BtnSearchClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.lblDate);
			this.panel1.Controls.Add(this.lblClientInformation);
			this.panel1.Location = new System.Drawing.Point(1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1201, 130);
			this.panel1.TabIndex = 8;
			// 
			// lblDate
			// 
			this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDate.ForeColor = System.Drawing.Color.White;
			this.lblDate.Location = new System.Drawing.Point(942, 68);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(236, 53);
			this.lblDate.TabIndex = 0;
			this.lblDate.Text = "Date";
			// 
			// lblClientInformation
			// 
			this.lblClientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblClientInformation.ForeColor = System.Drawing.Color.White;
			this.lblClientInformation.Location = new System.Drawing.Point(445, 39);
			this.lblClientInformation.Name = "lblClientInformation";
			this.lblClientInformation.Size = new System.Drawing.Size(345, 82);
			this.lblClientInformation.TabIndex = 0;
			this.lblClientInformation.Text = "Client Information";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// pictureBoxRefresh
			// 
			this.pictureBoxRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefresh.Image")));
			this.pictureBoxRefresh.Location = new System.Drawing.Point(1090, 142);
			this.pictureBoxRefresh.Name = "pictureBoxRefresh";
			this.pictureBoxRefresh.Size = new System.Drawing.Size(68, 62);
			this.pictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxRefresh.TabIndex = 9;
			this.pictureBoxRefresh.TabStop = false;
			this.pictureBoxRefresh.Click += new System.EventHandler(this.PictureBoxRefreshClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(54, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(181, 31);
			this.label3.TabIndex = 3;
			this.label3.Text = "Client ID";
			// 
			// lblClientId
			// 
			this.lblClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblClientId.Location = new System.Drawing.Point(207, 156);
			this.lblClientId.Name = "lblClientId";
			this.lblClientId.Size = new System.Drawing.Size(181, 31);
			this.lblClientId.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(1128, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 53);
			this.label6.TabIndex = 6;
			this.label6.Text = "X";
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// ClientsInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1202, 650);
			this.Controls.Add(this.pictureBoxRefresh);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dataGridViewClients);
			this.Controls.Add(this.comboBoxCountry);
			this.Controls.Add(this.textBoxClientName);
			this.Controls.Add(this.textBoxPhoneNumber);
			this.Controls.Add(this.textBoxSearchClientName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblClientId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ClientsInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ClientsInfo";
			this.Load += new System.EventHandler(this.ClientsInfoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblClientId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBoxRefresh;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxSearchClientName;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridView dataGridViewClients;
		private System.Windows.Forms.Label lblClientInformation;
		private System.Windows.Forms.ComboBox comboBoxCountry;
		private System.Windows.Forms.TextBox textBoxClientName;
		private System.Windows.Forms.TextBox textBoxPhoneNumber;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
