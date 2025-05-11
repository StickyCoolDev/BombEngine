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
            Routing.RegisterRoute(nameof(NewProjectPage), typeof(NewProjectPage));
        }
    }
}