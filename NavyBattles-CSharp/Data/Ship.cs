/*
 * Created by SharpDevelop.
 * User: delta-lab
 * Date: 28/4/2015
 * Time: 8:52 μμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NavyBattles_CSharp
{
	/// <summary>
	/// Description of Ship.
	/// </summary>
	public class Ship
	{
		
		private	Coords[] shipCoords; 	//pinakas apo Coords gia to megethos tou ploiou
		private bool[] hits; 	//an exei xtypithei to kathe keli tou ploiou
		
		
		public Ship(int size, Direction direction, Coords startPoint)
		{
			
			shipCoords=new Coords[size]; //arxikopoihsi tou pinaka shipcoords
			hits=new bool[size];         //arxokopoihsi tou pinaka hits
			
			//initialization
			for (int i=0 ; i<size ; i++)
			{
				hits[i]=false; //initialize all cells to not hit
				
				//TO-DO initialize shipCoords
				
			}
			
		}
	}
}
