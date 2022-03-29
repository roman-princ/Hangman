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

namespace Hangman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int lineX1 = 10;
            int lineX2 = 20;
            for (int i = 0; i < 10; i++)
            {
                var line = new Line();

                line.Stroke = new SolidColorBrush(Colors.Black);
                line.StrokeThickness = 2;
                line.X1 = lineX1;
                line.X2 = lineX2;



                textLines.Children.Add(line);

                lineX1 += 30;
                lineX2 += 40;
            }
            Console.WriteLine("bu");
        }
    
    }
}
