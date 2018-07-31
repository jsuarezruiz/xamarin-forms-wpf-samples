﻿using Xamarin.Forms.Platform.WPF;

namespace UsingMessagingCenter.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();
            Xamarin.Forms.Forms.Init();         
            LoadApplication(new UsingMessagingCenter.App());
        }
    }
}
