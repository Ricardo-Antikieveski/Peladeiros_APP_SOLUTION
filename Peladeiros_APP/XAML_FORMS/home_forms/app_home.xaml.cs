using Peladeiros_APP.XAML_FORMS.home_forms.escala_time_forms;

namespace Peladeiros_APP.XAML_FORMS.home_forms;

public partial class App_home : ContentPage
{
	public App_home()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

	//Selecionar Perfil media
	private async void SelectMedia(object sender, EventArgs e)
	{
		try
		{
			var Media = await MediaPicker.PickPhotoAsync();
			if(Media != null)
			{
				var Stream = await Media.OpenReadAsync();
				profileImage.Source = ImageSource.FromStream(() => Stream);
			}
		}
		catch(Exception Erro) 
		{
			await DisplayAlert("Media Error", "Não foi possivel selecionar a imagem: " + Erro.Message, "OK");
		}
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        Opacity = 0;
        Scale = 0.8;

        await Task.WhenAll(
            this.FadeTo(1, 500),  // A página aparece suavemente
            this.ScaleTo(1, 500, Easing.CubicOut) // A página cresce suavemente
        );
    }

    private async void Escalar_time_aleatorio_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Escalar_Time_Aleatorio());
    }

    private void Escalar_time_pronto_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Media Error", "Botao Escalar time pronto clicado", "OK");
    }
}