using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    [Serializable]
    public class Book : LibraryItem
    {
        private string mAuthor;
        private string mIsbn;
        
        public Book(int id, string type, string state, string title, string shelfClassification, string genre, string publisher, string author, string isbn)
            : base(id, type, state, title, shelfClassification, genre, publisher)
        {
            mAuthor = author;
            mIsbn = isbn;
        }

        public void setAuthor(string author) {
            this.mAuthor = author;
        }

        public string getAuthor() {
            return mAuthor;
        }

        public void setIsbn(string isbn) {
            this.mIsbn = isbn;
        }

        public String getIsbn() {
            return mIsbn;
        }
    
        public override string GetName() {
            string name = getAuthor() + " " + getTitle();
            return name;
        }
    
        public override string PrintData() {
            string data = GetName() + " " + getIsbn();
            return data;
        }
    }

}
