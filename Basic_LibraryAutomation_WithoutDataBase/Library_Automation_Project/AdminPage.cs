using Library_Automation_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation_Project
{
    public partial class AdminPage : Form
    {
        List<Member> members;

        List<Book> books;

        public void KitapGuncelle()
        {
            dataGridView2.CurrentRow.Cells[0].Value = txt_bookID.Text;
            dataGridView2.CurrentRow.Cells[1].Value = txt_bookname.Text;
            dataGridView2.CurrentRow.Cells[2].Value = txt_bookwriter.Text;
            dataGridView2.CurrentRow.Cells[3].Value = txt_bookpublisher.Text;
            dataGridView2.CurrentRow.Cells[4].Value = txt_bookgenre.Text;
        }
        public void Guncelle()
        {
            //UPDATE METHOD 

            dataGridView1.CurrentRow.Cells[0].Value = txt_ID.Text;
            dataGridView1.CurrentRow.Cells[1].Value = txt_Name.Text;
            dataGridView1.CurrentRow.Cells[2].Value = txt_Surname.Text;
            dataGridView1.CurrentRow.Cells[3].Value = maskedTextBox1.Text;
            dataGridView1.CurrentRow.Cells[4].Value = txt_Username.Text;
            dataGridView1.CurrentRow.Cells[5].Value = txt_Password.Text;
            dataGridView1.CurrentRow.Cells[6].Value = txt_Authority.Text;
        }

        public void Temizle()
        {
            // CLEAR METHOD

            txt_ID.Text = "";
            txt_Name.Text = "";
            txt_Surname.Text = "";
            maskedTextBox1.Text = "";
            txt_Username.Text = "";
            txt_Password.Text = "";
            txt_Authority.Text = "";
        }

        public void KitapTemizle()
        {
            //CLEAR BOOK INFOS
            txt_bookID.Text = "";
            txt_bookname.Text = "";
            txt_bookwriter.Text = "";
            txt_bookpublisher.Text = "";
            txt_bookgenre.Text = "";

        }
        public void TextleriDoldur()
        {
            // FILL METHOD

            txt_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_Name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Surname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_Username.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_Password.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_Authority.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        public void KitapTextleriniDoldur()
        {
            txt_bookID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_bookname.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_bookwriter.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_bookpublisher.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_bookgenre.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
        }

        public AdminPage(List<Member> members, List<Book> books)
        {
            InitializeComponent();
            this.members = members;

            this.books = books;

        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

            


            foreach (Member member in members)
            {
                dataGridView1.Rows.Add(member.GetID(), member.GetName(), member.GetSurname(), member.GetCreationDate(), member.GetUsername(), member.GetPassword(), member.GetAuthority());


            }

            foreach (Book book in books)
            {
                dataGridView2.Rows.Add(book.getbookID(), book.getbookName(), book.getbookWriter(), book.getbookPublisher(), book.getGenre());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txt_ID.Text, txt_Name.Text, txt_Surname.Text, maskedTextBox1.Text, txt_Username.Text, txt_Password.Text, txt_Authority.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow); // DELETE
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextleriDoldur(); // FILLING THE TEXT BARS

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guncelle(); //UPDATE
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Temizle(); // CLEAR 
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KitapTextleriniDoldur();
        }

        private void btn_bookadd_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_bookID.Text, txt_bookname.Text, txt_bookwriter.Text, txt_bookpublisher.Text, txt_bookgenre.Text);
        }

        private void btn_deleteBook_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_bookUpdate_Click(object sender, EventArgs e)
        {

            // UPDATE BOOK
            KitapGuncelle();
        }

        private void btn_BookClear_Click(object sender, EventArgs e)
        {
            //CLEAR BOOK INFOS

            KitapTemizle();
        }

        private void txt_bookwriter_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Member chosenMember;

            int ChosenID = Convert.ToInt32(txt_Search.Text);


            foreach (Member member in members)
            {
                chosenMember = member;

                if (chosenMember.GetID() == ChosenID)
                {
                    
                    

                      txt_ID.Text = chosenMember.GetID().ToString();
                      txt_Name.Text = chosenMember.GetName();
                      txt_Surname.Text = chosenMember.GetSurname();
                      maskedTextBox1.Text = chosenMember.GetCreationDate().ToString();
                      txt_Username.Text = chosenMember.GetUsername();
                      txt_Password.Text = chosenMember.GetPassword();
                      txt_Authority.Text = chosenMember.GetAuthority(); 

                    dataGridView1.Rows.Clear();

                    dataGridView1.Rows.Add(chosenMember.GetID(), chosenMember.GetName(), chosenMember.GetSurname(), chosenMember.GetCreationDate(), chosenMember.GetUsername(), chosenMember.GetPassword(), chosenMember.GetAuthority());

                    break;

                }
            }

        }

        private void btn_bookSearch_Click(object sender, EventArgs e)
        {
            Book chosenBook;

            int chosenbookID = Convert.ToInt32(txt_bookSearch.Text);

            foreach (Book book in books) // burayı daha sonra datagrid.Clickcell'le değiştir. 
            {
                chosenBook = book;  

                if (chosenBook.getbookID() == chosenbookID)
                {
                    txt_bookID.Text = chosenBook.getbookID().ToString();
                    txt_bookname.Text = chosenBook.getbookName();
                    txt_bookgenre.Text = chosenBook.getGenre();
                    txt_bookpublisher.Text = chosenBook.getbookPublisher();
                    txt_bookwriter.Text = chosenBook.getbookWriter();

                    dataGridView2.Rows.Clear();

                    dataGridView2.Rows.Add(chosenBook.getbookID(), chosenBook.getbookName(), chosenBook.getGenre(), chosenBook.getbookPublisher(), chosenBook.getbookWriter());

                    break;

                }
               
            }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            foreach (Member member in members)
            {
                dataGridView1.Rows.Add(member.GetID(), member.GetName(), member.GetSurname(), member.GetCreationDate(), member.GetUsername(), member.GetPassword(), member.GetAuthority());
            }
        }

        private void btn_bookRefresh_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove   (dataGridView2.CurrentRow);
            foreach (Book book in books)
            {
                dataGridView2.Rows.Add(book.getbookID(),book.getbookName(),book.getbookWriter(),book.getbookPublisher(),book.getGenre());
            }
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Login().Show(); // Bu şekilde de kullanılabilir


           
            this.Hide();
        }
    }
}
