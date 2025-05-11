using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using CommunityToolkit.Maui.Core.Views;
using CommunityToolkit.Maui.Core.Handlers;


namespace BombEngine
{
    public partial class MainPage : ContentPage
    {
        public static Layout Go;
        public MainPage()
        {
            InitializeComponent();
            Go = ProjectLayoutContainer;
            NewProjectButton.Clicked += AddNewProject;
        }
        // When the New Project Button is Pressed
        // it take you to the NewProjectPage
        async private void AddNewProject(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewProjectPage());

        }
    }
}