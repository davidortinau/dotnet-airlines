namespace Airlines;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		App.Current.UserAppTheme = AppTheme.Light;
	}
}
