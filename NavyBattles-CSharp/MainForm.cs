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
		private NetworkController net;
		private GameControler backEnd;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			net=new NetworkController();
			hostIP.Text = net.getLocalIPAdress();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		

		
		void JoinButtonClick(object sender, EventArgs e)
		{
			net.joinGame(ipTextBox.Text);
			
			backEnd=new GameControler(net);
			net.Backend = backEnd;
			backEnd.connected();
			
			net.receiveOrder();
			
		}
		void HostButtonClick(object sender, EventArgs e)
		{
			net.hostGame();
			
			backEnd=new GameControler(net);
			net.Backend = backEnd;
			backEnd.connected();
			
			Random random = new Random();
			int firstPlayer = random.Next(1,3);
			
			net.sendOrder(firstPlayer);				
			
		}
		
	}
}
