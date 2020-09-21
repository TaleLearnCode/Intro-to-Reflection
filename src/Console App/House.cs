using System;
using System.Collections.Generic;
using System.Text;

namespace Intro_to_Reflection
{
	
	public class House : CoveredEntity
	{

		public string StreetAddress { get; set; }

		public int SquareFeet { get; set; }

		public DateTime LastInitizedDate { get; }

		public House()
		{
			EntityType = "House";
			LastInitizedDate = DateTime.UtcNow;
		}

	}

}