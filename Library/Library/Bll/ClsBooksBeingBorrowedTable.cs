using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library.Bll
{
    public class ClsBooksBeingBorrowedTable:GeneralTable
    {
        public ClsBooksBeingBorrowedTable() : base("BooksBeingBorrowed", "BooksBeingBorrowedCode")
        {

        }
    }
}
