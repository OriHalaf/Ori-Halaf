using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class Student
    {
        public DateTime Birthday { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Id { get; set; }
        public string Profession { get; set; }
        public string specitlty { get; set; }

        public Student(DateTime birthday, string name, string lastName, string email, string password, string id, string profession, string specitlty)
        {
            Birthday = birthday;
            Name = name;
            LastName = lastName;
            Email = email;
            Password = password;
            Id = id;
            Profession = profession;
            this.specitlty = specitlty;
        }

        public override string ToString()
        {
            string user = "Name:" + Name + "   " + "Last Name:" + LastName + "   "  + "Registration Date" + Birthday + "   "  + "Email:" + Email + "   "  +  "Password" + Password + "   "  + "ID:" + Id + "   "  + "Profession:" + Profession + "   "  + "specitlty:" + specitlty + "\n" + "\n\n\n";
            
            return user;
        }
    }
}
