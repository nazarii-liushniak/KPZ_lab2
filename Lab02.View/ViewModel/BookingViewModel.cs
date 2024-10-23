using Lab02.Model;

namespace Lab02.View.ViewModel
{
    public class BookingViewModel : ViewModelBase
    {
        private int _id = 0;
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        private Hotel _hotel = null;
        public Hotel Hotel
        {
            get { return _hotel; }
            set
            {
                _hotel = value;
                OnPropertyChanged("Hotel");
            }
        }
    }
}
