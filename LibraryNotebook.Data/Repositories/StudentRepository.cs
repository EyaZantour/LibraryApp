using System.Collections.Generic;
using System.Linq;
using LibraryNotebook.Data.Context;
using LibraryNotebook.Data.Entities;

namespace LibraryNotebook.Data.Repositories
{
    public class StudentRepository
    {
        private readonly LibraryContext _context;

        public StudentRepository(LibraryContext context)
        {
            _context = context;
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
        }

        public Student GetByEnrollment(string enrollmentNo)
        {
            return _context.Students.FirstOrDefault(s => s.EnrollmentNumber == enrollmentNo);
        }

        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Update(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }
    }
}
