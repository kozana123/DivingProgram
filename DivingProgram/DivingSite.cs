﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingProgram
{
    internal class DivingSite
    {
        string nameOfSite;
        string country;
        string address;
        string description;
        double bottomDepth;
        bool SaltWater;

        public DivingSite(string nameOfSite, string country, string address, string description, double bottomDepth, bool SaltWater)
        {
            this.nameOfSite = nameOfSite;
            this.country = country;
            this.address = address;
            this.description = description;
            this.bottomDepth = bottomDepth;
            this.SaltWater = SaltWater;
        }

        


    }
}
