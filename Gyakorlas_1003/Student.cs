using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas_1003
{
    internal class Student:Person
    {
		private string previousOrganization;

		public string PreviousOrganization
		{
			get { return previousOrganization; }
			set { previousOrganization = value; }
		}

		private int skippedDays;

		public int SkippedDays
		{
			get { return skippedDays; }
			set { skippedDays = value; }
		}

		public Student(string name, int age, string gender, string pre) : base (name, age, gender) 
		{
			PreviousOrganization = pre;
			SkippedDays = 0;
		}

		public Student()
		{
			Name = "Jane Doe";
			Age = 30;
			Gender = "Female";
			PreviousOrganization = "The School of Life";
			SkippedDays = 0;
		}

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer!");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi! I'm {Name}, a {Age} yaer old {Gender} from {PreviousOrganization} who skipped {SkippedDays} days from the course already");
        }

		public void Skipdays(int numberOfDays)
		{
			SkippedDays += numberOfDays;
		}
    }
}
