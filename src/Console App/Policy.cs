using System;
using System.Collections.Generic;
using System.Text;

namespace Intro_to_Reflection
{

	public class Policy
	{

		public string Number { get; set; }

		public List<CoveredEntity> CoveredEntities { get; } = new List<CoveredEntity>();

	}

}