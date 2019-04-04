# XamarinFormPersianCalendar
Persian Calendar Control For XamarinFroms


#### Usage 

In Your View Add add the xmlns namespace

xmlns:cl="clr-namespace:XamPersianCalendar;assembly=XamPersianCalendar"

Then add the xaml

```xml
 <cl:Calendar 
                        x:Name="Calendar"
                        SelectedDates="{Binding Dates, Mode=TwoWay}"
                        DatesFontSize="12"
                        SelectedFontSize="12"
                        WeekdaysFontSize="12"
                        TitleLabelFontSize="20"
                        SelectedBorderWidth="0"
                        BorderWidth="0"
                        DisabledFontSize="12"
                        DisabledBorderWidth="6"
                        EnableTitleMonthYearView="True"
                        WeekdaysShow="True"
                        WeekdaysFontAttributes="Bold"
                        DisabledBorderColor="{StaticResource WhiteColor}"
                        DisabledBackgroundColor="{StaticResource WhiteColor}"
                        BorderColor="{StaticResource WhiteColor}"
                        DatesBackgroundColor="{StaticResource WhiteColor}"
                        TitleLeftArrowTextColor="{StaticResource DarkGrayColor}"
                        TitleRightArrowTextColor="{StaticResource DarkGrayColor}"
                        SelectedTextColor="{StaticResource SelectedDateColor}"
                        SelectedBorderColor="{StaticResource WhiteColor}"
                        DateCommand="{Binding SelectedDateCommand}"
                        MultiSelectDates="False" 
                        SelectRange="False"
                        >
                        <cl:Calendar.SelectedBackgroundImage>
                            <OnPlatform x:TypeArguments="FileImageSource">
                                <On Platform="Android, iOS" Value="ball" />
                            </OnPlatform>
                        </cl:Calendar.SelectedBackgroundImage>
                        <cl:Calendar.SelectedRangeBackgroundImage>
                            <OnPlatform x:TypeArguments="FileImageSource">
                                <On Platform="Android, iOS" Value="selected" />
                            </OnPlatform>
                        </cl:Calendar.SelectedRangeBackgroundImage>
                        <cl:Calendar.FirstSelectedBackgroundImage>
                            <OnPlatform x:TypeArguments="FileImageSource">
                                <On Platform="Android, iOS" Value="ball_left" />
                            </OnPlatform>
                        </cl:Calendar.FirstSelectedBackgroundImage>
                        <cl:Calendar.LastSelectedBackgroundImage>
                            <OnPlatform x:TypeArguments="FileImageSource">
                                <On Platform="Android, iOS" Value="ball_right" />
                            </OnPlatform>
                        </cl:Calendar.LastSelectedBackgroundImage>
   </cl:Calendar>
  ```
  
   Then Add Bindable Property And Command to your ViewModel
   
   ```
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
   
   ```
