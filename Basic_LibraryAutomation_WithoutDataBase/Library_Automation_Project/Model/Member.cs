using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation_Project.Model
{
    public class Member
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime CreationDate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Authority { get; set; }


        public Member()
        {

        }

        public Member(int ıD, string name, string surname, DateTime creationDate, string username, string password, string authority)
        {
            ID = ıD;
            this.name = name;
            this.surname = surname;
            CreationDate = creationDate;
            Username = username;
            Password = password;
            Authority = authority;
        }

        public void SetID(int ID)

        {
            this.ID = ID;
        }

        public int GetID()
        {
            return ID;
        }

        public void SetName (string name)
        {
            this.name = name;
        }

        public string GetName ()

        {
            return name;
        }

        public void SetSurname (string Surname)
        {
            this.surname = surname;
        }

        public string GetSurname()
        {
            return surname;
        }

        public void SetCreationDate(DateTime CreationDate)
        {
            this.CreationDate = CreationDate;
        }

        public DateTime GetCreationDate ()
        {
            return CreationDate;
        }

        public void SetUsername (string username)

        {
            this.Username = username;
        }

        public string GetUsername ()
        {
            return Username;
        }

        public void SetPassword (string Password)
        {
            this.Password = Password;
        }

        public string GetPassword ()
        {
            return Password;
        }

        public void SetAuthority(string authority)
        {
            this.Authority = authority;
        }

        public string GetAuthority()

        { return Authority; }


        public override string ToString()
        {
            return "Name - Surname" + name + " " + surname;

        }

    }
}
