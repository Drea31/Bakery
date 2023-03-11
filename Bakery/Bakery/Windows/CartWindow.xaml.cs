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
using System.Windows.Shapes;
using Bakery.ClassHelper;
using static Bakery.ClassHelper.EFClass;
using Bakery.Windows;
using Bakery.DB;
using System.Xml;
using System.Security.Cryptography.X509Certificates;

namespace Bakery.Windows
{
    /// <summary>
    /// Логика взаимодействия для CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        public CartWindow()
        {
            InitializeComponent();

            LvCartProduct.ItemsSource = ClassHelper.CartProductClass.products;
        }
        private void BtnDelToCartProduct_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }

            var product = button.DataContext as Product;

            if (product != null)
            {
                ClassHelper.CartProductClass.products.Remove(product);

                LvCartProduct.ItemsSource = ClassHelper.CartProductClass.products;
                
                
            }
            CartWindow cartwindow = new CartWindow();
            cartwindow.Show();
            this.Close();
        }

        private void BtnBuyProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
