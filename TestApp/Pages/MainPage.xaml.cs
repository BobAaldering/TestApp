namespace TestApp.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();

        BindingContext = new PageModels.MainPageModel();
    }
}