using System.Windows;
using RoboboKitchenProject.ModelView;


namespace RoboboKitchenProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();

        }

        private void BTNExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
