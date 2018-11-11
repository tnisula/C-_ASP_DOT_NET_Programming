using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApplication
{
    public partial class Form1 : Form
    {
        List<LibraryItem> itemsList = new List<LibraryItem>();
        Book book = new Book(0, "", "", "", "", "", "", "", "");
        Magazine magazine = new Magazine(0, "", "", "", "", "", "", 0, 0, "");
        MusicItem musicitem = new MusicItem(0, "", "", "", "", "", "", "", "", "");
        VideoItem videoitem = new VideoItem(0, "", "", "", "", "", "", "", "");

        public Form1()
        {
            InitializeComponent();

            Book book1 = new Book(0, "book", "Free", "Mogadishu avenue", "74.23", "Kauhu", "Tammi", "Jari Tervo", "1234567");
            itemsList.Add(book1);
            Magazine magazine = new Magazine(1, "magazine", "Free", "Seura", "78.34", "Viihde", "Lehtimiehet Oy", 2012, 4, "7894561");
            itemsList.Add(magazine);
            Book book2 = new Book(2, "book", "Free", "Runoja", "23.56", "Runot", "Otava", "Melleri Arto", "4567892");
            itemsList.Add(book2);
            MusicItem musicitem = new MusicItem(3, "music", "Free", "Hurriganes:Crazy Days", "10.11", "Rock", "Love", "Hurriganes", "CD", "4562387");
            itemsList.Add(musicitem);
            VideoItem videoitem = new VideoItem(4, "video", "Free", "Avaruusseikkailu", "56.89", "Scifi", "Universal", "Steve Lucas", "7898991");
            itemsList.Add(videoitem);
        }

        private void showAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newMDIChild = new Form3(this);
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {    
            Form2 newMDIChild = new Form2(this);
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        public void AddToItems(Book book)
        {
            itemsList.Add(book);
        }

        public List<LibraryItem> getLibraryItems()
        {
            return itemsList;
        }

        public int GetLibraryItemsCount()
        {
            return itemsList.Count();
        }

        public void CopyLibraryItems(List<LibraryItem> copies)
        {
            itemsList = copies;
        }
       
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                string serializationFile = openFileDialog.FileName;

                //deserialize
                using (Stream stream = File.Open(serializationFile, FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    List<LibraryItem> libItemList = (List<LibraryItem>)bformatter.Deserialize(stream);
                    itemsList = libItemList;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                List<LibraryItem> libItemList = getLibraryItems(); 
                string serializationFile = saveFileDialog.FileName;

                //serialize
                using (Stream stream = File.Open(serializationFile, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Serialize(stream, libItemList);
                }
            }
        }

        private void showAllItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newMDIChild = new Form4(this);
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newMDIChild = new Form5(this);
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void addMagazineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet! Can be implemented same way as Add Book.");
        }

        private void searchMagazineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet! Can be implemented same way as Search Book.");
        }

        private void showMusicItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet! Can be implemented same way as Show Books.");
        }

        private void addMusicItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet! Can be implemented same way as Add Book.");
        }

        private void searchMusicItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet! Can be implemented same way as Search Book.");
        }

        private void showVideoItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet! Can be implemented same way as Show Books.");
        }

        private void addVideoItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet! Can be implemented same way as Add Book.");
        }

        private void searchVideoItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet! Can be implemented same way as Search Book.");
        }

        private void showMagazinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet! Can be implemented same way as Show Books.");
        }
    }
}
