namespace LibraryBookServiceApi.cs.Models
{
    public record BookModel(
        Guid Id,
        string Title,
        string Author,
        DateOnly DateOfPublication);
}
