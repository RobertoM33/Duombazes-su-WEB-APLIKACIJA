using Duombazes_su_WEB_APLIKACIJA.WebApplication1.Models;
using Duombazes_su_WEB_APLIKACIJA.WebApplication1.Services;
//using WebApplication1.Services;

IDatabaseService databaseService = new DatabaseService("Server=WKS-1BN-13;Database=sakila;Integrated Security=True;");

List<Authors> autors = (databaseService.GetAllAuthors()).ToList();

foreach (Authors author in autors)
{
    Console.WriteLine($"{author.FirstName}  {author.LastName}  {author.BirthDate}");
   
}
databaseService.GetAllAuthors();
List<Books> book = (databaseService.GetAllBooks()).ToList();
{
    foreach (Books knyga in book)
    {
        Console.WriteLine($" {knyga.Title} {knyga.PublicationYear} {knyga.Genre} {knyga.AuthorID}");
        
    }
    databaseService.GetAllBookCopies();

    List<BookCopies> Kopijos = (databaseService.GetAllBookCopies()).ToList();
    {
        foreach (BookCopies kopija in Kopijos)
        {
            Console.WriteLine($" {kopija.Condition} {kopija.Price} {kopija.InStock} {kopija.id}");
        }
    }
}
