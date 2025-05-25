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


        // Function for writing 
        public async void WriteTextToFile(String text, String targetFileName, String FileDir)
        {
            string targetFile = System.IO.Path.Combine(FileDir, targetFileName);
            using FileStream outputStream = System.IO.File.OpenWrite(targetFile);
            using StreamWriter streamWriter = new StreamWriter(outputStream);
            await streamWriter.WriteAsync(text);

        }

        void _OnStart(String ProjectName, String ProjectPath)
        {
            Directory.CreateDirectory(ProjectPath + "/" + ProjectName);
            string ProjectJson = $"{{ \"ProjectName\": \"{ProjectName}\" }}"; // make project file

            WriteTextToFile(ProjectJson, "Bomb.bomb", ProjectPath + "/" + ProjectName);

        }
    }
}