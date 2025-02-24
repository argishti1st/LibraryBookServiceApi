﻿using LibraryBookServiceApi.Models;

namespace LibraryBookServiceApi.Services
{
    public interface ILibraryService
    {
        Task<AddBookResponse> AddBook(BookModel book);

        Task<BookModel> GetBookById(int id);

        Task DeleteBook(int id);

        Task<IEnumerable<BookModel>> GetBooks();

        Task UpdateBook(BookModel book);
    }
}
