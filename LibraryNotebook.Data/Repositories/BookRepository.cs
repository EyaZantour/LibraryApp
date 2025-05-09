using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryNotebook.Data.Context;
using LibraryNotebook.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryNotebook.Data.Repositories
{
    public class BookRepository
    {
        private readonly LibraryContext _context;
        public BookRepository(LibraryContext context) => _context = context;

        public List<Book> GetAll()
        {
            return _context.Books.ToList();
        }
        public void Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = _context.Books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }


        public Book GetById(int id)
        {
            return _context.Books.FirstOrDefault(b => b.Id == id);
        }

        public void Update(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }

    }
}
