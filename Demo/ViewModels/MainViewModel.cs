using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using XamPersianCalendar.Extensions;

namespace Demo.ViewModels
{
    public class MainViewModel : BindableObject
    {
        private ObservableCollection<DateTime> _dates;
        private string _selectDate;

        public MainViewModel()
        {
            _dates = new ObservableCollection<DateTime>()
            {
                DateTime.Now
            };
        }

        public ObservableCollection<DateTime> Dates
        {
            get { return _dates; }
            set
            {
                _dates = value;
                OnPropertyChanged();
            }
        }

        public string SelectDate
        {
            get { return _selectDate; }
            set
            {
                _selectDate = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectedDateCommand => new Command(() => OnSelectedDate());

        private void OnSelectedDate()
        {            
            if (Dates.Any())
            {
                var date = Dates.LastOrDefault();
                SelectDate = date != null ? date.ToPersianDate("/") : string.Empty;
            }
        }
    }
}
