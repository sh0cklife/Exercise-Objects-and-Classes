using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Students
{
    public class Student
    {
        //fields
        public string firstName;
        public string lastName;
        public double grade;
        //properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        //constructor
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
    }
}
