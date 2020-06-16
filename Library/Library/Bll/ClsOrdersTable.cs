using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library.Bll
{
    public class ClsOrdersTable:GeneralTable
    {
        public ClsOrdersTable() : base("Orders", "OrderCode")
        {

        }
    }
}
