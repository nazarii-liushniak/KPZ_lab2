using System.Collections.ObjectModel;
using System.Windows.Input;
using Lab02.Model;

namespace Lab02.View.ViewModel
{
    public class DataViewModel : ViewModelBase
    {
        public DataViewModel()
        {
            SetControlVisibility = new Command(ControlVisibility);
        }

        private string _visibleControl = "Hotels";
        public string VisibleControl
        {
            get { return _visibleControl; }
            set
            {
                _visibleControl = value;
                OnPropertyChanged("VisibleControl");
            }
        }

        public ICommand SetControlVisibility { get; set; }
        public void ControlVisibility(object args)
        {
            VisibleControl = args.ToString();
        }

        private ObservableCollection<Guest> _guests;
        public ObservableCollection<Guest> Guests
        {
            get { return _guests; }
            set
            {
                _guests = value;
                OnPropertyChanged("Guests");
            }
        }

        private ObservableCollection<Hotel> _hotels;
        public ObservableCollection<Hotel> Hotels
        {
            get { return _hotels; }
            set
            {
                _hotels = value;
                OnPropertyChanged("Hotels");
            }
        }

        private ObservableCollection<Booking> _bookings;
        public ObservableCollection<Booking> Bookings
        {
            get { return _bookings; }
            set
            {
                _bookings = value;
                OnPropertyChanged("Bookngs");
            }
        }
    }
}