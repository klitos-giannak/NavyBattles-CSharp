/*
 * Created by SharpDevelop.
 * User: klitos
 * Date: 6/9/2015
 * Time: 11:47 PM
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
	/// Description of BombPicture.
	/// </summary>
	public class BombPicture:PictureBox
	{
		private GameData.BoxState state;
		private ImageHolder imageHolder;
		
		public BombPicture(int x, int y, ImageHolder imageHolder)
		{
			this.imageHolder = imageHolder;
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			BackColor= Color.Transparent;
			Location = new Point(x, y);
			Size = new Size(40,40);
		}
		
		public GameData.BoxState State
		{
			set
			{
				if(state != value){
					state = value;
					updateImage();
				}
			}
			get
			{
				return state;
			}
		}
		
		private void updateImage()
		{
			if(state == GameData.BoxState.BOMBED)
				Image = imageHolder.getBombedImage();
			else if(state == GameData.BoxState.MISSED)				
				Image = imageHolder.getMissedImage();
			else
				Image = null;
		}
	}
}
