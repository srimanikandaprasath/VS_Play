using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Tut
{
    public partial class Form1 : Form
    {
        smpEntities1 dbEntities = new smpEntities1();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void bWriteDB_Click(object sender, EventArgs e)
        {
            try
            {
                book bookStore = new book
                {
                    Name = txt_Name.Text,
                    Author = txt_Author.Text,
            };
                dbEntities.books.Add(bookStore);
                dbEntities.SaveChanges();
                MessageBox.Show("insert done");


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bReadDB_Click(object sender, EventArgs e)
        {
            string bookName = txt_Name.Text;
            try
            {
                //book bookName = null;
                //using(dbEntities bookStore1 = new dbEntities())
                //{
                //    txt_Author.Text = dbEntities.books.Where(s => s.Name == txt_Name.Text)
                //        .FirstOrDefault<book>();
                //}
                book findAuthor = dbEntities.books.First(i => i.Name == bookName);
                {
                    txt_Author.Text = findAuthor.Author;
                }

                
                MessageBox.Show("read done");
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bClearTable_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = from o in dbEntities.books select o;
                foreach (var row in rows)
                {
                    dbEntities.books.Remove(row);
                }
                dbEntities.SaveChanges();
                MessageBox.Show("clear done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            string bookName = txt_Name.Text;
            try
            {
                //book bookName = null;
                //using(dbEntities bookStore1 = new dbEntities())
                //{
                //    txt_Author.Text = dbEntities.books.Where(s => s.Name == txt_Name.Text)
                //        .FirstOrDefault<book>();
                //}
                book findAuthor = dbEntities.books.First(i => i.Name == bookName);
                {
                    findAuthor.Author =txt_Author.Text ;
                    dbEntities.SaveChanges();
                   
                }


                MessageBox.Show("update done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            string bookName = txt_Name.Text;
            try
            {
                //book bookName = null;
                //using(dbEntities bookStore1 = new dbEntities())
                //{
                //    txt_Author.Text = dbEntities.books.Where(s => s.Name == txt_Name.Text)
                //        .FirstOrDefault<book>();
                //}
                book findAuthor = dbEntities.books.First(i => i.Name == bookName);
                dbEntities.books.Remove(findAuthor);
                dbEntities.SaveChanges();
                
                MessageBox.Show("delete done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
