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
    public partial class Form4 : Form
    {
        private Form1 parent;
        
        public Form4(Form1 f1)
        {
            InitializeComponent();
            parent = f1;
            List<LibraryItem> myItems = new List<LibraryItem>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;

            //Add column headers
            listView2.Columns.Add("ID", 30);
            listView2.Columns.Add("Type", 60);
            listView2.Columns.Add("State", 70);
            listView2.Columns.Add("Publisher", 90);
            listView2.Columns.Add("Author, Title, ISBN or ISSN or ISAN or ISRC", 270);
            listView2.Columns.Add("Genre", 70);
            listView2.Columns.Add("Shelf", 70);

            //Add items in the listview
            string[] arr = new string[10];
            ListViewItem itm;
            List<LibraryItem> myItems = parent.getLibraryItems();

            foreach (LibraryItem libitem in myItems)
            {
                arr[0] = libitem.getId().ToString();
                arr[1] = libitem.getType();
                arr[2] = libitem.getState();
                arr[3] = libitem.getPublisher();
                arr[4] = libitem.PrintData();
                arr[5] = libitem.getGenre();
                arr[6] = libitem.getShelfClassification();
                itm = new ListViewItem(arr);
                listView2.Items.Add(itm);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Choose an item in the listview first!");
            }
            else
            {
                List<LibraryItem> myItems = parent.getLibraryItems();
                string text = listView2.SelectedItems[0].SubItems[2].Text;
                
                if(text.Equals("Free"))
                {
                    int intselectedindex = listView2.SelectedIndices[0];
                    if (intselectedindex >= 0)
                    {
                        listView2.SelectedItems[0].SubItems[2].Text = "Borrowed";
                        foreach (LibraryItem libitem in myItems)
                        {
                            if(libitem.getId() == intselectedindex)
                            {
                                libitem.setState("Borrowed");
                                break;
                            }
                        }
                        parent.CopyLibraryItems(myItems);
                    }
                }
                else
                    MessageBox.Show("Item is not free. You can not borrow it.");
            }
            listView2.SelectedItems.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Choose an item in the listview first!");
            }
            else
            {
                List<LibraryItem> myItems = parent.getLibraryItems();
                string text = listView2.SelectedItems[0].SubItems[2].Text;

                if (text.Equals("Borrowed"))
                {
                    int intselectedindex = listView2.SelectedIndices[0];
                    if (intselectedindex >= 0)
                    {
                        listView2.SelectedItems[0].SubItems[2].Text = "Free";
                        foreach (LibraryItem libitem in myItems)
                        {
                            if (libitem.getId() == intselectedindex)
                            {
                                libitem.setState("Free");
                                break;
                            }
                        }
                        parent.CopyLibraryItems(myItems);
                    }
                }
                else
                    MessageBox.Show("Item is not borrowed. You can not return it.");
            }
            listView2.SelectedItems.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Choose an item in the listview first!");
            }
            else
            {
                List<LibraryItem> myItems = parent.getLibraryItems();
                string text = listView2.SelectedItems[0].SubItems[2].Text;

                if (text.Equals("Free"))
                {
                    int intselectedindex = listView2.SelectedIndices[0];
                    if (intselectedindex >= 0)
                    {
                        listView2.SelectedItems[0].SubItems[2].Text = "Reserved";

                        foreach (LibraryItem libitem in myItems)
                        {
                            if (libitem.getId() == intselectedindex)
                            {
                                libitem.setState("Reserved");
                                break;
                            }
                        }
                        parent.CopyLibraryItems(myItems);
                    }
                }
                else
                    MessageBox.Show("Item is not free. You can not reserve it.");
            }
            listView2.SelectedItems.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Choose an item in the listview first!");
            }
            else
            {
                List<LibraryItem> myItems = parent.getLibraryItems();
                string text = listView2.SelectedItems[0].SubItems[2].Text;

                if (text.Equals("Free"))
                {
                    int intselectedindex = listView2.SelectedIndices[0];
                    if (intselectedindex >= 0)
                    {
                        listView2.SelectedItems[0].SubItems[2].Text = "Removed";

                        foreach (LibraryItem libitem in myItems)
                        {
                            if (libitem.getId() == intselectedindex)
                            {
                                libitem.setState("Removed");
                                break;
                            }
                        }
                        parent.CopyLibraryItems(myItems);
                    }
                }
                else
                    MessageBox.Show("Item is not free. You can not remove it.");
            }
            listView2.SelectedItems.Clear();
        }
    }
}
