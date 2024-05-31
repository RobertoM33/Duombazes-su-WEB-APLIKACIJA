using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duombazes_su_WEB_APLIKACIJA.WebApplication1.Models
{
    public class BookCopies
    {
       
        public int id {  get; set; }
        public int BookId { get; set; }
        public string Condition { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
    }
}
