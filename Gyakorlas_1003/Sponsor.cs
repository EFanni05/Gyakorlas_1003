using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas_1003
{
    internal class Sponsor:Person
    {
		private string company;

		public string Company
		{
			get { return company; }
			set { company = value; }
		}

		private int hired;

		public int Hired
		{
			get { return hired; }
			set { hired = value; }
		}

		public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
		{
			Company = company;
			Hired = 0;
		}

		public Sponsor()
		{
            Name = "Jane Doe";
            Age = 30;
            Gender = "Female";
			Company = "Google";
			Hired = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} who repesent {Company} and hired {Hired} students so far");
        }

		public void Hire()
		{
			Hired++;
		}
    }
}
