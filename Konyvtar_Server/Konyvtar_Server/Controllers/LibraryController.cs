using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Konyvtar_Server.Models;
using Konyvtar_Server.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Konyvtar_Server.Controllers
{
    [Route("api/library")]
    [ApiController]
    public class LibraryController : ControllerBase
    {



        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            var books = BookRepository.GetBooks();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> Get(long id)
        {
            var books = BookRepository.GetBooks();
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book != null)
            {
                return Ok(book);
            }
            else
            {
                return NotFound();
            }
        }

        //ez a metódus felel azért hogy jó Id-t kapjon a hozzaadott konyvunk
        private long GetNewId(IList<Book> books)
        {
            long id = 0;
            foreach (var book in books)
            {
                if (id < book.Id)
                {
                    id = book.Id;
                }
            }
            return id + 1;
        }
        [HttpPost]
        public ActionResult Post(Book book)
        {
            var books = BookRepository.GetBooks();
            var newId = GetNewId(books);
            book.Id = newId;
            books.Add(book);
            BookRepository.StorePeople(books);
            return Ok();
        }
        [HttpPut]
        public ActionResult Put(Book book)
        {
            var books = BookRepository.GetBooks();
            var oldBook = books.FirstOrDefault(x => x.Id == book.Id);
            if (oldBook != null)
            {
                oldBook.Id = book.Id;
                oldBook.Title = book.Title;
                oldBook.Author = book.Author;
                oldBook.AvailableQuantity = book.AvailableQuantity;
                oldBook.Quantity = book.Quantity;
                oldBook.patrons = book.patrons;
                oldBook.ReplacementCost = book.ReplacementCost;
            }
            else
            {
                var newId = GetNewId(books);
                book.Id = newId;
                books.Add(book);
            }
            BookRepository.StorePeople(books);
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var books = BookRepository.GetBooks();
            var book = books.FirstOrDefault(x => x.Id == id);
            if(book != null)
            {
                books.Remove(book);
                BookRepository.StorePeople(books);
                return Ok();
            }
            return NotFound();
        }


    }
}