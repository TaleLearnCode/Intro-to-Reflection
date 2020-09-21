using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Intro_to_Reflection
{
	
	public class Automobile : CoveredEntity
	{

		public string Make { get; set; }

		public string Model { get; set; }

		public string Color { get; set; }

		public string LicensePlate { get; set; }

		public string SetMyValueNow { get; set; }

		public DateTime SetMyClock { get; set; } = DateTime.UtcNow;

		public Automobile()
		{
			EntityType = "Automobile";
		}

	}

}