namespace F1Stats.Views;

public partial class ConstructorStandingsPage : ContentPage
{
	public ConstructorStandingsPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.ConstructorStandingsPageViewModel();
	}
}