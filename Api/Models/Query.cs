using Api.Models;
using Api.Repository;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api
{
   public class Query 
    {
        private BookRepository bookRepository;

        public Query(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public List<Book> GetBooks()
        {
            return bookRepository.GetBooks();
        }

        public Book GetBook(int id)
        {
            return bookRepository.GetBook(id);
        }
    }
}
