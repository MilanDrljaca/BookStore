using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Models;

namespace WebGentle.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetbookById(int id)
        {
            return DataSource().Where(x=> x.Id==id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(x=> x.Title.Contains(title) && x.Author.Contains(author)).ToList();
        }

        private  List<BookModel>DataSource ()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1 , Title="MVC",Author="glavonja", Description="This is description for MVC book"},
                new BookModel(){Id=2 , Title="dot net core",Author="nitish", Description="This is description for dot net core book"},
                new BookModel(){Id=3 , Title="C#",Author="monika", Description="This is description for C# book"},
                new BookModel(){Id=4 , Title="Java",Author="webgentle", Description="This is description for Java book"},
                new BookModel(){Id=5 , Title="PHP",Author="glavonja", Description="This is description for PHP book"},


            };
        }
    }
}
