using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExistingDatabase
{
	class Program
	{
		static void Main(string[] args)
		{
			var dbContext = new PlutoContext();
			var course = new Course()
			{
				Id = 3,
				Title="Code First",
				Description ="Code first example with existing database",
				Level = 2,
				FullPrice = (float)36.0,
				



			};
			dbContext.Courses.Add(course);
			dbContext.SaveChanges();
			Console.WriteLine(course.Description);
			
		}
	}
}
