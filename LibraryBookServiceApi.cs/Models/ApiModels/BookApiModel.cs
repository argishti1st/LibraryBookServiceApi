namespace LibraryBookServiceApi.Models.ApiModels
{
    public record BookApiModel(
        string Title,
        string Author,
        DateOnly DateOfPublication);
}
