using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NebraskaCodeDataLibraryDemo.Db.Models;

namespace NebraskaCodeDataLibraryDemo.Data.Interfaces
{
	public interface IBookData
	{
		Task<int> CreateBookAsync(BookModel book);
		Task<int> UpdateBookAsync(BookModel book);
		Task<int> DeleteBookAsync(int bookId);
		Task<IEnumerable<BookModel>> GetBooksBySearchValueAsync(string searchValue);
		Task<IEnumerable<BookModel>> GetBookByBookIdAsync(int bookId);
		Task<IEnumerable<BookModel>> GetAllBooksAsync();
	}
}
