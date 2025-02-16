namespace Desktop.Views;

using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Updates the shopping cart display in real-time 
	/// whenever a product is added or removed.
	/// </summary>
	private void UpdateCartDisplay()
	{
		CartListBox.ItemsSource = null;
		CartListBox.ItemsSource = _service.GetAll();
	}
}