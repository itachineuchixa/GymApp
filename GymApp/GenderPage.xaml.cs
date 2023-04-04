using System.Runtime.CompilerServices;

namespace GymApp;

public partial class GenderPage : ContentPage
{
	public string Gender = "";
	public GenderPage()
	{
	
		InitializeComponent();
	}

    private void Btn1_Clicked(object sender, EventArgs e)
    {
		Gender = "Female";
    }

    private void Btn2_Clicked(object sender, EventArgs e)
    {
        Gender = "Male";
    }

    private void Btn3_Clicked(object sender, EventArgs e)
    { if (Gender == "Male")
        {
            Navigation.PushAsync(new MensPage());
        }
    else { }
    }
}