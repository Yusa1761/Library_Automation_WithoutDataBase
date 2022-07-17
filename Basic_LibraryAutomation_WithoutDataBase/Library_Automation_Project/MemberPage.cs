using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Automation_Project.Model;


namespace Library_Automation_Project
{
    public partial class MemberPage : Form
    {
        List<Book> books;

        public MemberPage(List<Book> books)
        {
            InitializeComponent();

            this.books = books;
        }

        private void MemberPage_Load(object sender, EventArgs e)
        {
            foreach (Book book1 in books)
            {
                booklist_member.Rows.Add(book1.getbookID(), book1.getbookName(), book1.getbookWriter(), book1.getbookPublisher(), book1.getGenre());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();

            this.Hide();
        }

        private void btn_memberSearch_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(txt_searchMP.Text);

            foreach (Book book1 in books)
            {
                if (book1.getbookID() == bookID)
                {
                    booklist_member.Rows.Clear();

                    booklist_member.Rows.Add(book1.getbookID(),book1.getbookName(), book1.getbookWriter(), book1.getbookPublisher(), book1.getGenre());
                     // 1-Buraya ve ..... @@@@@@@@@@
                    break;
                }
            }


        }

        private void btn_memberRefresh_Click(object sender, EventArgs e)
        {
            //   booklist_member.Rows.Remove(booklist_member.CurrentRow);

            Book book = new Book();

           booklist_member.Rows.Clear();// Bu sefer bu kodu kullanıcam daha kullanışlı // This code is more efficient

            foreach (Book book2 in books)
            {
                booklist_member.Rows.Add(book2.getbookID(), book2.getbookName(), book2.getbookWriter(), book2.getbookPublisher(), book2.getGenre());
                // 2-Buraya tekrar bak....  @@@@@@@@@@ 
            }

        }
    }
}
