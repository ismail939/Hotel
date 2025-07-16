/*
 * Created by SharpDevelop.
 * User: youss
 * Date: 6/6/2025
 * Time: 4:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Hotel
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxUserName = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.lblUserName = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label1.Location = new System.Drawing.Point(129, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(277, 56);
			this.label1.TabIndex = 0;
			this.label1.Text = "Qased Kheir";
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUserName.Location = new System.Drawing.Point(181, 167);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new System.Drawing.Size(204, 34);
			this.textBoxUserName.TabIndex = 1;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPassword.Location = new System.Drawing.Point(181, 234);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(204, 34);
			this.textBoxPassword.TabIndex = 1;
			// 
			// lblUserName
			// 
			this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserName.Location = new System.Drawing.Point(29, 170);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(132, 23);
			this.lblUserName.TabIndex = 2;
			this.lblUserName.Text = "Username";
			// 
			// lblPassword
			// 
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(29, 237);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(132, 23);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Password";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.RoyalBlue;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(181, 335);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 53);
			this.button1.TabIndex = 3;
			this.button1.Text = "login";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(215, 76);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(55, 51);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(402, 167);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(45, 34);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(402, 234);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(45, 34);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 4;
			this.pictureBox3.TabStop = false;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(425, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 53);
			this.label6.TabIndex = 5;
			this.label6.Text = "X";
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 469);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxUserName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hotel";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.TextBox textBoxUserName;
		private System.Windows.Forms.Label label1;
	}
}
