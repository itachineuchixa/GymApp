﻿using Microsoft.Maui.Controls;
namespace GymApp;

public partial class App : Application
{
    public App()
	{
		InitializeComponent();
		MainPage = new AppShell();
    }
}
