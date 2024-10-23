using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab02.Model;

namespace Lab02.View.ViewModel
{
    public  class GuestViewModel : ViewModelBase
    {
        private string _name = "";
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _surname = "";
        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                OnPropertyChanged("Surname");
            }
        }

        private Booking? _booking = null;
        public Booking? Booking
        {
            get { return _booking; }
            set
            {
                _booking = value;
                OnPropertyChanged("Booking");
            }
        }
    }
}