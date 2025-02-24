namespace LibraryBookServiceApi.cs.Models
{
    public record AddBookResponse(
        ResponseResult Result,
        Guid? Id = null);
}
