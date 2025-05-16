using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace BombEngine
{
    public partial class CreateProjectLoadingPage : ContentPage
    {
        public CreateProjectLoadingPage(String ProjectName, String ProjectPath)
        {
            InitializeComponent();
            _OnStart(ProjectName, ProjectPath);
        }



        public async void WriteTextToFile(String text, String targetFileName, String FileDir)
        {

            // Write the file content to the app data directory  
            string targetFile = System.IO.Path.Combine(FileDir, targetFileName);
            using FileStream outputStream = System.IO.File.OpenWrite(targetFile);
            using StreamWriter streamWriter = new StreamWriter(outputStream);
            await streamWriter.WriteAsync(text);

        }

        void _OnStart(String ProjectName, String ProjectPath)
        {
            Directory.CreateDirectory(ProjectPath + "/" + ProjectName);
            WriteTextToFile("{'ProjectName': '" + ProjectName + "'}", "Bomb.json", ProjectPath + "/" + ProjectName);
        }
    }
}