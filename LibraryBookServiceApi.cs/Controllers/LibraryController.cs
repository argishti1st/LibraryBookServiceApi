using LibraryBookServiceApi.cs.Models;
using LibraryBookServiceApi.cs.Services;
using LibraryBookServiceApi.Models.ApiModels;
using Microsoft.AspNetCore.Mvc;

namespace LibraryBookServiceApi.cs.Controllers
{
    [Route("api/[controller]/")]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> AddBook([FromBody] BookApiModel book)
        {
            var addBookResponse = await _libraryService.AddBook(Map(book));
            if (addBookResponse.Result == ResponseResult.Succes)
            {
                return Ok(addBookResponse.Id);
            }

            return StatusCode(500);
        }

        [HttpGet]

        private BookModel Map(BookApiModel book)
        {
            return new BookModel(Guid.NewGuid(), book.Title, book.Author, book.DateOfPublication);
        }
    }
}
