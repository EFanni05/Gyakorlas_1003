using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas_1003
{
    internal class Mentor:Person
    {
		private string level;

		public string Level
		{
			get { return level; }
			set { level = value; }
		}

		public Mentor()
		{
            Name = "Jane Doe";
            Age = 30;
            Gender = "Female";
			Level = "Intermediate";
        }

		public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
		{

		}

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} {Level} mentor");
        }
    }
}
