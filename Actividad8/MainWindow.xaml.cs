using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Actividad8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nombreTextBox.Tag = nombreTextBlock;
            apellidoTextBox.Tag = apellidoTextBlock;
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBlock textBlock = ((sender as TextBox).Tag) as TextBlock;
            if (e.Key == Key.F1 && textBlock.Visibility == Visibility.Hidden)
                textBlock.Visibility = Visibility.Visible;
            else if (e.Key == Key.F1)
                textBlock.Visibility = Visibility.Hidden;
        }

        private void ApellidoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1 && apellidoTextBlock.Text == "")
                apellidoTextBlock.Text = apellidoTextBlock.Tag.ToString();
            else if (e.Key == Key.F1)
                apellidoTextBlock.Text = "";
        }

        private void EdadTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2 && !int.TryParse(edadTextBox.Text, out _))
                edadTextBlock.Text = edadTextBlock.Tag.ToString();
            else if (e.Key == Key.F2)
                edadTextBlock.Text = "";
        }
    }
}
