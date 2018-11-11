using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    [Serializable]
    public class VideoItem : LibraryItem
    {
        private string mDirector;

        private List<string> mLeadRoles;

        private string mIsan;

        public VideoItem(int id, string type, string state, string title, string shelfClassification, string genre, string publisher, string director, string isan)
            : base(id, type, state, title, shelfClassification, genre, publisher)
        {
            mDirector = director;
            mIsan = isan;
        }

        public String getDirector() {
            return mDirector;
        }

        public void setDirector(String director) {
            this.mDirector = director;
        }

        public void addActor(String actor) {
      
        }

        public void removeActor(String actor) {

        }

        public Boolean findActor() {
            return false;
        }

        public String[] returnActors() {
            return null;
        }

        public void setIsan(String isan) {
            this.mIsan = isan;
        }

        public String getIsan() { 
            return mIsan;
        }

        public override string GetName() {
            string name = getDirector() + " " + getTitle();
            return name;
        }
    
        public override string PrintData() {
            string data = GetName() + " " + getIsan();
            return data;
        }
    }
}
