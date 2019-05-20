using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RML_Validation
{
    public class Person : ObservableObjectBase
    {
        public int Id { get; set; }

        private string titles;
        public string Titles
        {
            get { return titles; }
            set
            {
                titles = value;
                ValidationErrorsBegin();
                if (!String.IsNullOrEmpty(titles) && titles.Length > 10) ValidationErrorsAdd("Hossz <= 10");
                ValidationErrorsEnd();
                OnPropertyChanged();
            }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                ValidationErrorsBegin();
                if (String.IsNullOrEmpty(firstName)) ValidationErrorsAdd("Kötelező");
                if (!String.IsNullOrEmpty(firstName) && firstName.Length > 30) ValidationErrorsAdd("Hossz <= 30");
                ValidationErrorsEnd();
                OnPropertyChanged();
            }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                ValidationErrorsBegin();
                if (String.IsNullOrEmpty(lastName)) ValidationErrorsAdd("Kötelező");
                if (!String.IsNullOrEmpty(lastName) && lastName.Length > 30) ValidationErrorsAdd("Hossz <= 30");
                ValidationErrorsEnd();
                OnPropertyChanged();
            }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                ValidationErrorsBegin();
                if (!String.IsNullOrEmpty(phone) && !Int32.TryParse(phone, out int result)) ValidationErrorsAdd("Csak számjegyek");
                ValidationErrorsEnd();
                OnPropertyChanged();
            }
        }

        private string mobile;
        public string Mobile
        {
            get { return mobile; }
            set
            {
                mobile = value;
                ValidationErrorsBegin();
                if (!String.IsNullOrEmpty(mobile) && !Int32.TryParse(mobile, out int result)) ValidationErrorsAdd("Csak számjegyek");
                ValidationErrorsEnd();
                OnPropertyChanged();
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                ValidationErrorsBegin();
                if (!String.IsNullOrEmpty(email) && !email.Contains("@")) ValidationErrorsAdd("Kell @"); //Ennél persze okosabb validátor kell...
                ValidationErrorsEnd();
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Address> Addresses { get; set; } = new ObservableCollection<Address>();
    }
}
