﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserInterface.ViewModels;

namespace UserInterface.Views
{
    /// <summary>
    /// Interaktionslogik für RegistrationPage2.xaml
    /// </summary>
    public partial class RegistrationPage2 : Page
    {
        public RegistrationPage2()
        {
            InitializeComponent();

            (this.DataContext as RegistrationViewModel).NavigateToForm3 += OnNavigateToForm3;
        }

        public void OnNavigateToForm3(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegistrationPage3());
        }
    }
}
