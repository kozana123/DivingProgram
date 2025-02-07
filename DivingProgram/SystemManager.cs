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
        private static Dictionary<string, Diver> dictOfDiversUsers;
        

        
        public SystemManager()
        {
            if(dictOfDiversUsers is null)
            {
                dictOfDiversUsers = new Dictionary<string, Diver>();
            }
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


        public bool Login(string email, string password)
        {
            //dictOfDiversUsers.TryGetValue(email, out Diver diver);
            //MessageBox.Show(diver.email);

            if (dictOfDiversUsers.TryGetValue(email, out Diver diver))
            {
                return diver.VerifyPassword(password);
            }
            return false;
        }


    }
}
