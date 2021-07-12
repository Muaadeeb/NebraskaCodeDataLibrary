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
		Task<int> CreateBookAsync(Book book);
		Task<int> UpdateBookAsync(Book book);
		Task<int> DeleteBookAsync(int bookId);
		Task<List<Book>> GetBooksBySearchValueAsync(string searchValue);
		Task<Book> GetBookByBookIdAsync(int bookId);
		Task<List<Book>> GetAllBooksAsync();
	}
}
