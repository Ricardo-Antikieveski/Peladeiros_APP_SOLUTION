namespace Peladeiros_APP.XAML_FORMS.login_forms;

public partial class App_loading : ContentPage
{
	public App_loading()
	{
		InitializeComponent();

	    NavigationPage.SetHasNavigationBar(this, false);

		Task.Run(async () =>
		{
			await Task.Delay(2800);
			MainThread.BeginInvokeOnMainThread(() =>
			{
                Navigation.PushAsync(new Login_client());
            });
		});
	}
}