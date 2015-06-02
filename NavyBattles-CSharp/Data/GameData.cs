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
		public const int MAXHITS=20;
		
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
		
		
		
		public bool initShip(int size, Direction direction, Coords firstBlock)
		{
			if( ( (direction==Direction.HORIZONTAL && firstBlock.X + size < myGrid.GetLength(0))
			     ||  (direction==Direction.VERTICAL && firstBlock.Y + size < myGrid.GetLength(1)) )
			     && areBlocksFree(size,direction,firstBlock) )
			
			{				
			   		fleet.initShip(size, direction, firstBlock);
			   		return true;	
			}
			
			return false;
			
		}
		
		
		private bool areBlocksFree(int size, Direction direction, Coords firstBlock)
		{
			for (int i=0 ; i<size ; i++)
			{
				if(direction==Direction.VERTICAL)
				{
					if(fleet.isBlockOccupied(new Coords(firstBlock.X,firstBlock.Y+i)))
						return false;
				}
				else					
				{
					if(fleet.isBlockOccupied(new Coords(firstBlock.X+i,firstBlock.Y)));
				}
			}
			return true;
		}
	}
	 
	
}
