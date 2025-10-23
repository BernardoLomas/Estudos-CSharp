using System.Collections.Generic;

namespace WorkBJA
{
    class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Stack<Student> StudentStack = new Stack<Student>();

            Student xStudent;

            xStudent = new Student();
            xStudent.Id = "893969";
            xStudent.Name = "Bernardo Lomas";
            xStudent.Mail = "bernardo.lomasb@gmail.com";
            StudentStack.Push(xStudent);

            xStudent = new Student();
            xStudent.Id = "88888";
            xStudent.Name = "ccccccccccc";
            xStudent.Mail = "ccccccccccc";
            StudentStack.Push(xStudent);

            xStudent = new Student();
            xStudent.Id = "777777";
            xStudent.Name = "dddddddddd";
            xStudent.Mail = "ddddddddddd";
            StudentStack.Push(xStudent);


            ShowStudents(StudentStack);
            Console.WriteLine($"Número de elementos: {StudentStack.Count}");

        }
        static void ShowStudents(Stack<Student> Student)
        {
            Console.Write("\n");
            
            foreach(Student x in Student)
            {
                Console.WriteLine($"Nome: {x.Name}\n Matrícula: {x.Id}\n Email: {x.Mail}");
            }
        }
    }

}

