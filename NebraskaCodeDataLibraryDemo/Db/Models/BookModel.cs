using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NebraskaCodeDataLibraryDemo.Db.Models
{
	public class BookModel
	{
		public int BookId { get; set; }
		public string Title { get; set; }
		public string AuthorFirstName { get; set; }
		public string AuthorLastName { get; set; }
		public int PrintLength { get; set; }
		public string Publisher { get; set; }
		public DateTime PublicationDate { get; set; }
		public int ISBN { get; set; }
		public int ReviewRating { get; set; }
		//public string AuthorMiddleName { get; set; }
		//public int CategoryId { get; set; } // Young Readers, children, adult, etc..
		//public int SubCategoryId { get; set; } // Fiction, non-Fiction, fantasy, sci-fi, etc..
		//public string CreatedUser { get; set; }
		//public string UpdatedUser { get; set; }
		//public DateTime CreatedDate { get; set; }
		//public DateTime UpdatedDate { get; set; }
	}
}
