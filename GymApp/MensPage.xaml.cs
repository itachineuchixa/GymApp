namespace GymApp;

public partial class MensPage : ContentPage
{
	public MensPage()
	{
		InitializeComponent();
	}
    private void Btn1_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LvlPage());
    }
}