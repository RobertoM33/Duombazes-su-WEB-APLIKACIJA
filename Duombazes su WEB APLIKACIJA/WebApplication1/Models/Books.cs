using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duombazes_su_WEB_APLIKACIJA.WebApplication1.Models
{
    public class Books
    {
       
        public int id { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public string Genre { get; set; }
        public int AuthorID { get; set; }
    }

}

