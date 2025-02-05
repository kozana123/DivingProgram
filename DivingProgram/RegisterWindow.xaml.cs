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
        private const string PASSWORD_REGEX = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8}$";

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {

            string firstName = firstName.Text;
            string lastName = lastName.Text;
            string email = email.Text;
            string password = password.Text;
            DateTime birthDay = birthDayPicker.SelectedDate;

            if (firstName == "" || lastName == "" || email == "" || password == "" || birthDay == null)
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (!Regex.IsMatch(email, EMAIL_REGEX))
            {
                MessageBox.Show("Invalid email format!");
                return;
            }

            if (!Regex.IsMatch(password, PASSWORD_REGEX))
            {
                MessageBox.Show("Password must contain at least 8 characters, one uppercase letter, one lowercase letter, one number and one special character!");
                return;
            }

            if (birthDay > DateTime.Now)
            {
                MessageBox.Show("Invalid birth date!");
                return;
            }

            Diver diver = new Diver(firstName, lastName, email, password, birthDay);
            if (!systemManager.AddDiver(diver))
            {
                MessageBox.Show("A user with this email already exists!");
                return;
            }

            MessageBox.Show("You have successfully registered!");
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }










    }
}
