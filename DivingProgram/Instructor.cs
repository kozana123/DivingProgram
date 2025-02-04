using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingProgram
{
    internal class Instructor: Diver
    {
        Dictionary <string, (string start, string end)> workingHistory = new Dictionary <string, (string start, string end)>();

        public Instructor(string firstName, string lastName, string email, string password, DateTime birthDate, int diverIdNumber) : base (firstName, lastName, email, password, birthDate, diverIdNumber)
        {

        }
    }
}
