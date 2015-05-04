/*
 * Created by SharpDevelop.
 * User: delta-lab
 * Date: 4/5/2015
 * Time: 8:36 μμ
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
	/// Description of GridView.
	/// </summary>
	public class GridView:Control
	{		
		int cellHeight;
		int cellWidth;
		GameData gd;
		
		public GridView()
		{
			BackColor= Color.Aquamarine;
			gd = new GameData();
		}
		
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Brush brush=new SolidBrush(ForeColor);
			Pen pen=new Pen(brush);
			for ( int i=0; i<=10; i++)
			{
				e.Graphics.DrawLine(pen,29,(i*cellHeight)+29, Size.Width,(i*cellHeight)+29); //horizontal
				e.Graphics.DrawLine(pen,(i*cellWidth)+29,29, (i*cellWidth)+29,Size.Height ); //vertical
			}
			
		}
		
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			
			cellHeight=(Size.Height-30)/10;
			cellWidth=(Size.Width-30)/10;
			Invalidate();
		}
		
		public int convertWindowToGridXCoordinate(int x)
		{
			double gridX = (x-29) / (double) cellWidth;
			if (gridX < 0)
				return -1;
			else
				return (int)gridX;
		}
		
		public int convertWindowToGridYCoordinate(int y)
		{
			double gridY = (y-29) / (double) cellHeight;
			if (gridY < 0)
				return -1;
			else
				return (int)gridY;
		}
	}
}
