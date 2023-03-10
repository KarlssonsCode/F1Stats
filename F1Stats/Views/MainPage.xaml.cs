namespace F1Stats;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnClickedGoDrivers(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Views.DriversPage());
    }
}

