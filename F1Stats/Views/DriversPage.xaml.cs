namespace F1Stats.Views;

public partial class DriversPage : ContentPage
{
	public DriversPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.DriversPageViewModel();
    }
}