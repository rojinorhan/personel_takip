using PersonelTakipOtonomSistemi.Services;

namespace PersonelTakipOtonomSistemi.Views;

public partial class LoginViews : ContentPage
{
    private readonly IPersonelServices _personelServices;
    public LoginViews()
	{
		InitializeComponent();
        _personelServices = new PersonelServices();
        
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var gelenTcNo = kullanýcýAdý.Text;
        var gelenPassword = sifre.Text;

        if (gelenTcNo == "Umutcan" && gelenPassword == "1234")
        {
            DisplayAlert($"", "Hoþ Geldiniz.", "Tamam");
            PersonelMenu personelMenu = new PersonelMenu();
            await Navigation.PushAsync(personelMenu);

        }
        else
        {
            DisplayAlert("", "Eksik veya Hatalý Giriþ", "Tamam");
        }
    }


}