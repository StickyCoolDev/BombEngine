using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using BombEngine;

namespace BombEngine
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register all of the pages
            Routing.RegisterRoute(nameof(NewProjectPage), typeof(NewProjectPage));
            Routing.RegisterRoute(nameof(AllLicensePage), typeof(AllLicensePage));
            Routing.RegisterRoute(nameof(CreateProjectLoadingPage), typeof(CreateProjectLoadingPage));
            Routing.RegisterRoute(nameof(EditorPage), typeof(EditorPage));
        }
    }
}