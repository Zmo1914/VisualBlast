using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Maps.MapControl.WPF;

namespace VisualBlast
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //appMap.Mode = new AerialMode(true);
        }

        private void MapWithPushpins_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Disables the default mouse double-click action.
            e.Handled = true;

            // Determin the location to place the pushpin at on the map.

            //Get the mouse click coordinates
            Point mousePosition = e.GetPosition(this);
            //Convert the mouse coordinates to a locatoin on the map
            Location pinLocation = appMap.ViewportPointToLocation(mousePosition);

            // The pushpin to add to the map.
            Pushpin pin = new Pushpin();
            pin.Location = pinLocation;

            // Adds the pushpin to the map.
            appMap.Children.Add(pin);
            //appMap.Children.Remove(pin);
        }

        //TODO:Да направя бутон, който трие всички пинчета на картата

        //TODO: Да направя буто, който изтрива последният пин
        private void DeleteAllPushpins_MouseRightClick(object sender, MouseButtonEventArgs e)
        {
            appMap.Children.Clear();
        }

        private void ClearAllPins(object sender, RoutedEventArgs e)
        {
            appMap.Children.Clear();

        }

        private void Button_Click_OpenWindow(object sender, RoutedEventArgs e)
        {
            OpenWIndow openWIndow = new OpenWIndow();
            openWIndow.ShowInTaskbar = false;
            openWIndow.Owner = Application.Current.MainWindow;
            openWIndow.ShowDialog();
        }
    }
}
