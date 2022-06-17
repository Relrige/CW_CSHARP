using System;

namespace Class_Intro
{
    
    class Program
{
    static void Main(string[] args)
    {
            Student anna = new ("Ann", "cs", 2);
            anna.Print();

            Student nobody= new ();
            nobody.SetName("Olena");
            nobody.Course = 4;
            nobody.Print();

            Student petro = new Student(name: "Petro", course: 3, specialiaz: "IT");
            petro.Name="Petro P.";
            petro.AddMark(1);
            petro.Print();

    
        }
}
}
