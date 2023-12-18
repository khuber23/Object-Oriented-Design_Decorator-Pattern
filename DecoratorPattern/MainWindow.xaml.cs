using System.Windows;
using System.Windows.Controls;

namespace DecoratorPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Beverage beverage;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.beverage = null;

            if(houseBlend.IsChecked == true)
            {
                beverage = new HouseBlend();
            }
            else if(darkRoast.IsChecked == true)
            {
                beverage = new DarkRoast();
            }
            else if(espresso.IsChecked== true)
            {
                beverage = new Espresso();
            }
            else if(decaf.IsChecked == true)
            {
                beverage = new Decaf();
            }
            else
            {
                beverage = null;
            }

            try
            {
                if (milkCondiment.IsChecked == true)
                {
                    beverage = new Milk(beverage);
                }
                if (mochaCondiment.IsChecked == true)
                {
                    beverage = new Mocha(beverage);
                }
                if (soyCondiment.IsChecked == true)
                {
                    beverage = new Soy(beverage);
                }
                if (whipCondiment.IsChecked == true)
                {
                    beverage = new Whip(beverage);
                }
            }
            catch
            {
                MessageBox.Show("Need to Order Coffee");
            }

            try
            {
                descriptionLabel.Content = beverage.Description;
                priceLabel.Content = beverage.Cost;
            }
            catch
            {
                MessageBox.Show("Select a coffee to order");
            }
            
            
        }
    }
}