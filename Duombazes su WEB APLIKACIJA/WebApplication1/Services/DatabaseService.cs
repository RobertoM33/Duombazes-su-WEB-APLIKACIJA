using Dapper;
using Duombazes_su_WEB_APLIKACIJA.WebApplication1.Models;
using System.Data;
using System.Data.SqlClient;

namespace Duombazes_su_WEB_APLIKACIJA.WebApplication1.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly string _connectionString;
        public DatabaseService(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<Authors> GetAllAuthors()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                const string sql = @"
                SELECT FirstName AS 'FirstName', LastName AS 'LastName', BirthDate, Country 
                FROM Authors";
                return db.Query<Authors>(sql);
            }
        }
        public void DeleteRecord3(string LastName)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                const string sql = "DELETE FROM Authors WHERE LastName LIKE 'Kentas';";
                db.Execute(sql, LastName);
            }
        }
        public void InsertBookCopies(string Condition)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                const string sql = "INSERT INTO BookCopies (Condition) VALUES ('NAUJA');";
                db.Execute(sql, Condition);
            }
        }
        public void InsertTestObject1Alternative(Authors LastName)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                const string sql = "INSERT INTO Authors (LastName) VALUES ('Makaronas');";
                db.Execute(sql, LastName);
            }
        }

        public IEnumerable<Books> GetAllBooks()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                const string sql = @"
                SELECT Title AS 'Title', PublicationYear AS 'PublicationYear', Genre, AuthorID 
                FROM Books;";

                return db.Query<Books>(sql);
            }
        }
        public IEnumerable<BookCopies> GetAllBookCopies()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                const string sql = @"
                SELECT BookId AS 'BookId ', Condition AS 'Condition', Price, InStock 
                FROM BookCopies";
                return db.Query<BookCopies>(sql);
            }
        }
        public void InsertBooks(string Title)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                const string sql = "INSERT INTO Books  (Title) (PublicationYear) (Genre) (AuthorsID)  VALUES ('Rolfas Giriose', 2005, , 'Nuotykiu', 15);";
                db.Execute(sql, Title);
            }
        }
        public void DeleteRecordType1(string Condition)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                const string sql = "DELETE FROM BookCopies WHERE Id=1;";
                db.Execute(sql, Condition);
            }
        }

        public void InsertAuthors(string LastName)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                const string sql = "INSERT INTO Authors (LastName) VALUES ('Maklajus');";
                db.Execute(sql, LastName);
            }
        }
        public void DeleteRecordType2(int PublicationYear)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                const string sql = "DELETE FROM Books WHERE PublicationYear < 1985;";
                db.Execute(sql, PublicationYear);
            }
        }
        public void UpdateAuthors(Authors authors)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                const string sql = "UPDATE Authors \r\nSET FirstName = 'Rodas',  LastName = 'Stiuardas', BirthDate = '1974-03-07', Country = 'Menesota'\r\nWHERE id =5;";

                db.Execute(sql, authors);
            }
        }
        public void UpdateBooks(Books PublicationYear)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                const string sql = "BEGIN TRANSACTION\r\nUPDATE Books\r\nSET PublicationYear = CURRENT_TIMESTAMP - 25\r\nWHERE Id =2;";

                db.Execute(sql, PublicationYear);
            }
        }
        public void UpdateBookCopies(BookCopies Price)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                const string sql = "BEGIN TRANSACTION\r\nUPDATE BookCopies\r\nSET Price = 18.25\r\nWHERE Id =4;";

                db.Execute(sql, Price);
            }
        }
      }
    }

    
    

        

       



     

       


      

       

      

      
        

     


      


        
    
    
