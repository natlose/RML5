using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RML_Validation
{
    class MainWindowVM : ObservableObjectBase
    {
        MyData mydata;

        private string idText;
        public string IdText
        {
            get { return idText; }
            set
            {
                idText = value;
            }
        }

        private Person person;
        public Person Person
        {
            get { return person; }
            set {
                person = value;
                OnPropertyChanged();
            }
        }

        public void LoadData()
        {
            if (Int32.TryParse(idText, out int id))
            {
                mydata = new MyData();
                Person result = mydata.Persons.Include(nameof(Person.Addresses)).SingleOrDefault(p => p.Id == id);
                ValidationErrorsBegin(nameof(IdText));
                if (result == null) ValidationErrorsAdd("Nem létezik.", nameof(IdText));
                else Person = result;
                ValidationErrorsEnd(nameof(IdText));
            }
        }

        public void RemoveAddress(Address address)
        {
            mydata.Addresses.Remove(address);
        }

        public void SaveData()
        {
            mydata.SaveChanges();
        }

    }
}
