using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using CommunityToolkit.Maui.Storage;
using Kotlin;

namespace BombEngine
{
    public partial class NewProjectPage : ContentPage
    {
        public NewProjectPage()
        {
            InitializeComponent();

        }
        async private void ShowFileDialog(object sender, EventArgs e)
        {
            var Resault = await FolderPicker.PickAsync(""); // Ask to select a folder
            var writer = new StreamWriter("null");
            await writer.WriteLineAsync("cool");

            FileSaver.SaveAsync(Resault.Folder.Path, "log.txt", writer.BaseStream);
            SelectFileButton.Text = "Folder :" + Resault.Folder.Name;
        }
    }
}