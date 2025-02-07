using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace DivingProgram
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {

        public RegisterWindow()
        {
            InitializeComponent();
        }

        private const string EMAIL_REGEX = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        private const string PASSWORD_REGEX = @"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d]{8,}$";

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {

            string uFirstName = firstName.Text;
            string uLastName = lastName.Text;
            string uEmail = email.Text;
            string uPassword = password.Password;
            DateTime uBirthDay = userBirthDate.SelectedDate.Value;

            if (uFirstName == "" || uLastName == "" || uEmail == "" || uPassword == "" || uBirthDay == null)
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (!Regex.IsMatch(uEmail, EMAIL_REGEX))
            {
                MessageBox.Show("Invalid email format!");
                return;
            }

            if (!Regex.IsMatch(uPassword, PASSWORD_REGEX))
            {
                MessageBox.Show("Password must contain at least 8 characters, one uppercase letter, one lowercase letter, one number and one special character!");
                return;
            }

            if (uBirthDay > DateTime.Now)
            {
                MessageBox.Show("Invalid birth date!");
                return;
            }

            Random random = new Random();
            int uniqeId = random.Next(1000, 9999);
            Diver diver = new Diver(uFirstName, uLastName,uEmail, uPassword, uBirthDay, uniqeId);
            SystemManager systemManager = new SystemManager();
            systemManager.AddDiver(diver);
            //MessageBox.Show("You have successfully registered!");
            this.Close();

        }










    }
}
