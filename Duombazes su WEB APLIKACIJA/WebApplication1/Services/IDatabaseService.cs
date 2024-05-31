using Duombazes_su_WEB_APLIKACIJA.WebApplication1.Models;

namespace Duombazes_su_WEB_APLIKACIJA.WebApplication1.Services
{
    public interface IDatabaseService
    {
        IEnumerable<Authors> GetAllAuthors();
        IEnumerable<Books> GetAllBooks();
        IEnumerable<BookCopies> GetAllBookCopies();
        








        void DeleteRecord3(string LastName);
        void UpdateAuthors(Authors authors);
        void UpdateBooks(Books books);
        void UpdateBookCopies(BookCopies bookCopies);
        void InsertAuthors(string LastName);
        void InsertBooks(string Title);
        void DeleteRecordType2(int PublicationYear);
        void InsertBookCopies(string Condition);
        void DeleteRecordType1(string Condition);
       
    }
}