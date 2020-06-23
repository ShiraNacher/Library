using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library.Bll
{
    public class ClsBooksTable:GeneralTable
    {
        public ClsBooksTable() : base("Books", "BookCode")
        {

        }
        public DataTable GetBookDetails()
		{
            return Dal.ClsDal.GetDisplayTable("SELECT Books.BookCode, Books.BookName,  [Author]![AuthorLastName] & ' ' & [Author]![AuthorFirstName] AS Expr1, Audiences.AudienceName, Books.Description, Books.Language, Books.OriginalLanguage, Books.BookType, BookNames.NumberOfPages, Books.HasSeries, Books.NumberInSeries, BookNames.Publisher, BookNames.DatePublished, BookNames.DateComputerized, Books.StickerName, Books.stickerType, Books.Availability, Books.Status FROM(Author INNER JOIN(Audiences INNER JOIN Books ON(Audiences.AudienceCode = Books.AudienceCode) AND(Audiences.AudienceCode = Books.AudienceCode)) ON Author.AuthorCode = Books.AuthorCode) INNER JOIN BookNames ON Books.BookCode = BookNames.BookCode");
        }
    }
}
