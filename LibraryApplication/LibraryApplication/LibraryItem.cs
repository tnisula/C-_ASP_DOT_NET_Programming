using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    [Serializable]
    abstract public class LibraryItem
    {
        // string[] arrString = new string[] { "Free", "Borrowed", "Maintenance", "Reserved", "ReadingRoom", "Removed" };
        /*
        enum states
        {
            Free, 
            Borrowed,
            Maintenance, 
            Reserved,
            ReadingRoom, 
            Removed
        } */

        List<string> states = new List<String> { "Free", "Borrowed", "Maintenance", "Reserved", "ReadingRoom", "Removed" };

        protected int mId = 0;

        protected String mType; // can be book, music, video, magazine

        protected String mState = ""; // Can be Free, Borrowed, Maintenance, Reserved, ReadingRoom, Removed;

        protected String mTitle;

        protected String mShelfClassification;

        protected String mGenre;

        protected DateTime mBorrowDate;

        protected String mPublisher;
        
        public LibraryItem(int id, string type, string state, string title, string shelfClassification, string genre, string publisher)
        {
            mId= id;
            mType= type;
            mState = state;
            mTitle = title;
            mShelfClassification = shelfClassification;
            mGenre = genre;
            mPublisher = publisher;
        }

        public int getId() 
        {
            return mId;
        }

        public void setId(int id)
        {
            if (id > 0)
                this.mId = id;
        }

        public void setType(String type) {
            if("book".Equals(type) || "music".Equals(type)
                || "video".Equals(type) || "magazine".Equals(type)) {
                this.mType = type;
            }
            else {
                // System.out.println("Invalid type. Has to be book, music, video or magazine!");
            } 
        }

        public String getType()
        {
            return mType;
        }

        public void setState(String state)
        {
            if (states.Contains(state))
            {
                this.mState = state;
            }
        }

        public String getState()
        {
            return mState;
        }

        public void setTitle(String title)
        {
            this.mTitle = title;
        }

        public String getTitle()
        {
            return mTitle;
        }

        public void setShelfClassification(String sc)
        {
            this.mShelfClassification = sc;
        }

        public String getShelfClassification()
        {
            return mShelfClassification;
        }

        public String getGenre()
        {
            return mGenre;
        }

        public void setGenre(String genre)
        {
            this.mGenre = genre;
        }

        public void setBorrowDate(DateTime date)
        {
            this.mBorrowDate = date;
        }

        public DateTime getBorrowDate()
        {
            return mBorrowDate;
        }

        public void setPublisher(String publisher)
        {
            this.mPublisher = publisher;
        }

        public String getPublisher()
        {
            return mPublisher;
        }

        abstract public string GetName();
        abstract public string PrintData();
    }
}
