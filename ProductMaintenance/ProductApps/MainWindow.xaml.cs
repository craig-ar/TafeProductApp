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

namespace ProductApps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Product cProduct;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //cProduct = new Product(Convert.ToDecimal(priceTextBox.Text), Convert.ToInt16(quantityTextBox.Text));
                //cProduct.calTotalPayment();
                //totalPaymentTextBlock.Text = Convert.ToString(cProduct.TotalPayment);


                int quantity = Convert.ToInt32(quantityTextBox.Text.Trim());
                decimal price = Convert.ToDecimal(priceTextBox.Text.Trim());
                decimal total = price * quantity;
                decimal totalCharge = total + 25;
                decimal addWrap = totalCharge + 5;

                totalChargeTextBlock.Text = total.ToString();
                totalPaymentTextBlock.Text = Convert.ToString(totalCharge);
                addWrapTextBlock.Text = addWrap.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter data again", "Data Entry Error");
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            productTextBox.Text = "";
            priceTextBox.Text = "";
            quantityTextBox.Text = "";
            totalPaymentTextBlock.Text = "";
            totalChargeTextBlock.Text = "";
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
