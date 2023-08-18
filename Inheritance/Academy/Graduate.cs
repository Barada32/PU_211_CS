using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	/*sealed*/ class Graduate:Student
	{
		public string Subject { get; set; }
		public Graduate
			(
			string lastName, string firstName, int age,
			string speciality, string group, double rating, double attendance,
			string subject
			) : base(lastName, firstName, age, speciality, group, rating, attendance)
		{
			Subject = subject;
		}
		public override string ToString()
		{
			return base.ToString() + ",\t " + Subject;
		}
		public /*sealed*/ override void Print()
		{
			base.Print();
			Console.WriteLine("Subject:\t" + Subject);
		}
	}
}
