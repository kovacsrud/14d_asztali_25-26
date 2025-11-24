using MauiJegyzetV214d2025.mvvm.viewmodel;

namespace MauiJegyzetV214d2025.mvvm.view;

public partial class JegyzetInput : ContentPage
{
	bool modosit=false;
	public JegyzetInput()
	{
		InitializeComponent();
	}

    public JegyzetInput(bool modosit,JegyzetViewModel vm)
    {
        InitializeComponent();
        this.modosit = modosit;
        BindingContext = vm;
    }

    private async void buttonInput_Clicked(object sender, EventArgs e)
    {
        var vm = BindingContext as JegyzetViewModel;

        if (modosit) {
            //módósítás
            labelCim.Text = "Jegyzet módosítása";

            var result =await DisplayAlert("Módosítás", "Biztosan módosítja?", "Igen","Nem");

            if (result)
            {
                App.JegyzetRepo.UpdateItem(vm.AktualisJegyzet);
                vm.GetJegyzetek();
            }

        } else
        {
            //új jegyzet
            App.JegyzetRepo.NewItem(new model.Jegyzet { Cim=entryCim.Text,Szoveg=entrySzoveg.Text});
            vm.GetJegyzetek();

        }
    }
}