﻿using FreshFruit.Controller;
using FreshFruit.Model;
using System;
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

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller nibras;
        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(2);
            BucketController bucketController = new BucketController(keranjangBuah, this);

            nibras = new Seller("nibras", bucketController);
            listBoxBucket.ItemsSource = keranjangBuah.findAll();
        }

        public void onFailed(string massage)
        {
            MessageBox.Show(massage);
        }

        public void onSucceed(string massage)
        {
            listBoxBucket.Items.Refresh();
        }

        private void OnButtonAddanggurClicked(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            nibras.addFruit(anggur);

            listBoxBucket.Items.Refresh();
        }

        private void OnButtonAddAppleClicked(object sender, RoutedEventArgs e)
        {
            Fruit apple = new Fruit("Apple");
            nibras.addFruit(apple);

            listBoxBucket.Items.Refresh();
        }

        private void OnButtonAddBananaClicked(object sender, RoutedEventArgs e)
        {
            Fruit banana = new Fruit("Banana");
            nibras.addFruit(banana);

            listBoxBucket.Items.Refresh();
        }

        private void OnButtonAddOrangeClicked(object sender, RoutedEventArgs e)
        {
            Fruit orange = new Fruit("Orange");
            nibras.addFruit(orange);

            listBoxBucket.Items.Refresh();
        }
    }
}
