/*
 * Created by SharpDevelop.
 * User: delta
 * Date: 21/4/2015
 * Time: 8:05 μμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NavyBattles_CSharp.New_Folder
{
	/// <summary>
	/// Description of Coords.
	/// </summary>
	public class Coords
	{
		private int myX,myY;
		public Coords(int x,int y)
		{
			myX=x;
			myY=y;
		}
		public int X
		{
			get{ return myX;}
			set{ myX=value;}
		}
		public int Y
		{
			get{ return myY;}
			set{ myY=value;}
		}
		
		
	}
	public enum Direction
	{
		HORIZONTAL,VERTICAL
	}
}
