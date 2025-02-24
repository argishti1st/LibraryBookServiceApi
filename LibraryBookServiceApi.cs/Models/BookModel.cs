namespace LibraryBookServiceApi.Models
{
    public record BookModel(
        Guid Id,
        string Title,
        string Author,
        DateOnly DateOfPublication);
}
