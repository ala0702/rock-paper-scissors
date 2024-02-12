using System.Windows;
using System.Windows.Controls;
using papier_kamien_nozyce.Views;

namespace papier_kamien_nozyce
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Code behind.
    /// what to do with visual elements
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartGameButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl computer_vs_computer = new UserControl_c_vs_c();
            this.Content = computer_vs_computer;
        }

        private void StartGameButton_HvsC_Click(object sender, RoutedEventArgs e)
        {
            UserControl human_vs_computer = new UserControl_human_vs_computer();
            this.Content = human_vs_computer;
        }
    }
}
