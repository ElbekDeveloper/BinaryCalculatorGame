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

namespace Calculator_Game_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Declare properties for generating random numbers 
        private Random Rand { get; set; } = new Random();
        private int RandomInt { get; set; }

        private int Total { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            btnCheck.IsEnabled = false;
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            //Enable check Button
            btnCheck.IsEnabled = true;

            //Clean Answer section
            lblAnswer.Content = "";

            //set every textbox content to 0
            foreach (var item in mainGrid.Children.OfType<TextBox>())
            {
                item.Text = "0";
            }

            //Generate random number
            //Max is 511 due to text boxes are limited 
            RandomInt = Rand.Next(0, 511);

            //Ask a Question from user
            tbxQuestion.Content = $"What is { RandomInt} in binary?";

        }

        private void Help(object sender, RoutedEventArgs e)
        {
            string helpMessage = $"I am too lazy to write instruction for the user. Sorry...";
            string title = "Help Needed?";
            MessageBox.Show(helpMessage, title);

        }

        private void Check(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
