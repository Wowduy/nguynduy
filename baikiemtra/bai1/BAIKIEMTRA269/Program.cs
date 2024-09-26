
using System;
namespace InheritanceExample
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }
    public class Student : Person
    {
        public string StudentID { get; set; }

      
        public override void ShowInfo()
        {
            base.ShowInfo(); 
            Console.WriteLine($"Student ID: {StudentID}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "nguyen duy",
                Age = 20,
                StudentID = "22810310021" 
            };

            student.ShowInfo();
        }
    }
}
