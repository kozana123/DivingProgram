using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingProgram
{
    internal class Rank
    {
        string rankName;
        int numOfDives;
        DivingClub club;
        DateTime dateOfRecipt;

        public Rank(string rankName, int numOfDives, DivingClub club, DateTime dateOfRecipt)
        {
            this.RankName = rankName;
            this.numOfDives = numOfDives;
            this.club = club;
            this.dateOfRecipt = dateOfRecipt;
        }
        


    
       

       
    }
}
