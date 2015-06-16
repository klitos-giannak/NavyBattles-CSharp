/*
 * Created by SharpDevelop.
 * User: delta-lab
 * Date: 4/5/2015
 * Time: 8:41 μμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NavyBattles_CSharp
{
	partial class GameAreaForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private GridView myBoard;
		private GridView enemyBoard;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameAreaForm));
			this.myBoard = new NavyBattles_CSharp.GridView();
			this.enemyBoard = new NavyBattles_CSharp.GridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.label40 = new System.Windows.Forms.Label();
			this.ship1 = new System.Windows.Forms.PictureBox();
			this.ship2 = new System.Windows.Forms.PictureBox();
			this.ship3 = new System.Windows.Forms.PictureBox();
			this.ship4 = new System.Windows.Forms.PictureBox();
			this.ship5 = new System.Windows.Forms.PictureBox();
			this.startGameButton = new System.Windows.Forms.Button();
			this.labelTurn = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ship1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ship2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ship3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ship4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ship5)).BeginInit();
			this.SuspendLayout();
			// 
			// myBoard
			// 
			this.myBoard.BackColor = System.Drawing.Color.Transparent;
			this.myBoard.ForeColor = System.Drawing.Color.White;
			this.myBoard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.myBoard.Location = new System.Drawing.Point(12, 12);
			this.myBoard.Name = "myBoard";
			this.myBoard.Size = new System.Drawing.Size(450, 450);
			this.myBoard.TabIndex = 0;
			this.myBoard.Text = "My Board";
			// 
			// enemyBoard
			// 
			this.enemyBoard.BackColor = System.Drawing.Color.Transparent;
			this.enemyBoard.ForeColor = System.Drawing.Color.White;
			this.enemyBoard.Location = new System.Drawing.Point(488, 12);
			this.enemyBoard.Name = "enemyBoard";
			this.enemyBoard.Size = new System.Drawing.Size(450, 450);
			this.enemyBoard.TabIndex = 1;
			this.enemyBoard.Text = "Enemy Board";
			this.enemyBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EnemyBoardMouseClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(50, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "A";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(131, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 22);
			this.label2.TabIndex = 3;
			this.label2.Text = "C";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(91, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 22);
			this.label3.TabIndex = 4;
			this.label3.Text = "B";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(338, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 22);
			this.label5.TabIndex = 6;
			this.label5.Text = "H";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(297, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(30, 22);
			this.label6.TabIndex = 7;
			this.label6.Text = "G";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(256, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(30, 22);
			this.label7.TabIndex = 8;
			this.label7.Text = "F";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(214, 12);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 22);
			this.label8.TabIndex = 9;
			this.label8.Text = "E";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(173, 12);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(30, 22);
			this.label9.TabIndex = 10;
			this.label9.Text = "D";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(423, 12);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(30, 22);
			this.label10.TabIndex = 11;
			this.label10.Text = "J";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(380, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 22);
			this.label4.TabIndex = 5;
			this.label4.Text = "I";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(12, 424);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 21);
			this.label11.TabIndex = 21;
			this.label11.Text = "10";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(12, 175);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(29, 21);
			this.label12.TabIndex = 20;
			this.label12.Text = "4";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(12, 215);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(29, 21);
			this.label13.TabIndex = 19;
			this.label13.Text = "5";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(12, 258);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(29, 21);
			this.label14.TabIndex = 18;
			this.label14.Text = "6";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Location = new System.Drawing.Point(12, 300);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(29, 21);
			this.label15.TabIndex = 17;
			this.label15.Text = "7";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.ForeColor = System.Drawing.Color.White;
			this.label16.Location = new System.Drawing.Point(12, 340);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(29, 21);
			this.label16.TabIndex = 16;
			this.label16.Text = "8";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.ForeColor = System.Drawing.Color.White;
			this.label17.Location = new System.Drawing.Point(12, 383);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(29, 21);
			this.label17.TabIndex = 15;
			this.label17.Text = "9";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.ForeColor = System.Drawing.Color.White;
			this.label18.Location = new System.Drawing.Point(12, 89);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(29, 23);
			this.label18.TabIndex = 14;
			this.label18.Text = "2";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.ForeColor = System.Drawing.Color.White;
			this.label19.Location = new System.Drawing.Point(12, 134);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(29, 21);
			this.label19.TabIndex = 13;
			this.label19.Text = "3";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.ForeColor = System.Drawing.Color.White;
			this.label20.Location = new System.Drawing.Point(12, 44);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(29, 21);
			this.label20.TabIndex = 12;
			this.label20.Text = "1";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.ForeColor = System.Drawing.Color.White;
			this.label21.Location = new System.Drawing.Point(896, 14);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(30, 22);
			this.label21.TabIndex = 31;
			this.label21.Text = "J";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.ForeColor = System.Drawing.Color.White;
			this.label22.Location = new System.Drawing.Point(646, 14);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(30, 22);
			this.label22.TabIndex = 30;
			this.label22.Text = "D";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.ForeColor = System.Drawing.Color.White;
			this.label23.Location = new System.Drawing.Point(687, 14);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(30, 22);
			this.label23.TabIndex = 29;
			this.label23.Text = "E";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.ForeColor = System.Drawing.Color.White;
			this.label24.Location = new System.Drawing.Point(730, 14);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(30, 22);
			this.label24.TabIndex = 28;
			this.label24.Text = "F";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.ForeColor = System.Drawing.Color.White;
			this.label25.Location = new System.Drawing.Point(771, 14);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(30, 22);
			this.label25.TabIndex = 27;
			this.label25.Text = "G";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.ForeColor = System.Drawing.Color.White;
			this.label26.Location = new System.Drawing.Point(812, 14);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(30, 22);
			this.label26.TabIndex = 26;
			this.label26.Text = "H";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.ForeColor = System.Drawing.Color.White;
			this.label27.Location = new System.Drawing.Point(854, 14);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(30, 22);
			this.label27.TabIndex = 25;
			this.label27.Text = "I";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.ForeColor = System.Drawing.Color.White;
			this.label28.Location = new System.Drawing.Point(563, 14);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(30, 22);
			this.label28.TabIndex = 24;
			this.label28.Text = "B";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.Transparent;
			this.label29.ForeColor = System.Drawing.Color.White;
			this.label29.Location = new System.Drawing.Point(605, 14);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(30, 22);
			this.label29.TabIndex = 23;
			this.label29.Text = "C";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label30
			// 
			this.label30.BackColor = System.Drawing.Color.Transparent;
			this.label30.ForeColor = System.Drawing.Color.White;
			this.label30.Location = new System.Drawing.Point(521, 14);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(30, 22);
			this.label30.TabIndex = 22;
			this.label30.Text = "A";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label31
			// 
			this.label31.BackColor = System.Drawing.Color.Transparent;
			this.label31.ForeColor = System.Drawing.Color.White;
			this.label31.Location = new System.Drawing.Point(488, 424);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(29, 21);
			this.label31.TabIndex = 41;
			this.label31.Text = "10";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label32
			// 
			this.label32.BackColor = System.Drawing.Color.Transparent;
			this.label32.ForeColor = System.Drawing.Color.White;
			this.label32.Location = new System.Drawing.Point(488, 175);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(29, 21);
			this.label32.TabIndex = 40;
			this.label32.Text = "4";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label33
			// 
			this.label33.BackColor = System.Drawing.Color.Transparent;
			this.label33.ForeColor = System.Drawing.Color.White;
			this.label33.Location = new System.Drawing.Point(488, 215);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(29, 21);
			this.label33.TabIndex = 39;
			this.label33.Text = "5";
			this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label34
			// 
			this.label34.BackColor = System.Drawing.Color.Transparent;
			this.label34.ForeColor = System.Drawing.Color.White;
			this.label34.Location = new System.Drawing.Point(488, 258);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(29, 21);
			this.label34.TabIndex = 38;
			this.label34.Text = "6";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label35
			// 
			this.label35.BackColor = System.Drawing.Color.Transparent;
			this.label35.ForeColor = System.Drawing.Color.White;
			this.label35.Location = new System.Drawing.Point(488, 300);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(29, 21);
			this.label35.TabIndex = 37;
			this.label35.Text = "7";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label36
			// 
			this.label36.BackColor = System.Drawing.Color.Transparent;
			this.label36.ForeColor = System.Drawing.Color.White;
			this.label36.Location = new System.Drawing.Point(488, 340);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(29, 21);
			this.label36.TabIndex = 36;
			this.label36.Text = "8";
			this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label37
			// 
			this.label37.BackColor = System.Drawing.Color.Transparent;
			this.label37.ForeColor = System.Drawing.Color.White;
			this.label37.Location = new System.Drawing.Point(488, 383);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(29, 21);
			this.label37.TabIndex = 35;
			this.label37.Text = "9";
			this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label38
			// 
			this.label38.BackColor = System.Drawing.Color.Transparent;
			this.label38.ForeColor = System.Drawing.Color.White;
			this.label38.Location = new System.Drawing.Point(488, 89);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(29, 23);
			this.label38.TabIndex = 34;
			this.label38.Text = "2";
			this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label39
			// 
			this.label39.BackColor = System.Drawing.Color.Transparent;
			this.label39.ForeColor = System.Drawing.Color.White;
			this.label39.Location = new System.Drawing.Point(488, 134);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(29, 21);
			this.label39.TabIndex = 33;
			this.label39.Text = "3";
			this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label40
			// 
			this.label40.BackColor = System.Drawing.Color.Transparent;
			this.label40.ForeColor = System.Drawing.Color.White;
			this.label40.Location = new System.Drawing.Point(488, 44);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(29, 21);
			this.label40.TabIndex = 32;
			this.label40.Text = "1";
			this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ship1
			// 
			this.ship1.BackColor = System.Drawing.Color.Transparent;
			this.ship1.Image = ((System.Drawing.Image)(resources.GetObject("ship1.Image")));
			this.ship1.Location = new System.Drawing.Point(28, 494);
			this.ship1.Name = "ship1";
			this.ship1.Size = new System.Drawing.Size(77, 37);
			this.ship1.TabIndex = 42;
			this.ship1.TabStop = false;
			this.ship1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShipMouseDown);
			this.ship1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShipMouseMove);
			this.ship1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShipMouseUp);
			// 
			// ship2
			// 
			this.ship2.BackColor = System.Drawing.Color.Transparent;
			this.ship2.Image = ((System.Drawing.Image)(resources.GetObject("ship2.Image")));
			this.ship2.Location = new System.Drawing.Point(131, 491);
			this.ship2.Name = "ship2";
			this.ship2.Size = new System.Drawing.Size(121, 37);
			this.ship2.TabIndex = 43;
			this.ship2.TabStop = false;
			this.ship2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShipMouseDown);
			this.ship2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShipMouseMove);
			this.ship2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShipMouseUp);
			// 
			// ship3
			// 
			this.ship3.BackColor = System.Drawing.Color.Transparent;
			this.ship3.Image = ((System.Drawing.Image)(resources.GetObject("ship3.Image")));
			this.ship3.Location = new System.Drawing.Point(288, 491);
			this.ship3.Name = "ship3";
			this.ship3.Size = new System.Drawing.Size(165, 40);
			this.ship3.TabIndex = 44;
			this.ship3.TabStop = false;
			this.ship3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShipMouseDown);
			this.ship3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShipMouseMove);
			this.ship3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShipMouseUp);
			// 
			// ship4
			// 
			this.ship4.BackColor = System.Drawing.Color.Transparent;
			this.ship4.Image = ((System.Drawing.Image)(resources.GetObject("ship4.Image")));
			this.ship4.Location = new System.Drawing.Point(28, 565);
			this.ship4.Name = "ship4";
			this.ship4.Size = new System.Drawing.Size(205, 40);
			this.ship4.TabIndex = 45;
			this.ship4.TabStop = false;
			this.ship4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShipMouseDown);
			this.ship4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShipMouseMove);
			this.ship4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShipMouseUp);
			// 
			// ship5
			// 
			this.ship5.BackColor = System.Drawing.Color.Transparent;
			this.ship5.Image = ((System.Drawing.Image)(resources.GetObject("ship5.Image")));
			this.ship5.Location = new System.Drawing.Point(256, 565);
			this.ship5.Name = "ship5";
			this.ship5.Size = new System.Drawing.Size(250, 40);
			this.ship5.TabIndex = 46;
			this.ship5.TabStop = false;
			this.ship5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShipMouseDown);
			this.ship5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShipMouseMove);
			this.ship5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShipMouseUp);
			// 
			// startGameButton
			// 
			this.startGameButton.Location = new System.Drawing.Point(790, 483);
			this.startGameButton.Name = "startGameButton";
			this.startGameButton.Size = new System.Drawing.Size(123, 45);
			this.startGameButton.TabIndex = 47;
			this.startGameButton.Text = "Start";
			this.startGameButton.UseVisualStyleBackColor = true;
			this.startGameButton.Click += new System.EventHandler(this.StartGameButtonClick);
			// 
			// labelTurn
			// 
			this.labelTurn.BackColor = System.Drawing.Color.Transparent;
			this.labelTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.labelTurn.ForeColor = System.Drawing.Color.LawnGreen;
			this.labelTurn.Location = new System.Drawing.Point(790, 540);
			this.labelTurn.Name = "labelTurn";
			this.labelTurn.Size = new System.Drawing.Size(136, 40);
			this.labelTurn.TabIndex = 48;
			this.labelTurn.Text = "Your Turn";
			this.labelTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GameAreaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(968, 640);
			this.Controls.Add(this.labelTurn);
			this.Controls.Add(this.startGameButton);
			this.Controls.Add(this.ship5);
			this.Controls.Add(this.ship4);
			this.Controls.Add(this.ship3);
			this.Controls.Add(this.ship2);
			this.Controls.Add(this.ship1);
			this.Controls.Add(this.label31);
			this.Controls.Add(this.label32);
			this.Controls.Add(this.label33);
			this.Controls.Add(this.label34);
			this.Controls.Add(this.label35);
			this.Controls.Add(this.label36);
			this.Controls.Add(this.label37);
			this.Controls.Add(this.label38);
			this.Controls.Add(this.label39);
			this.Controls.Add(this.label40);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.label28);
			this.Controls.Add(this.label29);
			this.Controls.Add(this.label30);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.enemyBoard);
			this.Controls.Add(this.myBoard);
			this.Name = "GameAreaForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GameAreaForm";
			((System.ComponentModel.ISupportInitialize)(this.ship1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ship2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ship3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ship4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ship5)).EndInit();
			this.ResumeLayout(false);

		}
		
		private System.Windows.Forms.PictureBox ship5;
		private System.Windows.Forms.PictureBox ship4;
		private System.Windows.Forms.PictureBox ship3;
		private System.Windows.Forms.PictureBox ship2;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox ship1;
		private System.Windows.Forms.Button startGameButton;
		private System.Windows.Forms.Label labelTurn;
	}
}
