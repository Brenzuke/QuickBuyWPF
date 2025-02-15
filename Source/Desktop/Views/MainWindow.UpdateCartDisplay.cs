namespace Desktop.Views;

using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Conforme cada produto inserido, é atualizado em tempo real
	/// </summary>
	private void UpdateCartDisplay()
	{
		CartListBox.ItemsSource = null;
		CartListBox.ItemsSource = _service.GetAll();
	}
}