using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation_Project.Model
{
    public class Book
    {
        int bookID { get; set; }
        string bookName { get; set; }
        string bookWriter { get; set; }
        string bookPublisher { get; set; }
        string Genre { get; set; }

        
       
      

        public Book()
        {

        }

        public Book(int bookID,string bookName,string BookWriter,string bookPublisher,string Genre)
        {
            this.bookID = bookID;
            this.bookName = bookName;
            this.bookWriter= BookWriter;  // this.bookWriter= bookWriter; Böyleydi düzelttim
            this.bookPublisher = bookPublisher; //.Değeri propertyden çekiyordu @@@@@ Değer NULL olarak kalıyordu
            this.Genre = Genre;                    // Güncellerken bu hatayı tekrar incele,hatırla
        }


        public int getbookID()
        {
            return this.bookID;
        }

        public string getbookName()
        {
            return this.bookName;
        }

        public string getbookWriter()
        {
            return this.bookWriter;
        }

        public string getbookPublisher()
        {
            return this.bookPublisher;
        }

        public string getGenre()
        {
            return this.Genre;
        }
    }
}
