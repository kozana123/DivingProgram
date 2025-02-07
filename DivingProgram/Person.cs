using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingProgram
{
    internal class Person
    {
        protected string firstName;
        protected string lastName;
        public string email {get; set;}
        protected string password;
        protected DateTime birthDate;

        public Person (string firatName, string lastName, string email, string password, DateTime birthDate)
        {
            this.firstName = firatName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.birthDate = birthDate;
        }

        public string GetFirstName() {  return firstName; }
    



    }
}
