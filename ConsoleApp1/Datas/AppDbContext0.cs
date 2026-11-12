using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Datas
{
    internal class AppDbContext0
    {
        public Student[] GetAllStudents()
        {
            Student emp1 = new()
            {
                Id = 100,
                Fullname = "Emin Rzayev",
                Age = 19,
                Email = "eminrzayev@gmail.com",
                Address = "Baki",
                Grade = 90,
            };
            Student emp2 = new()
            {
                Id = 200,
                Fullname = "Emil Mirzeyev",
                Age = 24,
                Email = "emilmirzayev@gmail.com",
                Address = "Nizami",
                Grade = 910,
            };
            Student emp3 = new()
            {
                Id = 200,
                Fullname = "Eldar Huseynov",
                Age = 17,
                Email = "eldarhuseynov@gmail.com",
                Address = "Agsu",
                Grade = 10,
            };
            return new Student[] { emp1, emp2, emp3 };
        }
    }
}
