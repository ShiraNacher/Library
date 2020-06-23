using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library.Bll
{
    public class ClsAuthors
    {
        private int authorCode;
        private string authorLastName;
        private string authorFirstName;
        public int AuthorCode
        {
            get { return authorCode; }
            set { authorCode = value; }
        }
        public string AuthorLastName
        {
            get { return authorLastName; }
            set
            {
                if(value == "")
                    throw new Exception("לא הזנת שם סופר");
                authorLastName = value;
            }
        }
        public string AuthorFirstName
        {
            get { return authorFirstName; }
            set
            {
                if (value == "")
                    throw new Exception("לא הזנת שם סופר");
                authorFirstName = value;
            }
        }
        private DataRow drow;
        public void FillFields()
        {
            this.authorCode = Convert.ToInt32(drow["AuthorCode"]);
            this.authorLastName = drow["AuthorLastName"].ToString();
            this.authorFirstName = drow["AuthorFirstName"].ToString();
        }
        public void FillDataRow()
        {
            drow["AuthorCode"] = this.authorCode;
            drow["AuthorLastName"] = this.authorLastName;
            drow["AuthorFirstName"] = this.authorFirstName;
        }
        public ClsAuthors()
        {

        }
        public ClsAuthors(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public ClsAuthors(int id)
        {
            ClsAuthorsTable cat = new ClsAuthorsTable();
            drow = cat.Find(id);
            FillFields();
        }
        public void Add()
        {
            ClsAuthorsTable cat = new ClsAuthorsTable();
            drow = cat.GetNewRow();
            FillDataRow();
            cat.AddRow(drow);
        }
        public void Update()
        {
            FillDataRow();
            Bll.ClsAuthorsTable cat = new ClsAuthorsTable();
            cat.Save();
        }
        public void Delete()
        {
            drow.Delete();
            ClsAudienceTable cat = new ClsAudienceTable();
            cat.Save();
        }
    }
}
