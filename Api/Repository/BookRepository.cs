using Api.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Repository
{
   public class BookRepository
    {
        private List<Book> books = new List<Book>()
            {
                new Book
                {
                    Id = 1,
                    Title="Rebecca",
                    BookAuthor = new Author
                    {
                        Id = 1,
                        Name ="Daphne Du Maurier"
                    }
                },
                new Book
                {
                    Id=2,
                    Title="A thousand splendid suns",
                    BookAuthor = new Author
                    {
                        Id =2,
                        Name="Khaled Hosseini"
                    }
                },
               new Book
               {
                   Id = 3,
                   Title = "Harry Potter and The Deathly Hallows",
                   BookAuthor= new Author
                   {
                       Id = 3,
                       Name = "J.K.Rowling"
                   }
               }
            };

        public List<Book> GetBooks()
        {
            return books;
        }

        public Book GetBook(int id)
        {
            return books.Find(b => b.Id == id); ;
        }
    }
}
