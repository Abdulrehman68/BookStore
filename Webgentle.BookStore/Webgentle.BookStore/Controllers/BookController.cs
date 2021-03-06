using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;
using Webgentle.BookStore.Repository;

namespace Webgentle.BookStore.Controllers
{
    public class BookController : Controller
    {
       //Lecture 14

        private readonly BookRepository _bookRepository = null;

        public BookController() 
        {
            _bookRepository = new BookRepository();

        }

        public ViewResult GetAllBooks()
        {
            var data =  _bookRepository.GetAllBooks();
            return View();
        }
        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBook(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName,authorName);
        
         }


        // Lecture 13
        //public string GetAllBooks()
        //{
        //    return "All books";
        //}
        //public string GetBook(int id)
        //{
        //    return $"book id : {id}";
        //}

        //public string SearchBook(string bookName, string authorName)
        //{ 
        //    return $"book name : {bookName} & Author : {authorName}";
        //    //url for call http://localhost:4780/book/searchbook?bookName=MVCbook&authorName=AR

        //}
    }
}
