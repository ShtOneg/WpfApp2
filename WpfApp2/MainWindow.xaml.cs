﻿using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Context? context;


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context = new Context();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.Products.Load();
            //datab.DataContext = context.Products.Local.ToBindingList();
            datab.ItemsSource = context.Products.Local.ToBindingList();
        }
    }
}