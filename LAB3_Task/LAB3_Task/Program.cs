using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_Task
{
    class Student
    {
        private string name;
        private string id;
        private string dept;
        private float cgpa;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        public void showinfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Dept: " + dept);
            Console.WriteLine("CGPA: " + cgpa);
        }
    }

    class Triangle
    {
        private int x;
        private int y;
        private int z;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return y; }
            set { z = value; }
        }
        public void showinfo()
        {
            Console.WriteLine("X: " +x);
            Console.WriteLine("Y: " +y);
            Console.WriteLine("Z: " +z);
        }
    }


    class Account
    {
        private string accName;
        private string acid;
        private int balance;
        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        public string Acid
        {
            get { return acid; }
            set { acid = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void showinfo()
        {
            Console.WriteLine("AccName: "+accName);
            Console.WriteLine("Acid: "+acid);
            Console.WriteLine("Balance: "+Balance);
        }
    }
    class Course
    {
        private string coursename;
        private string coursecode;
        private int coursecredit;

        public string CourseName
        {
            get { return coursename; }
            set { coursename = value; }
        }
        public string CourseCode
        {
            get { return coursecode; }
            set { coursecode = value; }
        }
        public int Coursecredit
        {
            get { return coursecredit ; }
            set { coursecredit = value; }
        }
        public void showinfo()
        {
            Console.WriteLine("CourseName: "+coursename);
            Console.WriteLine("CourseCode: "+coursecode);
            Console.WriteLine("CourseCredit: "+coursecredit);
        }
    }
    class program
     {
        static void Main(string[] args)
         {
                            Student S1 = new Student();
                            S1.Name = "XYZ";
                            S1.Id = "12345678";
                            S1.Dept = "CSE";
                            S1.Cgpa = (float)3.93;

                            S1.showinfo();

                            Triangle T2 = new Triangle();
                            T2.X = 2;
                            T2.Y = 3;
                            T2.Z = 4;

                            T2.showinfo();

                            Account A2 = new Account();
                            A2.AccName = "XYZ";
                            A2.Acid = "12345678";
                            A2.Balance = 3000;


                            A2.showinfo();

                            Course C2 = new Course();
                            C2.CourseCode = "478786";
                            C2.Coursecredit = 3;
                            C2.CourseName = "XYZ";


                            C2.showinfo();

            Console.ReadKey();


        }


    }

 }
