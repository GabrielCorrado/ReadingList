﻿namespace Core.Entities.BookAggregate
{
    public class BookAuthor
    {
        public BookAuthor(int roleId, int bookId, int authorId)
        {
            AuthorRoleId = roleId;
            BookId = bookId;
            AuthorId = authorId;
        }

        public int BookAuthorId { get; set; }
        //[Required]
        public int BookId { get; set; }
        //[Required]
        public int AuthorId { get; set; }
        //[Required]
        public int AuthorRoleId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Author Author { get; set; }
        public virtual AuthorRole AuthorRole { get; set; }
    }
}