using MauiMvvm14d2025.Mvvm.ViewModel;

namespace MauiMvvm14d2025.Mvvm.View;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
		BindingContext = new NevViewModel();
	}

    private void buttonTovabb_Clicked(object sender, EventArgs e)
    {
		var vm=BindingContext as NevViewModel;
		Navigation.PushAsync(new MiddlePage {BindingContext=vm });
    }
}