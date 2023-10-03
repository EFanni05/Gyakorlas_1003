using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas_1003
{
    internal class Cohort
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private List<Student> students;

		public List<Student> Students
		{
			get { return students; }
			set { students = value; }
		}

		private List<Mentor> mentors;

		public List<Mentor> Mentors
		{
			get { return mentors; }
			set { mentors = value; }
		}

		public Cohort(string name)
		{
			Name = name;
			Students = new List<Student>();
			Mentors = new List<Mentor>();
		}

		public void AddStudents(Student Student)
		{
			students.Add(Student);
		}

		public void AddMentor(Mentor Mentor)
		{
			mentors.Add(Mentor);
		}

		public void Info()
		{
            Console.WriteLine($"The {Name} chort has {students.Count} students and {mentors.Count} mentors");
        }
	}
}
