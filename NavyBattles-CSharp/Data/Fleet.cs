/*
 * Created by SharpDevelop.
 * User: delta-lab
 * Date: 5/5/2015
 * Time: 7:51 μμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace NavyBattles_CSharp.Data
{
	/// <summary>
	/// Description of Fleet.
	/// </summary>
	public class Fleet
	{
		private Dictionary<int,Ship> allShips;

		
		public Fleet()
		{
			allShips=new Dictionary<int, Ship>(5);
		}
		
		public void initShip(int size, Direction direction, Coords firstBlock)
		{
			if(size <=6 && size>=2 )
			{
				if(allShips.ContainsKey(size))
					allShips.Remove(size);
				allShips.Add(size, new Ship(size,direction,firstBlock));
			}
			else 
			{
				throw new ArgumentException("INVALID SHIP SIZE: "+size);
			}
			
		}
		
		public Ship getShip(int size)
		{
			if (allShips.ContainsKey(size))
				return allShips[size];
			else
				return null;
		}
		
		
		public bool areAllShipsLocated()
		{
			for(int i=2;i<7;i++)
			{
				if(getShip(i)==null)
			   		return false;
			   
			}
			return true;
		}
		
		
		
		public bool isBlockOccupied(Coords block)
		{
			foreach(Ship ship in allShips.Values)
			{
				if (ship.isBlockOccupied(block))
				{
					return true;
				}
			}
			return false;
		}
	}
}
