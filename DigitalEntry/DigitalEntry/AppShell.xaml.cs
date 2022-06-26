using System;
using System.Collections.Generic;
using DigitalEntry.ViewModels;
using DigitalEntry.Views;
using Xamarin.Forms;

namespace DigitalEntry
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Main.Icon = new FontImageSource()
            {
                FontFamily = "IconsRegularFont",
                Glyph = Consts.ChildIcon,
                Size = 24
            };

            Enter.Icon = new FontImageSource()
            {
                FontFamily = "IconsRegularFont",
                Glyph = Consts.EnterIcon,
                Size = 24
            };
        }

    }
}

