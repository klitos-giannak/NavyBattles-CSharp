/*
 * Created by SharpDevelop.
 * User: delta-lab
 * Date: 4/5/2015
 * Time: 8:41 μμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
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
		private BombPicture[,] myBombs;
		private BombPicture[,] enemyBombs;
		private ImageHolder imageHolder;
		
		public GameAreaForm(GameControler gameControler,GameData data)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.gameControler=gameControler;
			this.data=data;
			imageHolder = new ImageHolder(new System.ComponentModel
			                              .ComponentResourceManager(typeof(GameAreaForm)));

			myBombs = new BombPicture[myBoard.getGridSize(),myBoard.getGridSize()];
			enemyBombs = new BombPicture[enemyBoard.getGridSize(),enemyBoard.getGridSize()];
			
			for(int i=0 ; i<myBoard.getGridSize() ; i++)
			{
				for(int  j=0 ; j<myBoard.getGridSize() ; j++)
				{
					Coords coords = myBoard.getGridCoords(i,j);
					myBombs[i,j] = new BombPicture
						(coords.X+myBoard.Location.X, coords.Y+myBoard.Location.Y, imageHolder);
					this.Controls.Add(myBombs[i,j]);
					
					coords = enemyBoard.getGridCoords(i,j);
					enemyBombs[i,j] = new BombPicture
						(coords.X+enemyBoard.Location.X, coords.Y+enemyBoard.Location.Y, imageHolder);
					this.Controls.Add(enemyBombs[i,j]);
				}
			}
			
			myBoard.SendToBack();
			enemyBoard.SendToBack();
			
			//test the drawing of bombpictures
			//data.setMyBoxState(5,5, GameData.BoxState.BOMBED);
			//data.setEnemyBoxState(7,7, GameData.BoxState.MISSED);
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
					Direction direction=Direction.HORIZONTAL;
					if(ship.Height > ship.Width)
						direction=Direction.VERTICAL;
					
					int size=0;
					if(ship.Equals(ship1))
						size=2;
					
					else if(ship.Equals(ship2))
						size=3;
					
					else if(ship.Equals(ship3))
						size=4;
					
					else if(ship.Equals(ship4))
						size=5;
					
					else if(ship.Equals(ship5))
						size=6;
					
					Coords startloc =new Coords(gridx,gridy);
					if(islocationvalid(startloc,direction,size))
					{
						Coords blockCoords = myBoard.getGridCoords(gridx, gridy);
						Point newLocation = new Point(blockCoords.X + myBoard.Location.X, blockCoords.Y + myBoard.Location.Y);
						ship.Location = newLocation;
						data.initShip(size,direction,startloc);
					}
					else
						ship.Location=location;
				}	
			}
			location=Point.Empty;
			
		}
		
		private bool islocationvalid(Coords coords,Direction direction,int size)
		{
			return false;
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
			
			for(int i=0 ; i<myBoard.getGridSize() ; i++)
			{
				for(int  j=0 ; j<myBoard.getGridSize() ; j++)
				{
					myBombs[i,j].State = data.getMyBoxState(i,j);	

					enemyBombs[i,j].State = data.getEnemyBoxState(i,j);	
				}
			}
		}
	}
}
