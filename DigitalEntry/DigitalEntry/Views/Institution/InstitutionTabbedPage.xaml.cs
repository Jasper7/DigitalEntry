using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DigitalEntry.Views.Institution
{
    public partial class InstitutionTabbedPage : TabbedPage
    {
        public InstitutionTabbedPage()
        {
            InitializeComponent();

            MainTab.IconImageSource = new FontImageSource()
            {
                FontFamily = "IconsRegularFont",
                Glyph = Consts.ScheduleIcon,
                Size = 24
            };

            //ClassTab.IconImageSource = new FontImageSource()
            //{
            //    FontFamily = "IconsRegularFont",
            //    Glyph = Consts.ClassIcon,
            //    Size = 24
            //};

            //ParentTab.IconImageSource = new FontImageSource()
            //{
            //    FontFamily = "IconsRegularFont",
            //    Glyph = Consts.ParentIcon,
            //    Size = 24
            //};

            ChildTab.IconImageSource = new FontImageSource()
            {
                FontFamily = "IconsRegularFont",
                Glyph = Consts.ChildIcon,
                Size = 24
            };

            HistoryTab.IconImageSource = new FontImageSource()
            {
                FontFamily = "IconsRegularFont",
                Glyph = Consts.HistoryIcon,
                Size = 24
            };
        }
    }
}

