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

namespace BudzetoweKanapkiJarkaNiechluja
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        private void MakeTheMenu() {
            MenuItem[] menu = new MenuItem[5];
            string guacamolePrice;

            for(int i = 0; i < menu.Length; i++)
            {
                menu[i] = new MenuItem();
                if(i >= 3)
                {
                    menu[i].Breads = new string[] { "zwykły rogal", "rogal cebulowy", "rogal z pumpernikielem", "rogal z wszystkim" };
                }
                menu[i].Generate();
            }

            item1.Text = menu[0].Description;
            price1.Text = menu[0].Price;
            item2.Text = menu[1].Description;
            price2.Text = menu[1].Price;
            item3.Text = menu[2].Description;
            price3.Text = menu[2].Price;
            item4.Text = menu[3].Description;
            price4.Text = menu[3].Price;
            item5.Text = menu[4].Description;
            price5.Text = menu[4].Price;

            MenuItem specialMenuItem = new MenuItem()
            {
                Proteins = new string[] { "Szynka organiczna", "Burger z grzybów", "Mortadela" },
                Condiments = new string[] { "musztarda diżońska", "sos z miso", "au jus" },
                Breads = new string[] { "bułka bezglutenowa", "tortilla", "pita" },
            };
            specialMenuItem.Generate();
            item6.Text = specialMenuItem.Description;
            price6.Text = specialMenuItem.Price;

            MenuItem guacamoleItem = new MenuItem();
            guacamoleItem.Generate();
            guacamolePrice = guacamoleItem.Price;
            guacamole.Text = $"Dodaj guacamole za {guacamolePrice}";
        }
    }
}
