namespace Cheers.Views {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();

            Age.MaximumDate = DateTime.Today;
            Age.Date = DateTime.Today;

            CountryPicker.ItemsSource = CountryManager.CountryList;
            CountryPicker.SelectedIndex = 0;
        }

        private async void FindLocationOnClicked(object? sender, EventArgs e) {
            try {
                var rawLocation = await Geolocation.Default.GetLastKnownLocationAsync();
                if (rawLocation is null) return;
                var geocodedLocation =
                    await Geocoding.Default.GetPlacemarksAsync(rawLocation.Latitude, rawLocation.Longitude);

                var index = CountryManager.CountryList.IndexOf(geocodedLocation.First().CountryName);
                CountryPicker.SelectedIndex = index > 0 ? index : 0;
            }
            catch (Exception _) {
                // ignored
            }
        }

        private void LocationOrAgeChanged(object? sender, EventArgs e) {
            var timeRemaining = Age.Date.AddYears(CountryManager.DataList[CountryPicker.SelectedIndex].LegalAge)
                                   .Subtract(DateTime.Today);
            Output.Text = timeRemaining.TotalDays <= 0
                ? "...Silly goose! You can already drink!"
                : $"You can drink in: {timeRemaining.Days / 365.25:###0.##} year(s)!";
        }
    }
}