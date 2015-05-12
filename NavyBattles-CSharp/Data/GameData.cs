/*
 * Created by SharpDevelop.
 * User: delta
 * Date: 21/4/2015
 * Time: 6:33 μμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NavyBattles_CSharp.Data
{
	/// <summary>
	/// Description of GameData.
	/// </summary>
	public class GameData
	{
		private const int GRIDSIZE=10;
		
		private BoxState[,] myGrid=new BoxState[GRIDSIZE,GRIDSIZE];
		private BoxState[,] enemyGrid=new BoxState[GRIDSIZE,GRIDSIZE];
		private Fleet fleet=new Fleet();
		
		public GameData()
		{
			clearGrids();
		}
		
		public BoxState getMyBoxState(int x,int y)
		{
			return myGrid[x,y];
		}
		
		public BoxState getEnemyBoxState(int x,int y)
		{
			return enemyGrid[x,y];
		}
		
		public void setMyBoxState(int x,int y,BoxState state)
		{
			myGrid[x,y]=state; 
		}
		
		public void setEnemyBoxState(int x,int y,BoxState state)
		{
			enemyGrid[x,y]=state; 
		}
		
		private void clearGrids()
		{
			for (int i=0; i<myGrid.GetLength(0); i++)
			{
				for (int j=0; j<myGrid.GetLength(1); j++)
				{
					myGrid[i,j]= BoxState.CLEAR;
					enemyGrid[i,j]= BoxState.CLEAR;
				}
			}
		}
		
		public bool isBlockOccupied(Coords block)
		{
			return fleet.isBlockOccupied(block);
		}
		
		
		public enum BoxState
		{
			CLEAR,MISSED,BOMBED
		}
		
		
	}
	 
	
}
