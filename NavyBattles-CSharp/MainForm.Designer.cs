/*
 * Created by SharpDevelop.
 * User: klitos
 * Date: 4/18/2015
 * Time: 3:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NavyBattles_CSharp
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button hostButton;
		private System.Windows.Forms.Button joinButton;
		private System.Windows.Forms.TextBox ipTextBox;
		private System.Windows.Forms.Label label1;
		
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
			this.hostButton = new System.Windows.Forms.Button();
			this.joinButton = new System.Windows.Forms.Button();
			this.ipTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// hostButton
			// 
			this.hostButton.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.hostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.hostButton.ForeColor = System.Drawing.Color.Snow;
			this.hostButton.Location = new System.Drawing.Point(630, 346);
			this.hostButton.Name = "hostButton";
			this.hostButton.Size = new System.Drawing.Size(95, 67);
			this.hostButton.TabIndex = 1;
			this.hostButton.Text = "Host Game";
			this.hostButton.UseVisualStyleBackColor = false;
			this.hostButton.Click += new System.EventHandler(this.HostButtonClick);
			// 
			// joinButton
			// 
			this.joinButton.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.joinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.joinButton.ForeColor = System.Drawing.Color.Snow;
			this.joinButton.Location = new System.Drawing.Point(731, 346);
			this.joinButton.Name = "joinButton";
			this.joinButton.Size = new System.Drawing.Size(95, 67);
			this.joinButton.TabIndex = 2;
			this.joinButton.Text = "Join Game";
			this.joinButton.UseVisualStyleBackColor = false;
			this.joinButton.Click += new System.EventHandler(this.JoinButtonClick);
			// 
			// ipTextBox
			// 
			this.ipTextBox.Location = new System.Drawing.Point(672, 33);
			this.ipTextBox.Name = "ipTextBox";
			this.ipTextBox.Size = new System.Drawing.Size(149, 20);
			this.ipTextBox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label1.ForeColor = System.Drawing.Color.PowderBlue;
			this.label1.Location = new System.Drawing.Point(648, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "IP";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(833, 442);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ipTextBox);
			this.Controls.Add(this.joinButton);
			this.Controls.Add(this.hostButton);
			this.Name = "MainForm";
			this.Text = "NavyBattles-CSharp";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
