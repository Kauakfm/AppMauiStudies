namespace AppNavigationPage;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void OnButtonNextCliked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Page3());
    }
    private void OnButtonPreviusCliked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}