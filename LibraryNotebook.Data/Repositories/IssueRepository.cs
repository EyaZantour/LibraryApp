using System.Collections.Generic;
using System.Linq;
using LibraryNotebook.Data.Context;
using LibraryNotebook.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryNotebook.Data.Repositories
{
    public class IssueRepository
    {
        private readonly LibraryContext _context;

        public IssueRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Add(Issue issue)
        {
            _context.Issues.Add(issue);
            _context.SaveChanges();
        }

        public void Update(Issue issue)
        {
            _context.Issues.Update(issue);
            _context.SaveChanges();
        }

        public Issue GetById(int id)
        {
            return _context.Issues.Include(i => i.Book).FirstOrDefault(i => i.Id == id);
        }

        public List<Issue> GetUnreturnedByStudent(int studentId)
        {
            return _context.Issues
                .Include(i => i.Book)
                .Where(i => i.StudentId == studentId && i.ReturnDate == null)
                .ToList();
        }

        public List<Issue> GetAll()
        {
            return _context.Issues
                .Include(i => i.Book)
                .Include(i => i.Student)
                .ToList();
        }
    }
}
