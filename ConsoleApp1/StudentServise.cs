using ConsoleApp1;
using ConsoleApp1.Datas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class StudentServise
    {
        private readonly AppDbContext0 _context = new();
          public Student[] GetStudents()
        {
            return _context.GetAllStudents();
        }
    }
}
  public int Sum()
{
    var result = student.Sum(a => a.Age);
    return result
}