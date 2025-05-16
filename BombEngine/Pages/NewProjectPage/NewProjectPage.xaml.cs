using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using CommunityToolkit.Maui.Storage;
using Microsoft.Maui.ApplicationModel;
using Android.Widget;

namespace BombEngine
{
    public partial class NewProjectPage : ContentPage
    {
        String ProjectPath = "";
        public NewProjectPage()
        {
            InitializeComponent();

        }
        async private void ShowFileDialog(object sender, EventArgs e)
        {

            FolderPickerResult Resault = null;
            try
            {
                Resault = await FolderPicker.PickAsync(""); // Ask to select a folder

            }
            catch (Exception erro)
            {
                Console.WriteLine("error :" + erro.ToString());
            }


            try
            {
                ProjectPath = Resault.Folder.Path;
                SelectFileButton.Text = "Selected : " + Resault.Folder.Name;
            }
            catch (NullReferenceException Error)
            {

            }

        }
        async private void CreateNewProject(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProjectNameEntry.Text))
            {
                Toast.Show("Please enter project name");
                return;
            }
            if (ProjectPath == "")
            {
                Toast.Show("Please select project path");
                return;
            }

            await Navigation.PushAsync(new CreateProjectLoadingPage(ProjectNameEntry.Text, ProjectPath));
        }
    }
}