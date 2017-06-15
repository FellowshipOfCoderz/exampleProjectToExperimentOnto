using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Game
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

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            
            if(e.Key == Key.Left)
            {
                Canvas.SetLeft(mario, Canvas.GetLeft(mario) - 5);
            }
            else if(e.Key == Key.Up)
            {
                Canvas.SetTop(mario, Canvas.GetTop(mario) - 5);
                
            }
            else if(e.Key == Key.Down)
            {
                
                Canvas.SetTop(mario, Canvas.GetTop(mario) + 5);
            }
            else
            {
                Canvas.SetLeft(mario, Canvas.GetLeft(mario) + 5);
            }

            if(e.Key == Key.Space)
            {

            }
        }
    }
}
