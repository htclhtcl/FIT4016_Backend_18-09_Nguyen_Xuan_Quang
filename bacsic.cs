using System;

namespace BasicClass
{
    // Lớp Student
    class Student
    {
        public int StudentId;
        public string Name;
        public double GPA;

        public void Display()
        {
            Console.WriteLine($"ID: {StudentId}, Name: {Name}, GPA: {GPA}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tạo 2 đối tượng Student
            Student s1 = new Student();
            Student s2 = new Student();

            // Gán giá trị
            s1.StudentId = 1;
            s1.Name = "Nguyen Van A";
            s1.GPA = 3.2;

            s2.StudentId = 2;
            s2.Name = "Tran Thi B";
            s2.GPA = 3.8;

            // Gọi Display()
            s1.Display();
            s2.Display();
        }
    }
}
