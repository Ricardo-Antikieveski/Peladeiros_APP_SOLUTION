using Peladeiros_APP.XAML_FORMS.home_forms;
using Peladeiros_APP.XAML_FORMS.login_forms;

namespace Peladeiros_APP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new App_loading()))
            {
                Width = 448,
                Height = 998,
                Title = "Peladeiros Football APP"
            };
        }
    }
}