using Peladeiros_APP.XAML_FORMS.home_forms;

namespace Peladeiros_APP.XAML_FORMS.login_forms;

public partial class Login_client : ContentPage
{
	public Login_client()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (username_entry.Text == null || password_entry.Text == null || username_entry.Text.Length < 1 || password_entry.Text.Length < 1)
            {
                throw new Exception("Por favor preencha todos os campos.");
            }

            if (username_entry.Text == "admin" && password_entry.Text == "admin")
            {
                await SecureStorage.Default.SetAsync("usuario_logado", username_entry.Text);
                await Navigation.PushAsync(new App_home());
                
            }
            else
            {
                throw new Exception($"Suas credencias estão incorretas.");
                //await DisplayAlert("Login Aviso", "Usuario e/ou senha incorretos! \nVerifique e tente novamente.", "Fechar");
            }

        }
        catch (Exception Erro)
        {
            await DisplayAlert("Aviso!", Erro.Message, "Fechar");
        }

    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void ImageButton_Clicked_1(object sender, EventArgs e)
    {

    }
}