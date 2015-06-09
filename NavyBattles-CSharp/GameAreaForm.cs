/*
 * Created by SharpDevelop.
 * User: delta-lab
 * Date: 4/5/2015
 * Time: 8:41 μμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using NavyBattles_CSharp.Data;

namespace NavyBattles_CSharp
{
	/// <summary>
	/// Description of GameAreaForm.
	/// </summary>
	public partial class GameAreaForm : Form
	{
		private Point location;
		private GameControler gameControler;
		private GameData data;
		private PictureBox[,] myBombs;
		private PictureBox[,] enemyBombs;
		
		public GameAreaForm(GameControler gameControler,GameData data)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.gameControler=gameControler;
			this.data=data;

			myBombs = new PictureBox[myBoard.getGridSize(),myBoard.getGridSize()];
			enemyBombs = new PictureBox[enemyBoard.getGridSize(),enemyBoard.getGridSize()];
			
			for(int i=0 ; i<myBoard.getGridSize() ; i++)
			{
				for(int  j=0 ; j<myBoard.getGridSize() ; j++)
				{
					myBombs[i,j] = new PictureBox();
					Coords coords = myBoard.getGridCoords(i,j);
					myBombs[i,j].Location = new Point(coords.X+myBoard.Location.X, coords.Y+myBoard.Location.Y);
					this.Controls.Add(myBombs[i,j]);
					
					enemyBombs[i,j] = new PictureBox();
					coords = enemyBoard.getGridCoords(i,j);
					enemyBombs[i,j].Location = new Point(coords.X+enemyBoard.Location.X, coords.Y+enemyBoard.Location.Y);
					this.Controls.Add(enemyBombs[i,j]);
				}
			}
			
			data.setMyBoxState(5,5, GameData.BoxState.BOMBED);
			data.setEnemyBoxState(7,7, GameData.BoxState.MISSED);
					
		}
		
		void ShipMouseMove(object sender, MouseEventArgs e)
		{
			if (location!=Point.Empty)
			{
				PictureBox ship=sender as PictureBox;
				Point newLocation=ship.Location;
				newLocation.X+=e.X-location.X;
				newLocation.Y+=e.Y-location.Y;
				ship.Location=newLocation;
			}
		}
		
		void ShipMouseUp(object sender, MouseEventArgs e)
		{
			if (location!=Point.Empty)
			{
				PictureBox ship=sender as PictureBox;
				Point loc=ship.Location;
				if(loc.X > myBoard.Location.X && loc.X <= myBoard.Location.X + myBoard.Width
				  && loc.Y > myBoard.Location.Y && loc.Y <= myBoard.Location.Y + myBoard.Height )
				{
					int gridx=myBoard.convertWindowToGridXCoordinate(loc.X-myBoard.Location.X);
					int gridy=myBoard.convertWindowToGridYCoordinate(loc.Y-myBoard.Location.Y);
//					MessageBox.Show(gridx + "\n" + gridy);
					
					Coords blockCoords = myBoard.getGridCoords(gridx, gridy);
					Point newLocation = new Point(blockCoords.X + myBoard.Location.X, blockCoords.Y + myBoard.Location.Y);
					ship.Location = newLocation;
				}	
			}
			location=Point.Empty;
			
		}
		
		void ShipMouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button==MouseButtons.Left) 
			{
				location=new Point (e.X,e.Y);
			}
			else
			{
				PictureBox ship = sender as PictureBox;
				int width=ship.Width;
				int height=ship.Height;
				ship.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
				ship.Width=height;
				ship.Height=width;
				ship.Invalidate();
			}
		}
		
		public void enablePlay(bool play)
		{
			// enable or disable play
		}
		
		void StartGameButtonClick(object sender, EventArgs e)
		{
			if(allShipsLocated())
			{
				gameControler.iAmReady();
				startGameButton.Hide();
			}
			else 
			{
				MessageBox.Show("RE ANTE TOPOTHETHSE TA PLOIA");
			}
			
		}
		private bool allShipsLocated()
		{
			//check if all ships are located to the grid
			return true;
		}
		
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
//			ResourceManager resources = new ResourceManager("NavyBattles-CSharp.Resource1.resx", Assembly.GetExecutingAssembly());
			for(int i=0 ; i<myBoard.getGridSize() ; i++)
			{
				for(int  j=0 ; j<myBoard.getGridSize() ; j++)
				{
					if(data.getMyBoxState(i,j)==GameData.BoxState.BOMBED)
					{
//						myBombs[i,j].Image = (Bitmap)resources.GetObject("bombed.png");
					}
					else if(data.getMyBoxState(i,j)==GameData.BoxState.MISSED)
					{
//						myBombs[i,j].Image = (Bitmap)resources.GetObject("missed.png");
					}
					
					if(data.getEnemyBoxState(i,j)==GameData.BoxState.BOMBED)
					{
//						enemyBombs[i,j].Image = (Bitmap)resources.GetObject("bombed.png");
					}
					else if(data.getEnemyBoxState(i,j)==GameData.BoxState.MISSED)
					{
//						enemyBombs[i,j].Image = (Bitmap)resources.GetObject("missed.png");
					}
				}
			}
		}
	}
}
