﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace MaterialWPF.Controls
{
    /// <summary>
    /// Interaction logic for Splash.xaml
    /// </summary>
    public partial class Splash : UserControl
    {
        public static readonly DependencyProperty SubTitleProperty = DependencyProperty.Register("SubTitle", typeof(string), typeof(Splash));
        public static readonly DependencyProperty VersionProperty = DependencyProperty.Register("Version", typeof(string), typeof(Splash));
        public static readonly DependencyProperty LogoProperty = DependencyProperty.Register("Logo", typeof(ImageSource), typeof(Splash));
        public string Version
        {
            get
            {
                return this.GetValue(VersionProperty) as string;
            }
            set
            {
                this.SetValue(VersionProperty, value);
            }
        }
        
        public string SubTitle
        {
            get
            {
                return this.GetValue(SubTitleProperty) as string;
            }
            set
            {
                this.SetValue(SubTitleProperty, value);
            }
        }

        public ImageSource Logo
        {
            get
            {
                return this.GetValue(LogoProperty) as ImageSource;
            }
            set
            {
                this.SetValue(LogoProperty, value);
            }
        }

        public Splash()
        {
            InitializeComponent();
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                Application.Current.MainWindow.DragMove();
        }
    }
}
