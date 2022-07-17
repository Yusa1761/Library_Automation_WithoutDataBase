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
    public partial class Login : Form
    {

        Member member = new Member();

        List<Member> members = new List<Member>();

        List<Book> books = new List<Book>();    

        bool kontrol1 = true; // her yanlış çıkan sonuç için ayrı ayrı hata vermemesi için kontrol koydum

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            members.Add(new Member(1, "yusa", "tosun", DateTime.Now, "yusa", "1234", "admin"));
            members.Add(new Member(2, "cem", "altın", DateTime.Now, "cem", "2345", "member"));
            members.Add(new Member(3, "ali", "kılıç", DateTime.Now, "ali", "3456", "member"));
            members.Add(new Member(4, "ayse", "durmaz", DateTime.Now, "ayse", "4567", "member"));

            books.Add(new Book(1,"İçimizdeki şeytan","Sabahattin Ali","Yapı Kredi yayınları","Roman"));
            books.Add(new Book(2, "Tutunamayanlar", "Oğuz Atay", "İletişim yayıncılık", "Roman"));
            books.Add(new Book(3, "Uçurtma avcısı", "Khaled Hosseini", "Everest Yayınları", "Roman"));
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Username.Text = string.Empty;
            txt_Password.Text = string.Empty;

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txt_Username.Text;
            password = txt_Password.Text;

            

            txt_Password.Text = "";
            txt_Username.Text = "";
            foreach (Member member in members)
           
            {


                if (username.ToLower() == member.GetUsername() && password == member.GetPassword() && member.GetAuthority() == "admin")
                {
                    //Admin sayfasına yolla

                    AdminPage adminPage = new AdminPage(members,books);

                    adminPage.Show();
                    this.Hide();
                    kontrol1 = false;

                    break; // Bu kısım önemli
                }

                else if (username.ToLower() == member.GetUsername() && password == member.GetPassword() && member.GetAuthority() == "member")

                {

                    // Member sayfasına yolla

                    MemberPage memberPage = new MemberPage(books);

                    memberPage.Show();
                    this.Hide();

                    kontrol1 = false;

                    break; // Bu kısım önemli
                }

               

            }

            if (kontrol1)

            { MessageBox.Show("Your password or username is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
