using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using CommunityToolkit.Maui.Core.Views;
using CommunityToolkit.Maui.Core.Handlers;
using Microsoft.Maui.Graphics;


namespace BombEngine
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            if (ProjectLayoutContainer.Children.Count == 0)
            {
                var NoProjectLabel = new Label();
                NoProjectLabel.TextColor = Colors.Black;
                NoProjectLabel.HorizontalTextAlignment = TextAlignment.Center;
                NoProjectLabel.Text = "No projects \n Create New Project?";
                ProjectLayoutContainer.Add(NoProjectLabel);
            }

        }

        // When the New Project Button is Pressed
        // it take you to the NewProjectPage
        async private void AddNewProject(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new NewProjectPage());
        }
        // When the New Title Button is Pressed
        // it take you to the AllLicensePage
        async private void OnTitleButtonCliked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AllLicensePage());
        }
    }
}