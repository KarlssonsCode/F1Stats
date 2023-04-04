namespace F1Stats.Views;

public partial class SingletonPage : ContentPage
{
    public SingletonPage()
    {
        InitializeComponent();
        BindingContext = ViewModels.SingletonPageViewModel.Instance;
    }
}