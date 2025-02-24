using LibraryBookServiceApi.cs.Models;
using Microsoft.Extensions.Caching.Memory;

namespace LibraryBookServiceApi.cs.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly IMemoryCache _cache;

        public LibraryService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public Task<AddBookResponse> AddBook(BookModel book)
        {
            var existing = _cache.Get(book.Id);
            if (existing != null)
            {
                return Task.FromResult(new AddBookResponse(ResponseResult.Failed));
            }

            _cache.Set(book.Id, book);

            return Task.FromResult(new AddBookResponse(ResponseResult.Succes, book.Id));
        }

        public Task DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BookModel> GetBookById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BookModel>> GetBooks()
        {
            throw new NotImplementedException();
        }

        public Task UpdateBook(BookModel book)
        {
            throw new NotImplementedException();
        }
    }
}
