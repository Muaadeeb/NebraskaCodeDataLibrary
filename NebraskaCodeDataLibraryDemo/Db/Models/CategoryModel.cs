using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NebraskaCodeDataLibraryDemo.Db.Models
{
	public class CategoryModel
	{
		public int CategoryId { get; set; }
		public string  CategoryName { get; set; }
		public string CreatedUser { get; set; }
		public string UpdatedUser { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
	}
}
