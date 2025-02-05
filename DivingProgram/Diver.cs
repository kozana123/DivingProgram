using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingProgram
{
    internal class Diver: Person
    {
        private int diverIdNumber;
        private List<DivingSession> divingSession;
        private List<Rank> rank;

        public Diver(string firatName, string lastName, string email, string password, DateTime birthDate, int diverIdNumber) : base(firatName, lastName, email, password, birthDate)
        {
        }

        public Diver( string firstName, string lastName, string email, string password, DateTime birthDate, int diverIdNumber,List<DivingSession> divingSession,List<Rank> rank) :base (firstName, lastName, email, password, birthDate)
        {
            this.diverIdNumber = diverIdNumber;
            this.divingSession = divingSession;
            this.rank = rank;
        }
        
        
    }
}
