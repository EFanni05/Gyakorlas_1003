using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas_1003
{
	internal class Person
	{
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		private string gender;

		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		public Person(string vs, int vs1, string vs2)
		{
			Name = vs;
			Age = vs1;
			Gender = vs2;
		}

		public Person()
		{
			Name = "Jane Doe";
			Age = 30;
			Gender = "Female";
		}

		public virtual void GetGoal()
		{
			Console.WriteLine("my goal is: Live for the moment!");
		}

		public virtual void Introduce()
		{
			Console.WriteLine($"Hi!, I'm {Name} a {Age} year old {Gender}");
		}
	}
}
