namespace LibraryBookServiceApi.Models
{
    public record AddBookResponse(
        ResponseResult Result,
        Guid? Id = null);
}
