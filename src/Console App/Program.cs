using System;
using System.Reflection;

namespace Intro_to_Reflection
{
	class Program
	{
		static void Main(string[] args)
		{
			var policy = new Policy()
			{
				Number = Guid.NewGuid().ToString()
			};
			policy.CoveredEntities.Add(new Automobile()
			{
				Make = "Mazda",
				Model = "Miata RF",
				Color = "Red",
				LicensePlate = "483-DIA"
			});
			policy.CoveredEntities.Add(new Automobile()
			{
				Make = "Mazda",
				Model = "CX-5",
				Color = "Grey",
				LicensePlate = "390-DDS"
			});
			policy.CoveredEntities.Add(new Automobile()
			{
				Make = "Dodge",
				Model = "Dart",
				Color = "Red",
				LicensePlate = "489-OID"
			});
			policy.CoveredEntities.Add(new House()
			{
				StreetAddress = "PO Box 197028, Louisville, KY 40259",
				SquareFeet = 4562
			});

			WorkingWithReflection(policy);

		}

		static void WorkingWithReflection(Policy policy)
		{
			foreach (var coveredEntity in policy.CoveredEntities)
			{
				Console.WriteLine(coveredEntity.EntityType);
				foreach (PropertyInfo propertyInfo in coveredEntity.GetType().GetProperties())
				{

					if (propertyInfo.Name == nameof(Automobile.SetMyValueNow))
					{
						Console.WriteLine($"{propertyInfo.Name} — {propertyInfo.GetValue(coveredEntity)}");
						propertyInfo.SetValue(coveredEntity, Guid.NewGuid().ToString());
					}

					if (propertyInfo.PropertyType == typeof(DateTime) && propertyInfo.CanWrite)
					{
						Console.WriteLine($"{propertyInfo.Name} — {propertyInfo.GetValue(coveredEntity)}");
						propertyInfo.SetValue(coveredEntity, DateTime.UtcNow.AddDays(10));
					}

					Console.WriteLine($"{propertyInfo.Name} — {propertyInfo.GetValue(coveredEntity)}");

				}
				Console.WriteLine();
			}
		}

	}

}