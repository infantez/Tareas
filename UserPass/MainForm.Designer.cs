/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 22/10/2013
 * Time: 05:33 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UserPass
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.text_user = new System.Windows.Forms.TextBox();
			this.text_pass = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(43, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "User";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(43, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// text_user
			// 
			this.text_user.Location = new System.Drawing.Point(43, 59);
			this.text_user.Name = "text_user";
			this.text_user.Size = new System.Drawing.Size(100, 20);
			this.text_user.TabIndex = 2;
			this.text_user.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// text_pass
			// 
			this.text_pass.Location = new System.Drawing.Point(43, 119);
			this.text_pass.Name = "text_pass";
			this.text_pass.Size = new System.Drawing.Size(100, 20);
			this.text_pass.TabIndex = 3;
			this.text_pass.UseSystemPasswordChar = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(186, 218);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(67, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.text_pass);
			this.Controls.Add(this.text_user);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "UserPass";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox text_pass;
		private System.Windows.Forms.TextBox text_user;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
