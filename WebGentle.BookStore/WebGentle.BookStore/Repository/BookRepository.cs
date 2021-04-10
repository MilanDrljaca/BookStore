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
                new BookModel(){Id=1 , Title="MVC",Author="glavonja"},
                new BookModel(){Id=2 , Title="dot net core",Author="nitish"},
                new BookModel(){Id=3 , Title="C#",Author="monika"},
                new BookModel(){Id=4 , Title="Java",Author="webgentle"},
                new BookModel(){Id=5 , Title="PHP",Author="glavonja"},


            };
        }
    }
}
