using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    [Serializable]
    public class MusicItem : LibraryItem
    {
        private string mAuthor;

        private string mFormat;

        private string mIsrc;

        public MusicItem(int id, string type, string state, string title, string shelfClassification, string genre, string publisher, string author, string format, string isrc)
            : base(id, type, state, title, shelfClassification, genre, publisher)
        {
            mAuthor = author;
            mFormat = format; 
            mIsrc = isrc;
        }


        public void setAuthor(string author) {
            this.mAuthor = author;
        }

        public string getAuthor() {
            return mAuthor;
        }

        public string getFormat() {
            return mFormat;
        }

        public void setFormat(string format) {
            this.mFormat = format;
        }

        public string getIsrc() {
            return mIsrc;
        }

        public void setIsrc(string isrc) {
            this.mIsrc = isrc;
        }
    
        public override string GetName() {
            string name = getAuthor() + " " + getTitle();
            return name;
        }
    
        public override string PrintData() { 
            string data = GetName() + " " + getFormat() + " " + getIsrc();
            return data;
        }
    }
}
