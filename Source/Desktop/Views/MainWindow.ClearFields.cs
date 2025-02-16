namespace Desktop.Views;

using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Clears input fields 
	/// after saving a product
	/// </summary>
	private void ClearFields()
	{
		NameTextBox.Text = string.Empty;
		PriceTextBox.Text = string.Empty;
		QuantityTextBox.Text = string.Empty;
	}
}