namespace GymApp;

public partial class LvlPage : ContentPage
{
	public LvlPage()
	{
		InitializeComponent();
	}
    private void Btn1_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new WeightPage());
    }
}