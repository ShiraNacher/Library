using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Library.Bll
{
    public class ClsBorrowingBooksTable : GeneralTable
    {
        public ClsBorrowingBooksTable() : base("BorrowingBooks", "BorrowingBooksCode")
        {

        }

        //public DataTable getb(string id)

        //{
        //   MessageBox .Show ("SELECT BorrowBook.BorrowBookCode, BorrowBook.MemberCode, BorrowBook.BorrowingDate, BorrowBook.ReturnDate, BooksBeingBorrowed.BookCode FROM BorrowBook INNER JOIN BooksBeingBorrowed ON BorrowBook.BorrowBookCode = BooksBeingBorrowed.BorrowingCode WHERE BorrowBook.MemberCode  '" + id + "'");
        //    return Dal.ClsDal.GetDisplayTable("SELECT BorrowBook.BorrowBookCode, BorrowBook.MemberCode, BorrowBook.BorrowingDate, BorrowBook.ReturnDate, BooksBeingBorrowed.BookCode FROM BorrowBook INNER JOIN BooksBeingBorrowed ON BorrowBook.BorrowBookCode = BooksBeingBorrowed.BorrowingCode WHERE BorrowBook.MemberCode ='"+id+"'");
        //                                 //  SELECT mifgashim.mis_mifgash, sugey_shiurim.shem_mikzoa, mifgashim.taarich, mifgashim.status, tochen_shiur.teur_tochen FROM(sugey_shiurim INNER JOIN (shiur_pail INNER JOIN mifgashim ON shiur_pail.mis_shiur = mifgashim.mis_shiur_sheniftach) ON sugey_shiurim.kod_sug = shiur_pail.kod_sug_shiur) INNER JOIN tochen_shiur ON(tochen_shiur.mis_tochen_shiur = mifgashim.mis_tochen_shiur) AND(sugey_shiurim.kod_sug = tochen_shiur.kod_sug_shiur) where mifgashim.mis_mifgash =
        //}
        public DataTable Getborrowbook(string id)

        {
            // MessageBox.Show("SELECT BorrowBook.BorrowBookCode, BorrowBook.MemberCode, BorrowBook.BorrowingDate, BorrowBook.ReturnDate, BooksBeingBorrowed.BookCode FROM BorrowBook INNER JOIN BooksBeingBorrowed ON BorrowBook.BorrowBookCode = BooksBeingBorrowed.BorrowingCode WHERE BorrowBook.MemberCode  '" + id + "'");
            return Dal.ClsDal.GetDisplayTable("SELECT BorrowingBooks.BorrowingBooksCode, BorrowingBooks.MemberCode, BorrowingBooks.BorrowingDate, BorrowingBooks.ReturnDate, BookBeingBorrowed.BookCode, Books.BookName FROM (Books INNER JOIN(BorrowingBooks INNER JOIN BookBeingBorrowed  ON BorrowingBooks.BorrowingBooksCode = BookBeingBorrowed.BorrowingCode) ON Books.BookCode = BookBeingBorrowed.BookCode) WHERE BorrowingBooks.MemberCode='" + id + "'");

        }
    }
}