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
		public GameAreaForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
	}
}
