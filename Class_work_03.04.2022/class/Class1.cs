using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Intro
{
    class Student
    {
        const int MaxCourse = 4;
        string name="Noname";
        string specialiaz;
        int course;
        int[] marks;
        
        public Student(string name,string specialiaz,int course)
        {
            this.name = name;
            this.specialiaz = specialiaz;
            this.course = course;
        }
        public Student(string name="Noname")
            :this(name,"Unown",1)
        { }
        public int Course
        {
            get => course;
            set => course = value >= 1 && value <= MaxCourse ? value : throw new Exception("Error");
        }
        public void AddMark(int mark)
        {
            Array.Resize(ref marks, marks.Length + 1);
        }
        public void Print()
        {
            Console.WriteLine($"Name :{name,-10}Spec: {specialiaz,-10}Course :{course,-10}");
        }
        public void SetName(string name)
        {
            if (!String.IsNullOrWhiteSpace(name))
                this.name = name;
        }
        public string Name
        {
            get { return name; }
            set { SetName(value); }
           
        }
        public double AbgMark
        {
            get => marks.Length != 0 ? marks.Average() : 0;
            set => AddMark(value);
        }
        public override string ToString()
        {
            return $"NAME :{name,-10}Spec: {specialiaz,-10}Course :{course,-10}Marks :{String.Join(", ",marks)}";
        }

    }
}
