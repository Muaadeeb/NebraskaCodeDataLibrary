using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using NebraskaCodeDataLibraryDemo.Data.Interfaces;
using NebraskaCodeDataLibraryDemo.Db;
using NebraskaCodeDataLibraryDemo.Db.Interfaces;
using NebraskaCodeDataLibraryDemo.Db.Models;

namespace NebraskaCodeDataLibraryDemo.Data
{
	public class BookData : IBookData
	{
		private readonly IDataAccess _dataAccess;
		private readonly ConnectionStringData _connectionStringData;

		public BookData(IDataAccess dataAccess, ConnectionStringData connectionStringData)
		{
			_dataAccess = dataAccess;
			_connectionStringData = connectionStringData;
		}

		public async Task<int> CreateBookAsync(BookModel book)
		{
			DynamicParameters p = new DynamicParameters();

			p.Add("Title", book.Title);
			p.Add("AuthorFirstName", book.AuthorFirstName);
			p.Add("AuthorLastName", book.AuthorLastName);
			p.Add("PrintLength", book.PrintLength);
			p.Add("Publisher", book.Publisher);
			p.Add("PublicationDate", book.PublicationDate);
			p.Add("ISBN", book.ISBN);
			p.Add("ReviewRating", book.ReviewRating);
			//p.Add("AuthorMiddleName", book.AuthorMiddleName);
			//p.Add("CategoryId", book.CategoryId);
			//p.Add("SubCategoryId", book.SubCategoryId);
			//p.Add("CreatedUser", book.CreatedUser);
			//p.Add("UpdatedUser", book.UpdatedUser);
			//p.Add("CreatedDate", book.CreatedDate);
			//p.Add("UpdatedDate", book.UpdatedDate);
			p.Add("BookId", DbType.Int32, direction: ParameterDirection.Output);

			await _dataAccess.SaveData("dbo.CreateBook", p, _connectionStringData.SqlConnectionName);

			return p.Get<int>("BookId");
		}

		public async Task<int> UpdateBookAsync(BookModel book)
		{
			return await _dataAccess.SaveData("dbo.UpdateBook",
				new
				{
					BookId = book.BookId,
					Title = book.Title,
					AuthorFirstName = book.AuthorFirstName,
					AuthorLastName = book.AuthorLastName,
					PrintLength = book.PrintLength,
					Publisher = book.Publisher,
					PublicationDate = book.PublicationDate,
					ISBN = book.ISBN,
					ReviewRating = book.ReviewRating,
					//AuthorMiddleName = book.AuthorMiddleName,
					//CategoryId = book.CategoryId,
					//SubCategoryId = book.SubCategoryId,
					//CreatedUser = book.CreatedUser,
					//UpdatedUser = book.UpdatedUser,
					//CreatedDate = book.CreatedDate,
					//UpdatedDate = book.UpdatedDate
				},
				_connectionStringData.SqlConnectionName);
		}

		public async Task<int> DeleteBookAsync(int bookId)
		{
			return await _dataAccess.SaveData("dbo.DeleteBook",
				new { BookId = bookId},
				_connectionStringData.SqlConnectionName);
		}

		public async Task<IEnumerable<BookModel>> GetBooksBySearchValueAsync(string searchValue)
		{
			var result = await _dataAccess.LoadData<BookModel, dynamic>("dbo.GetBooksBySearchValue",
				new {SearchValue = searchValue},
				_connectionStringData.SqlConnectionName);

			return result;
		}

		public async Task<IEnumerable<BookModel>> GetBookByBookIdAsync(int bookId)
		{
			var result = await _dataAccess.LoadData<BookModel, dynamic>("dbo.GetBookByBookId",
				new { BookId = bookId },
				_connectionStringData.SqlConnectionName);

			return result;
		}

		public async Task<IEnumerable<BookModel>> GetAllBooksAsync()
		{
			var result = await _dataAccess.LoadData<BookModel, dynamic>("dbo.GetAllBooks",
				new {  },
				_connectionStringData.SqlConnectionName);

			return result;
		}
	}
}
