using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Student 
    {
        public string name;
        public string course;
        public int feepaid;
        public int rollno;
        public static double servicetax;
        public static int _totalfee;
        public static int _dueAmount;
        

        public Student(string x,int y,string z)
        {
            this.name = x;
            this.rollno = y;
            this.course = z;
        }

        public void payment(int a)
        {
            this.feepaid = a;
            Console.WriteLine("ASP.NET course fee paid.");
            Console.WriteLine(@"Paid amount is: {0}",this.feepaid);
        }

        public void print()
        {
            Console.WriteLine("Print Method is executed");
        }

        public int TotalFee
        {
            set { _totalfee = value; }
            get { return _totalfee; }
        }

        public void setDueAmountM()
        {
            _dueAmount = _totalfee-this.feepaid;
        }

        public int getDueAmountM()
        {
            return _dueAmount;
        }

        //   public int DueAmount
        //{

        //    get { return _dueAmount; }
        //}

        public static void ServiceTax()
        {

            servicetax = 12.3 * (_totalfee / 100);



        }

        static void Main(string[] args)
        {
            Student s1 = new Student("Vishesh",1,"C#");

            s1.print();

            s1.payment(1000);

            s1.TotalFee = 2000;

            s1.setDueAmountM();

            Student.ServiceTax();

            Console.WriteLine(@"Total Fee Paid: {0}",_totalfee);

            Console.WriteLine("Due Amount is: {0}",_dueAmount);

            Console.WriteLine("Service Tax Amount to be paid by student: {0}", servicetax);



            Console.ReadKey();


        }
    }
}
