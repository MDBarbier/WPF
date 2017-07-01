using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMVVMDemo.Model;

namespace WpfMVVMDemo.ViewModel
{
    class PersonViewModel
    {

        public PersonViewModel()
        {
            LoadPeople();
        }

        public ObservableCollection<Person> People
        {
            get;
            set;
        }

        public void LoadPeople()
        {
            ObservableCollection<Person> people = new ObservableCollection<Person>();

            people.Add(new Person { FirstName = "Mark", LastName = "Allain" });
            people.Add(new Person { FirstName = "Allen", LastName = "Brown" });
            people.Add(new Person { FirstName = "Linda", LastName = "Hamerski" });

            People = people;
        }
    }
}
