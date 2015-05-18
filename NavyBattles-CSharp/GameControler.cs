/*
 * Created by SharpDevelop.
 * User: delta-lab
 * Date: 12/5/2015
 * Time: 5:58 μμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NavyBattles_CSharp;
using NavyBattles_CSharp.Data;

namespace NavyBattles_CSharp
{
	/// <summary>
	/// Description of GameControler.
	/// </summary>
	public class GameControler
	{
		private GameData data;
		private GameAreaForm gameForm;
		private bool meReady;
		private bool otherReady;
		
		public GameControler()
		{
			data=new GameData();
			gameForm=new GameAreaForm();
			meReady=false;
			otherReady=false;
		}
		
		private void startGame()
		{
		}
		
		public void connected()
		{
			gameForm.Show();
		}
		
		public void enemyReady()//thn kalei to diktyo
		{
			otherReady=true;
			if(meReady)
				startGame();
			
		}
		
		public void iAmReady() //thn kalei to UI
		{
			meReady=true;
			//kalw to iAmReady tou network
			if(otherReady)				
				startGame();			
			
		}
		
		public Shot enemyFired(Shot shot)
		{
			if(data.isBlockOccupied(shot.Coords))
			{
				data.setMyBoxState(shot.Coords.X,shot.Coords.Y,
				                   GameData.BoxState.BOMBED);
				shot.Hit = true;
			}
			else
			{
				data.setMyBoxState(shot.Coords.X,shot.Coords.Y,
				                   GameData.BoxState.MISSED);
				shot.Hit = false;
			}
			
			gameForm.Invalidate();
			
			return shot;
				                   
		}
		
		public void shoot(Coords coords) // tin kalei to UI otan paizei o paikths
		{
			Shot shot = new Shot(coords);
			//stelnoume to shot sto network k tous afhnoume na kanoun ta dika tous.
			
		}
		
		/// <summary>
		/// kaleitai ap to duktio pros epivevaiwsh ths volhs mas
		/// k enhmerwnei to diko mas enemyGrid tou UI.
		/// </summary>
		/// <param name="shot"></param>
		
		public void shotResult(Shot shot)
		{
			if(shot.Confirmed == false)
				return;
							
				
			if(shot.Hit)
			{
				data.setEnemyBoxState(shot.Coords.X,shot.Coords.Y,
				                   GameData.BoxState.BOMBED);
				
			}
			else
			{
				data.setEnemyBoxState(shot.Coords.X,shot.Coords.Y,
				                   GameData.BoxState.MISSED);
			}
			
			gameForm.Invalidate();
		}
	}
}
