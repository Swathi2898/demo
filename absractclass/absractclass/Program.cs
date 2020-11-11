using System;

namespace absractclass
{
    abstract class person
    {
        public string FirstName;
        public string LastName;
        public int age;
        public long PhoneNumber;

        public abstract void PrintDetails();

    }
    class student : person
    {
        public int RollNo;
        public int Fees;
        public override void PrintDetails()
        {
            string name = this.FirstName + "" + this.LastName;
            Console.WriteLine("Student Name Is: {0}", name);
            Console.WriteLine("Student Age Is: {0}", this.age);
            Console.WriteLine("Student Phone Number Is: {0}", this.PhoneNumber);
            Console.WriteLine("Student Roll No Is: {0}", this.RollNo);
            Console.WriteLine("Student Fees Is: {0}", this.Fees);
        }
    }
    class teacher : person
    {
        public string qualification;
        public int Salary;
        public override void PrintDetails()
        {
            string name = this.FirstName + "" + this.LastName;
            Console.WriteLine("Teacher Name Is: {0}", name);
            Console.WriteLine("Teacher Age Is: {0}", this.age);
            Console.WriteLine("Teacher Phone Number Is: {0}", this.PhoneNumber);
            Console.WriteLine("Teacher Qualification Is: {0}", this.qualification);
            Console.WriteLine("Teacher Salary Is: {0}", this.Salary);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student swathi = new student();
            swathi.FirstName = "swathi";
            swathi.LastName = "Alapati";
            swathi.age = 23;
            swathi.PhoneNumber = 23662788;
            swathi.RollNo = 111;
            swathi.Fees = 5000;
            swathi.PrintDetails();
            Console.WriteLine("-----------");

            teacher john = new teacher();
            john.FirstName = "swathi";
            john.LastName = "Alapati";
            john.age = 25;
            john.PhoneNumber = 23662788;
            john.qualification = "Masters in computer science";
            john.Salary = 50000;
            john.PrintDetails();
            Console.ReadLine();
        }
    }
}
