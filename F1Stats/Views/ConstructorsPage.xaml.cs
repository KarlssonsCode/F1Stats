namespace F1Stats.Views;

public partial class ConstructorsPage : ContentPage
{
	public ConstructorsPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.ConstructorsPageViewModel();
	}
    private async void GoBack(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }


}