/*
 * Created by SharpDevelop.
 * User: klitos
 * Date: 3/13/2015
 * Time: 9:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net.Sockets;
using System.Text;

namespace AsyncSocketServer
{
	/// <summary>
	/// State object for reading client data asynchronously
	/// </summary>
	public class StateObject {
		
	    // Client  socket.
	    public Socket workSocket = null;
	    
	    // Size of receive buffer.
	    public const int BufferSize = 1024;
	    
	    // Receive buffer.
	    public byte[] buffer = new byte[BufferSize];
	    
		// Received data string.
	    public StringBuilder sb = new StringBuilder();  
	}
}
