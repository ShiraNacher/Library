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
    }
}
