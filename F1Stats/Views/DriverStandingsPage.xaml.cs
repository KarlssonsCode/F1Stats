namespace F1Stats.Views;

public partial class DriverStandingsPage : ContentPage
{
	public DriverStandingsPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.DriverStandingsPageViewModel();
    }
}