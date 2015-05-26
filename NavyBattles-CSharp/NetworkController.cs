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
		Socket connectedSocket;
		string msg;
		

		public NetworkController()
		{
			
		}
		
		public void sendOrder(int order)
		{
			//TO DO send to party the play order
		}
		
		public void sendShot(Shot shot)
		{
			send(shot.toJson());
		}
		
		private void send(string text)
		{
			connectedSocket.Send(Encoding.Unicode.GetBytes(msg));
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
		
	}
}
