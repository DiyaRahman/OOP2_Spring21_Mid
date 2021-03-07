using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("Computer Science", "Cse");
            Student s2 = new Student("Utsho", "18-38055-2", 2.50f);
            Student s1 = new Student("Diya", "18-38282-2", 3.50f);
            d1.AddStudent(s1);
            d1.AddStudent(s2);
            d1.AllStudents();

            //s1.Department = d1;
            //s1.ShowInfo();


        }
    }
}
