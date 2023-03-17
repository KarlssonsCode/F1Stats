namespace F1Stats.Views;

public partial class DriversPage : ContentPage
{
	public DriversPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.DriversPageViewModel();
    }

    private async void OnClickedViewSelectedDriver(object sender, SelectedItemChangedEventArgs e)
    {
        var driver = ((ListView)sender).SelectedItem as Models.Driver;
        if (driver != null)
        {
            var page = new DriverPage();
            page.BindingContext = driver;
            await Navigation.PushAsync(page);
        }
    }

    private async void GoBack(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}