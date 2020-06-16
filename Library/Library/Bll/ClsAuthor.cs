using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library.Bll
{
    public class ClsAuthor
    {
        private int authorCode;
        private string authorName;
        public int AuthorCode
        {
            get { return authorCode; }
            set { authorCode = value; }
        }
        public string AuthorName
        {
            get { return authorName; }
            set { authorName = value; }
        }
        private DataRow drow;
        public void FillFields()
        {
            this.authorCode = Convert.ToInt32(drow["AuthorCode"]);
            this.authorName = drow["AuthorName"].ToString();
        }
        public void FillDataRow()
        {
            drow["AuthorCode"] = this.authorCode;
            drow["AuthorName"] = this.authorName;
        }
        public ClsAuthor()
        {

        }
        public ClsAuthor(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public ClsAuthor(int id)
        {
            ClsAudienceTable cat = new ClsAudienceTable();
            drow = cat.Find(id);
            FillFields();
        }
        public void Add()
        {
            ClsAudienceTable ct = new ClsAudienceTable();
            drow = ct.GetNewRow();
            FillDataRow();
            ct.AddRow(drow);
        }
        public void Update()
        {
            FillDataRow();
            Bll.ClsAudienceTable c = new ClsAudienceTable();
            c.Save();
        }
        public void Delete()
        {
            drow.Delete();
            ClsAudienceTable c = new ClsAudienceTable();
            c.Save();
        }
    }
}
