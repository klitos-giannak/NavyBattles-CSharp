/*
 * Created by SharpDevelop.
 * User: delta-lab
 * Date: 25/5/2015
 * Time: 8:05 μμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NavyBattles_CSharp
{
	/// <summary>
	/// Description of NetworkController.
	/// </summary>
	public class NetworkController
	{
		public NetworkController()
		{
			
		}
		
		public void sendShot(Shot shot)
		{
			send(shot.toJson());
		}
		
		private void send(string text)
		{
			
		}
		
		private string receive ()
		{
			return null;
		}
	}
}
