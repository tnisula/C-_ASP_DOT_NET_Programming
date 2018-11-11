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
    public partial class Form5 : Form
    {
        private Form1 parent;
        
        public Form5(Form1 f1)
        {
            InitializeComponent();
            parent = f1;
            List<LibraryItem> myItems = new List<LibraryItem>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string temp = textBox8.Text;

            if (temp == null)
            {
                MessageBox.Show("Write search criteria!");
            }
            else
            {
                bool found = false;
                List<LibraryItem> myItems = parent.getLibraryItems();
                foreach (LibraryItem libitem in myItems)
                {
                    if (libitem.PrintData().Contains(temp))
                    {
                        Book book = new Book(0, "", "", "", "", "", "", "", "");
                        book = (Book) libitem;
                        textBox1.Text = book.getId().ToString();
                        comboBox1.SelectedItem = book.getState();
                        textBox2.Text = book.getPublisher();
                        textBox3.Text = book.getIsbn();
                        textBox4.Text = book.getAuthor();
                        textBox5.Text = book.getTitle();
                        textBox6.Text = book.getGenre();
                        textBox7.Text = book.getShelfClassification();
                        found = true;
                    }
                }
                if(!found)
                    MessageBox.Show("Book matching search criteria not found!");
            }
        }
    }
}
