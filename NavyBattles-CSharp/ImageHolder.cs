/*
 * Created by SharpDevelop.
 * User: klitos
 * Date: 6/10/2015
 * Time: 12:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;

namespace NavyBattles_CSharp
{
	/// <summary>
	/// Description of ImageHolder.
	/// </summary>
	public class ImageHolder
	{
		private Image bombed;
		private Image missed;
		public ImageHolder(ComponentResourceManager resources)
		{
			bombed = (Image)resources.GetObject("bombed");
			missed = (Image)resources.GetObject("missed");
		}
		
		public Image getBombedImage()
		{
			return bombed;
		}
		
		public Image getMissedImage()
		{
			return missed;
		}
	}
}
