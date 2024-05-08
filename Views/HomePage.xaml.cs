using MainPage.ViewModels;

namespace MainPage.Views;

public partial class HomePage : ContentPage
{
	public HomePage(LoginPageViewModel loginPageViewModel)
	{
		InitializeComponent();
		this.BindingContext = loginPageViewModel;
	}
}