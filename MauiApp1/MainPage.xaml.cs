using MauiApp1.View.HomePage;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	

    private void Button_Clicked_Home(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Home());
    }
}

