namespace MauiStart;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

    private void buttonSzamol_Clicked(object sender, EventArgs e)
    {
		try
		{
			var szam = Convert.ToInt32(entryAdat.Text);
			szam += 111;
			DisplayAlert("Eredmény",szam.ToString(),"Ok");
		}
		catch (Exception ex)
		{
			DisplayAlert("Hiba", ex.Message, "Ok");
		}
    }
}