﻿namespace GymApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void Btn1_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new GenderPage());
    }
}

