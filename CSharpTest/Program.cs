using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    public abstract class String
    {
        public abstract void ToString();

        
    }

    public class Person1:String
    {
        public string name;

        public Person1(string x)
        {
            this.name = x;
        }

        public override void ToString()
        {
            Console.WriteLine("Override Name is: {0}",this.name);
        }

      

    }
     public class run
    {
        static void Main(string[] args)
        {
            string[] person1 = { "Vishesh","Rahul","Aditya" };
            string[] person = new string[3];

            for(int i=0;i<person.Length;i++)

            {

              person[i] += person1[i];

            }

            for (int i = 0; i < person.Length; i++)

            {

                Console.WriteLine(person[i]);

                

            }

            Person1 p1 = new Person1("Aryan");

            p1.ToString();

            Console.ReadKey();



        }

    }
    }

