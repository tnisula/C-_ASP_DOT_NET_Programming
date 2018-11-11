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
    public partial class Form2 : Form
    {
        private Form1 parent;
        // Book book = new Book(0, "", "", "","","","","","");

        public Form2(Form1 f1)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0; //Set select first item
            parent = f1;
            int tempCount = parent.GetLibraryItemsCount();
            textBox1.Text = tempCount.ToString();
            textBox2.Select(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book(0, "", "", "", "", "", "", "", "");
            book.setType("book");
            book.setState(comboBox1.SelectedItem.ToString());
            book.setPublisher(textBox2.Text);
            book.setIsbn(textBox3.Text);
            book.setAuthor(textBox4.Text);
            book.setTitle(textBox5.Text);
            book.setGenre(textBox6.Text);
            book.setShelfClassification(textBox7.Text);
            book.setId(int.Parse(textBox1.Text));
            parent.AddToItems(book);

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            // textBox1.Text = "";
            int tempCount = parent.GetLibraryItemsCount();
            textBox1.Text = tempCount.ToString();
            textBox2.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
