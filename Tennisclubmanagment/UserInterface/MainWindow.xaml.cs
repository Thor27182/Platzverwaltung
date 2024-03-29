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

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            LoginPage loginPage = new LoginPage();
            // Anbinden fuer Button-Klick
            loginPage.NavigateBackHandler += GoToMainWindowPage;
            // Inhalt des Frames des Fensters anpassen
            this.Content = loginPage;

        }

        private void GoToLogin(object sender, RoutedEventArgs e)
        {
            // Login-Page-Objekt erstellen
            LoginPage loginPage = new LoginPage();
            // Anbinden fuer Button-Klick
            loginPage.NavigateBackHandler += GoToMainWindowPage;
            // Inhalt des Frames des Fensters anpassen
            this.Content = loginPage;
        }

        private void GoToRegistration(object sender, RoutedEventArgs e)
        {
            // Registrierungs-Page-Objekt erstellen
            RegistrationPage rp = new RegistrationPage();
            // Inhalt des Frames des Fensters anpassen
            this.Content = rp;
        }

        private void GoToMainWindowPage(object sender, EventArgs e)
        {
            // TODO: Subscription zum Eventhandler entfernen
            // Inhalt des Frames des Fensters leeren
            this.Content = null;
        }



        // Seitenverwaltung:
        // https://mycsharp.de/forum/threads/123158/wie-in-einem-frame-im-mainwindow-durch-buttons-pages-anzeigen-die-einmalig-initialisiert-wurden?page=1

        // https://www.youtube.com/watch?v=aBh0weP1bmo

    }
}
