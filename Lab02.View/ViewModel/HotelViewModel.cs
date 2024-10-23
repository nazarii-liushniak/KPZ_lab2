using Lab02.Model;

namespace Lab02.View.ViewModel
{
    public class HotelViewModel : ViewModelBase
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

        private float _rating = 0.0f;
        public float Rating
        {
            get { return _rating; }
            set
            {
                _rating = value;
                OnPropertyChanged("Rating");
            }
        }

        private HotelType _type = HotelType.Business;
        public HotelType Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }
    }
}
