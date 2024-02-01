﻿using Microsoft.UI.Xaml.Controls;

using SoundGuess.ViewModels;

namespace SoundGuess.Views;

public sealed partial class HomePage : Page
{
    public HomeViewModel ViewModel
    {
        get;
    }

    public HomePage()
    {
        ViewModel = App.GetService<HomeViewModel>();
        InitializeComponent();
    }
}
