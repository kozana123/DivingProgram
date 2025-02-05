using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingProgram
{
    internal class DivingClub
    {
        private string name;
        private int license;
        private string contact;
        private string address;
        private string phoneNumber;
        private string email;
        private string webSite;

        public DivingClub( string name, int license, string contact, string address, string phoneNumber, string email)
        {
            this.name = name;
            this.license = license;
            this.contact = contact;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        public DivingClub(string name, int license, string contact, string address, string phoneNumber, string email, string webSite)
        {
            this.name = name;
            this.license = license;
            this.contact = contact;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.webSite = webSite;
        }
    }
}
