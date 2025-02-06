using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DivingProgram
{
    internal class SystemManager
    {
        private Dictionary<string, Diver> dictOfDiversUsers = new Dictionary<string, Diver>();

        public SystemManager()
        {
            dictOfDiversUsers = new Dictionary<string, Diver>();
        }

        public void AddDiver(Diver diver)
        {
            if (!dictOfDiversUsers.ContainsKey(diver.email))
            {
                dictOfDiversUsers.Add(diver.email, diver);
                MessageBox.Show("Diver successfully registered!");
            }
            else
            {
                MessageBox.Show("Diver with this email already exists!");
            }
        }

    }
}
