using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingProgram
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        public string Email {get; set;}
        private string password;
        private DateTime birthDate;

        public Person (string firatName, string lastName, string password, DateTime birthDate)
        {
            this.firstName = firatName;
            this.lastName = lastName;
            this.password = password;
            this.birthDate = birthDate;
        }

    



    }
}
