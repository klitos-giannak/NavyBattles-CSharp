/*
 * Created by SharpDevelop.
 * User: delta-lab
 * Date: 12/5/2015
 * Time: 5:21 μμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Newtonsoft.Json;
using NavyBattles_CSharp.Data;

namespace NavyBattles_CSharp
{
	/// <summary>
	/// This is a class that describes a shot made from one player to the other.
	/// It will be possible to convert this into json format to be sent through the network
	/// The json representation will be as the following example
	/// {
	///		"coords" : {
	///			"x" : 1, 
	///			"y" : 2
	///		},
	///		"confirmed" : "true" ,
	///		"hit" :"true"
	///	}
	/// </summary>
	public class Shot
	{
		private Coords coords;
		private bool confirmed;
		private bool hit;
		
		public Shot(Coords coords)
		{
			this.coords = coords;
			confirmed = false;
			hit = false;
		}
		
		#region properties
		public Coords Coords
		{
			get { return coords; }
		}
		
		public bool Confirmed
		{
			get { return confirmed; }
		}
		
		public bool Hit
		{
			get { return hit; }
			set 
			{
				hit = value;
				confirmed = true;
			}
		}
		#endregion
		
		public string toJson()
		{
			//xrisi tou json.net gia metatropi tou antikeimenou mas se json string.
			return JsonConvert.SerializeObject(this);
		}
		
		public static Shot jsonToShot(string json)
		{
			// xrisi tou json.net gia metatropi tou string json se Shot object.
			return JsonConvert.DeserializeObject<Shot>(json);;
		}
		
	}
}
