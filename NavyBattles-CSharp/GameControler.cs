/*
 * Created by SharpDevelop.
 * User: delta-lab
 * Date: 12/5/2015
 * Time: 5:58 μμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using NavyBattles_CSharp;
using NavyBattles_CSharp.Data;

namespace NavyBattles_CSharp
{
	/// <summary>
	/// Description of GameControler.
	/// </summary>
	public class GameControler
	{
		private NetworkController net;
		private GameData data;
		private GameAreaForm gameForm;
		private bool meReady;
		private bool otherReady;
		private bool firstPlayer;
		
		
		
		public GameControler(NetworkController network)
		{
			net = network;
			data=new GameData();
			gameForm=new GameAreaForm(this,data);
			meReady=false;
			otherReady=false;
		}
		
		private void startGame()
		{
			if(firstPlayer) 
			{
				gameForm.enablePlay(true);
			}
			else
			{
				net.receiveShot();
			}
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
			net.sendStatusIAmReady();
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
			net.sendShot(shot);
			
		}
		
		/// <summary>
		/// kaleitai ap to duktio pros epivevaiwsh ths volhs mas
		/// k enhmerwnei to diko mas enemyGrid tou UI.
		/// </summary>
		/// <param name="shot"></param>
		
		public bool shotResult(Shot shot)
		{
			if(shot.Confirmed == false)
				//this is an error handling and the false means that the game is over
				return false;
							
				
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
			
			return !checkEndGame();
		}
		
		public void endOrPlay()
		{
			if(!checkEndGame())
				gameForm.enablePlay(true);
			
		}
		
		private bool checkEndGame()
		{
			int myHitCounter=0;
			int enemyHitCounter=0;
			for(int i=0; i<10;i++)
			{	
				for(int j=0; j<10; j++)
				{
					if (data.getMyBoxState(i,j) == GameData.BoxState.BOMBED)
						myHitCounter++;
					if(data.getEnemyBoxState(i,j) == GameData.BoxState.BOMBED)
						enemyHitCounter++;
				}
			}
			
			if(enemyHitCounter==GameData.MAXHITS)
			{
				MessageBox.Show(" YOU WIN ");
				return true;
			}
	 		else if(myHitCounter==GameData.MAXHITS)
	 		{
	 			MessageBox.Show(" YOU LOSE  ");	
	 			return true;
	 		}
	 		else 
	 			return false;
	 		
		}
		
		public void playFirst(bool first)
		{
							
			firstPlayer=first;	
							
			
		}
		
		
		
	}
	
	
	
	
}

