namespace Airlines;

public partial class OnboardingPage : ContentPage
{
	public OnboardingPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("///booking");
    }
}