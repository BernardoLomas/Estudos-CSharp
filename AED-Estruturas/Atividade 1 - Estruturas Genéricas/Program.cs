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
            List<Student> StudentList = new List<Student>();

            Student xStudent;

            xStudent = new Student();
            xStudent.Id = "893969";
            xStudent.Name = "Bernardo Lomas";
            xStudent.Mail = "bernardo.lomasb@gmail.com";

            StudentList.Add(xStudent); // Adiciona sempre no final da lista

            xStudent = new Student();
            xStudent.Id = "11111111";
            xStudent.Name = "bbbbbbbb";
            xStudent.Mail = "bbbbbb";

            StudentList.Add(xStudent);

            xStudent = new Student();
            xStudent.Id = "222222";
            xStudent.Name = "cccccc";
            xStudent.Mail = "ccccccc";

            StudentList.Add(xStudent);

            ShowStudents(StudentList);

        }
        static void ShowStudents(List<Student> xStudent)
        {
            Console.Write("\n");
            
            foreach(Student x in xStudent)
            {
                Console.WriteLine($"Nome: {x.Name}\n Matrícula: {x.Id}\n Email: {x.Mail}");
            }
        }
    }

}

