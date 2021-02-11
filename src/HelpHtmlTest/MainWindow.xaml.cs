using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace HelpHtmlTest
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

        private void Button_Click(object sender, RoutedEventArgs e) =>
            coockieCounter.Text = (int.Parse(coockieCounter.Text) + 1).ToString();

        private void Button_HelpClick(object sender, RoutedEventArgs e)
        {
            string htmlFilePath = "Resources/help.html";
            var pi = new ProcessStartInfo("cmd", $"/c start {htmlFilePath}") { CreateNoWindow = true };
            Process.Start(pi)?.WaitForExit();
        }
    }
}
