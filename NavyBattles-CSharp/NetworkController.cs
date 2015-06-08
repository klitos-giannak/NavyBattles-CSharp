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
using System.Windows.Forms;
using AsyncSocketServer;

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
				
		public void sendShot(Shot shot)
		{
			send(shot.toJson());
			receiveConfirmation();
		}
				
		public void sendConfirmation(Shot shot)
		{
			send(shot.toJson());
		}
		
		public void sendOrder(int order)
		{
			send(order.ToString());
			setOrderToBackend(order);
		}
		
		private void setOrderToBackend(int order){
			if(order == 1){
				backend.playFirst(true);
				
				// send a draft shot to test network
//				sendShot(new Shot(new NavyBattles_CSharp.Data.Coords(5,6))); 
			} else {
				backend.playFirst(false);
				receiveShot();
			}
		}
		
		public void receiveOrder()
		{
			StateObject state = new StateObject();
	        state.workSocket = connectedSocket;
	        connectedSocket.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
		                new AsyncCallback(ReadOrderCallback), state);
		}
		
		private void receiveShot(){
			StateObject state = new StateObject();
	        state.workSocket = connectedSocket;
	        connectedSocket.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
		                new AsyncCallback(ReadShotCallback), state);
		}

		public void receiveConfirmation()
		{
			StateObject state = new StateObject();
	        state.workSocket = connectedSocket;
	        connectedSocket.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
		                new AsyncCallback(ReadConfirmationCallback), state);
		}
		
		private void send(String text) {
	        // Convert the string data to byte data using ASCII encoding.
	        byte[] byteData = Encoding.Unicode.GetBytes(text);
	
	        // Begin sending the data to the remote device.
	        connectedSocket.BeginSend(byteData, 0, byteData.Length, 0,
	            new AsyncCallback(SendCallback), connectedSocket);
	    }
	
	    private void SendCallback(IAsyncResult ar) {
			// Retrieve the socket from the state object.
	        Socket handler = (Socket) ar.AsyncState;
	        
	        try {
	            // Complete sending the data to the remote device.
	            int bytesSent = handler.EndSend(ar);	
	        } catch (Exception e) {
	            MessageBox.Show(e.ToString());
	        	handler.Shutdown(SocketShutdown.Both);
	            handler.Close();
	        }
	    }
		
		private void ReadShotCallback(IAsyncResult ar) {
	        String content = String.Empty;
	        
	        // Retrieve the state object and the handler socket
	        // from the asynchronous state object.
	        StateObject state = (StateObject) ar.AsyncState;
	        Socket handler = state.workSocket;
	
	        try {
		        // Read data from the client socket. 
		        int bytesRead = handler.EndReceive(ar);
		
		        if (bytesRead > 0) {
		            // There  might be more data, so store the data received so far.
		            state.sb.Append(Encoding.Unicode.GetString(
		                state.buffer,0,bytesRead));
		
		            // Check for end-of-file tag. If it is not there, read 
		            // more data.
		            content = state.sb.ToString();
		            
//		            MessageBox.Show(content);
		            // Convert the receivedData to a shot
					Shot shot = Shot.jsonToShot(content);
					shot = backend.enemyFired(shot);
					sendConfirmation(shot);
		        }
		        
	        } catch (SocketException e){
	            MessageBox.Show(e.ToString());
	        	handler.Shutdown(SocketShutdown.Both);
	            handler.Close();
	        }
	    }
		
		private void ReadOrderCallback(IAsyncResult ar) {
	        String content = String.Empty;
	        
	        StateObject state = (StateObject) ar.AsyncState;
	        Socket handler = state.workSocket;
	
	        try {
		        int bytesRead = handler.EndReceive(ar);
		
		        if (bytesRead > 0) {
		            state.sb.Append(Encoding.Unicode.GetString(state.buffer,0,bytesRead));
		            content = state.sb.ToString();
		            
		            // Read and set the order
					int order = Convert.ToInt32(content);
					if(order == 1)
						order = 2;
					else
						order = 1;
					setOrderToBackend(order);
		        }
		        
	        } catch (SocketException e){
	            MessageBox.Show(e.ToString());
	        	handler.Shutdown(SocketShutdown.Both);
	            handler.Close();
	        }
	    }
		
		public void ReadConfirmationCallback(IAsyncResult ar) {
	        String content = String.Empty;
	        
	        StateObject state = (StateObject) ar.AsyncState;
	        Socket handler = state.workSocket;
	
	        try {
		        int bytesRead = handler.EndReceive(ar);
		
		        if (bytesRead > 0) {
		            state.sb.Append(Encoding.Unicode.GetString(state.buffer,0,bytesRead));
		            content = state.sb.ToString();
		            
//		            MessageBox.Show(content);
		            // Read the confirmation
					Shot shot = Shot.jsonToShot(content);
					if(backend.shotResult(shot))
						receiveShot();
		        }
		        
	        } catch (SocketException e){
	            MessageBox.Show(e.ToString());
	        	handler.Shutdown(SocketShutdown.Both);
	            handler.Close();
	        }
	    }
		
		public void joinGame(string ip)
		{
			connectedSocket=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
			IPAddress ipAddress=IPAddress.Parse(ip);
			IPEndPoint ipe= new IPEndPoint(ipAddress ,PORT);
			connectedSocket.Connect(ipe);
		}
		
		public void hostGame()
		{
			Socket s=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
			IPEndPoint localendpoint=new IPEndPoint(IPAddress.Any,PORT);
			s.Bind(localendpoint);
			s.Listen(10);
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
