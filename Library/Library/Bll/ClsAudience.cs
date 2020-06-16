using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library.Bll
{
    public class ClsAudience
    {
        private int audienceTypeCode;
        private string audienceType;
        public int AudienceTypeCode
        {
            get { return audienceTypeCode; }
            set { audienceTypeCode = value; }
        }
        public string AudienceType
        {
            get { return audienceType; }
            set { audienceType = value; }
        }
        private DataRow drow;
        public void FillFields()
        {
            this.audienceTypeCode = Convert.ToInt32(drow["AudienceTypeCode"]);
            this.audienceType = drow["AudienceType"].ToString();
        }
        public void FillDataRow()
        {
            drow["AudienceTypeCode"] = this.audienceTypeCode;
            drow["AudienceType"] = this.audienceType;
        }
        public ClsAudience()
        {

        }
        public ClsAudience(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public ClsAudience(int id)
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
