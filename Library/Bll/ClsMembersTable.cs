using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library.Bll
{
    public class ClsMembersTable:GeneralTable
    {
        public ClsMembersTable() : base("Members", "iDNumber")
        {

        }
        public DataTable GetFullName()
        {
            return Dal.ClsDal.GetDisplayTable("SELECT Members.IDNumber, [LastName] & '  ' &[Members]![FirstName] AS FullName, Members.PhoneNumber, Members.City, Members.Street, Members.AppartmentNumber, Members.DateOfBirth FROM Members");
        }
    }
}
