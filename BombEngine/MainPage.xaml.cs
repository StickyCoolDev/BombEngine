using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Android.App;
using Android.OS;
using Android.Views;
using Platform = Microsoft.Maui.ApplicationModel.Platform;
using Android.Graphics;


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
                NoProjectLabel.HorizontalTextAlignment = Microsoft.Maui.TextAlignment.Center;
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
        protected override void OnAppearing()
        {
            base.OnAppearing();


            var window = Platform.CurrentActivity?.Window;
            Platform.CurrentActivity.RequestedOrientation = Android.Content.PM.ScreenOrientation.Landscape;
            //window.SetNavigationBarColor(Android.Graphics.Color.White);
            window.DecorView.SystemUiVisibility = (StatusBarVisibility)(
                    (int)SystemUiFlags.LayoutFullscreen |
                    (int)SystemUiFlags.LayoutHideNavigation |
                    (int)SystemUiFlags.LayoutFullscreen |
                    (int)SystemUiFlags.HideNavigation |
                    (int)SystemUiFlags.Fullscreen |
                    (int)SystemUiFlags.ImmersiveSticky);

            if (window != null)
            {
                // Hide the status bar (API level 16+)
                window.SetFlags(WindowManagerFlags.Fullscreen, WindowManagerFlags.Fullscreen);

            }
        }
    }
}