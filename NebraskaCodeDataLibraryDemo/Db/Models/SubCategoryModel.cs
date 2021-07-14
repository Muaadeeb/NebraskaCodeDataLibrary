using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NebraskaCodeDataLibraryDemo.Db.Models
{
	public class SubCategoryModel
	{
		public int SubCategoryId { get; set; }
		public string SubCategoryName { get; set; }
		public int CategoryId { get; set; }
		public string CreatedUser { get; set; }
		public string UpdatedUser { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
	}
}
