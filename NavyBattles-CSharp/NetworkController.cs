/*
 * Created by SharpDevelop.
 * User: delta-lab
 * Date: 25/5/2015
 * Time: 8:05 μμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace NavyBattles_CSharp
{
	/// <summary>
	/// Description of NetworkController.
	/// </summary>
	public class NetworkController
	{
		private const int PORT=55667;
		private Socket connectedSocket;
		private GameControler backend;
		
		public GameControler Backend{
			set{ backend = value; }
		}

		public NetworkController()
		{
			
		}
		
		public void sendOrder(int order)
		{
			send(order.ToString());
			setOrderToBackend(order);
		}
		
		public void receiveOrder()
		{
			int order = Convert.ToInt32(receive());
			setOrderToBackend(order);
		}
		
		private void setOrderToBackend(int order){
			if(order == 1)
				backend.playFirst(true);
			else {
				backend.playFirst(false);
				receiveShot();
			}
		}
		
		public void sendShot(Shot shot)
		{
			send(shot.toJson());
			receiveConfirmation();
		}
		
		private void receiveShot(){
			Shot shot = Shot.jsonToShot(receive());
			shot = backend.enemyFired(shot);
			sendConfirmation(shot);
		}
		
		public void sendConfirmation(Shot shot)
		{
			send(shot.toJson());
		}
		
		public void receiveConfirmation(){
			Shot shot = Shot.jsonToShot(receive());
			if(backend.shotResult(shot))
				receiveShot();
		}
		
		private void send(string text)
		{
			connectedSocket.Send(Encoding.Unicode.GetBytes(text));
		}
		
		private string receive ()
		{
			byte[] bytes=new byte[1024];
			int receiveBytes=connectedSocket.Receive(bytes);
			string myReceive=Encoding.Unicode.GetString(bytes,0,receiveBytes);
			return myReceive;
			
		}
		
		public void joinGame(string ip)
		{
			Socket s=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
			IPAddress ipAddress=IPAddress.Parse(ip);
			IPEndPoint ipe= new IPEndPoint(ipAddress ,PORT);
			s.Connect(ipe);
		}
		
		public void hostGame()
		{
			Socket s=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
			IPEndPoint localendpoint=new IPEndPoint(IPAddress.Any,PORT);
			s.Bind(localendpoint);
			s.Listen(10);
			Console.WriteLine("waiting for connection");
			connectedSocket=s.Accept();	
		}
		
		public string getLocalIPAdress()
		{
   			IPHostEntry host;
   			string localIP = "";
			host = Dns.GetHostEntry(Dns.GetHostName());
  			foreach (IPAddress ip in host.AddressList)
 	  		{
	    		if (ip.AddressFamily == AddressFamily.InterNetwork)
		     	{
	      			localIP = ip.ToString();
       				break;
     			}
   			}
   			return localIP;
   			
 		}
	}
}
