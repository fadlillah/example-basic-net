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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator calculator;
        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
            listData.ItemsSource = calculator.getListItem();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string title = Item.Text;
            int quantity = int.Parse(QuantityBox.Text);
            string type = typeBox.Text;
            double price = double.Parse(priceBox.Text);

            ClassItem item = new ClassItem(new Random().Next(), title, quantity, type, price);
            calculator.addItem(item);
            double total = calculator.getTotal();
            totalLabel.Content = string.Format("Rp. {0}", total);
            listData.Items.Refresh();
        }
    }
}
