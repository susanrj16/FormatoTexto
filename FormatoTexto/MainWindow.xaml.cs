using System.Windows;
using System.Windows.Media;

namespace FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            formatoTextBlock.Foreground = Brushes.Red;
            //formatoTextBlock.Text = cuadro1TextBox.Text;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            formatoTextBlock.Foreground = Brushes.Green;
            //formatoTextBlock.Text = cuadro1TextBox.Text;
        }

        private void negritaBoton_Click(object sender, RoutedEventArgs e)
        {
            if (negritaBoton.IsChecked == true)
                formatoTextBlock.FontWeight = FontWeights.Bold;
            else
                formatoTextBlock.FontWeight = FontWeights.Normal;

        }

        private void cursivaBoton_Click(object sender, RoutedEventArgs e)
        {
            if (cursivaBoton.IsChecked == true)
                formatoTextBlock.FontStyle = FontStyles.Italic;
            else
                formatoTextBlock.FontStyle = FontStyles.Normal;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
            formatoTextBlock.Foreground = Brushes.Blue;
        }

        private void cuadro1TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            formatoTextBlock.Text = cuadro1TextBox.Text;
        }
    }
}
