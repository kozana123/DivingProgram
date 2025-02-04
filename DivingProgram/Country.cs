using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingProgram
{
    internal class Country
    {
        string name;
        string linkFile;
        DivingSite[] divingSites;

        public Country(string name, string linkFile, DivingSite[] divingSites)
        {
            this.name = name;
            this.linkFile = linkFile;
            this.divingSites = divingSites;
        }


    }
}
