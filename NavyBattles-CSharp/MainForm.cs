/*
 * Created by SharpDevelop.
 * User: klitos
 * Date: 4/18/2015
 * Time: 3:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace NavyBattles_CSharp
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		

		
		void JoinButtonClick(object sender, EventArgs e)
		{
			NetworkController net=new NetworkController();
			net.joinGame(ipTextBox.Text);
			
			GameControler backEnd=new GameControler(net);
			backEnd.connected();
			
		}
		void HostButtonClick(object sender, EventArgs e)
		{
			NetworkController net=new NetworkController();
			net.hostGame();
			
			GameControler backEnd=new GameControler(net);
			backEnd.connected();
			
			Random random = new Random();
			int firstPlayer = random.Next(1,3);
			
			net.sendOrder(firstPlayer);
			if(firstPlayer == 1)
				backEnd.playFirst(true);
			else
				backEnd.playFirst(false);
				
			
		}
		
	}
}
