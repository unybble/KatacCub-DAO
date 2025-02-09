﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace KataClub_DAO
{
    public class BooksImplNew : IBooks
    {

    //list is working as a database
    private List<Book> Books { get; set; }

    public BooksImplNew()
    {
            Books = new List<Book>
            {
                new Book(1, "When We Were Wallflowers"),
                new Book(2, "Bard's Crypt"),
                new Book(3, "Hunting Season"),
                new Book(4, "Clue of the Cold Cottage"),
                new Book(5, "Children of Nebula"),
                new Book(6, "Eye of Iron")
            };
        }

    public List<Book> GetAllBooks()
    {
        return Books;
    }

    public Book GetBookByIsbn(int isbn)
    {
        return Books.Where(x=>x.Isbn==isbn).FirstOrDefault();
    }

    public void SaveBook(Book book)
    {
            Books.Add(book);
    }

    public void DeleteBook(Book book)
    {
            Books.Remove(book);
    }
}
}

