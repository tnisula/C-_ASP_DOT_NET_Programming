using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    [Serializable]
    public class Magazine : LibraryItem
    {
        private short mYear;

        private short mIssue;
    
        private string mIssn;

        public Magazine(int id, string type, string state, string title, string shelfClassification, string genre, string publisher, short year, short issue, string issn)
            : base(id, type, state, title, shelfClassification, genre, publisher)
        {
            mYear = year;
            mIssue = issue;
            mIssn = issn;
        }

        public short getYear() {
            return mYear;
        }

        public void setYear(short year) {
            this.mYear = year;
        }

        public short getIssue() { 
            return mIssue;
        }

        public void setIssue(short issue) {
            this.mIssue = issue;
        }
    
        public String getIssn() { 
            return mIssn;
        }

        public void setIssn(String issn) {
            this.mIssn = issn;
        }
    
        public override string GetName() {
            string name = getTitle() + " " + getIssue() + "/" + getYear();
            return name;
        }
    
        public override string PrintData() {
            string data = GetName() + " " + getIssn();
            return data;
        }
    }
}
