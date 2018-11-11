using System;
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
    public partial class Form3 : Form
    {
        private Form1 parent;

        public Form3(Form1 f1)
        {
            InitializeComponent();
            parent = f1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //Add column header
            listView1.Columns.Add("ID", 40);
            listView1.Columns.Add("Type", 50);
            listView1.Columns.Add("State", 70);
            listView1.Columns.Add("Publisher", 70);
            listView1.Columns.Add("ISBN", 70);
            listView1.Columns.Add("Author", 70);
            listView1.Columns.Add("Title", 70);
            listView1.Columns.Add("Genre", 70);
            listView1.Columns.Add("Shelf", 70);

            //Add items in the listview
            string[] arr = new string[10];
            ListViewItem itm;
            List<LibraryItem> myItems = parent.getLibraryItems();

            foreach (LibraryItem libitem in myItems)
            {
                if (libitem.getType().Equals("book"))
                {
                    Book book = new Book(0, "", "", "", "", "", "", "", "");
                    book = (Book)libitem;
                    arr[0] = book.getId().ToString();
                    arr[1] = book.getType();
                    arr[2] = book.getState();
                    arr[3] = book.getPublisher();
                    arr[4] = book.getIsbn();
                    arr[5] = book.getAuthor();
                    arr[6] = book.getTitle();
                    arr[7] = book.getGenre();
                    arr[8] = book.getShelfClassification();
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
            }
        }
    }
}
