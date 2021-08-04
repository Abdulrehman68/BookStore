using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks() 
        {
            return DataSourse();
        }

        public BookModel GetBookById(int id)
        {
            return DataSourse().Where(x => x.id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSourse().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();  // contain means like in sql
            //return DataSourse().Where(x => x.Title == title && x.Author == authorName).ToList();    // where statement
        }

        private List<BookModel> DataSourse() 
        {
            return new List<BookModel>()
            {
                new BookModel(){id = 1,Title = "MVC",Author="AR" },
                new BookModel(){id = 2,Title = "JAVA",Author="nitish" },
                new BookModel(){id = 3,Title = "C#",Author="Monika" },
                new BookModel(){id = 4,Title = "PHP",Author="Webgentle" },
                new BookModel(){id = 5,Title = "API",Author="webgentle" },
            };   
        }
    
       
}
}
