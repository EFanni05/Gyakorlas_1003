// See https://aka.ms/new-console-template for more information
using Gyakorlas_1003;
List<Person> people = new List<Person>();
Person mark = new Person("Mark", 46, "male"); 
people.Add(mark);
Person jane = new Person(); 
people.Add(jane); 
Student john = new Student("John Doe", 20, "male", "BME");
people.Add(john);
Student student = new Student(); 
people.Add(student); 
Mentor gandhi = new Mentor("Gandhi", 148, "male", "senior"); 
people.Add(gandhi);
Mentor mentor = new Mentor(); 
people.Add(mentor); 
Sponsor sponsor = new Sponsor(); 
people.Add(sponsor); 
Sponsor elon = new Sponsor("Elon Musk", 46, "male", "SpaceX");
people.Add(elon);
student.Skipdays(3); 
for (int i = 0; i < 5; i++)
{
    elon.Hire(); 
}
for (int  i = 0; i < 3; i++) 
{ 
    sponsor.Hire(); 
}
for (int i = 1; i <= people.Count; i++) 
{
    people[i].Introduce();
    people[i].GetGoal(); 
}
Cohort awesome = new Cohort("AWESOME");
awesome.AddStudents(student);
awesome.AddStudents(john); 
awesome.AddMentor(mentor);
awesome.AddMentor(gandhi); 
awesome.Info();
