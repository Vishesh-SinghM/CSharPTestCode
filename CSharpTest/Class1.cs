using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{

    public class Person
    {
        public string name;

        public Person(string x)
        {
            this.name = x;
        }



        public Person()
        {
            Console.WriteLine("I am a Person parent class constructor");
        }

    }


    public class Student:Person
    {
        public void Study()
        {
            Console.WriteLine("student is studying");
        }

        public Student()
        {
            Console.WriteLine("I am a Student child class constructor");
        }
    }


    public class Teacher:Person
    {
        public void Explain()
        {
            Console.WriteLine("teacher is explaining");
        }

        public Teacher()
        {
            Console.WriteLine("I am Teacher child class constructor");
        }
    }

    public class run2
    {
        static void Main(string[] args)
        {

            Student s = new Student();
            s.Study();
            Teacher t = new Teacher();
            t.Explain();
            Console.ReadKey();
             

        }
    }
}
