using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public static class BookRepository
    {
        public static List<Book> Books = new List<Book>
        {
            new Book {BookId="ABCDEF",Audience="Teen",Category="History",Editor="ABC",Title="Grapes of Wrath", Copies=30, IsActive=true },
            new Book{BookId="XYZABC",Title="The Stand",Audience="Adults",Category="Fiction",Editor="Random House",Copies=75,IsActive=true }
        };
    }
}