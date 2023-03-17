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

    private async void OnClickedGoConstructors(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.ConstructorsPage());
    }

    private async void OnClickedGoDriverStandings(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.DriverStandingsPage());
    }

    private async void OnClickedGoConstructorStandings(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.ConstructorStandingsPage());
    }
}

