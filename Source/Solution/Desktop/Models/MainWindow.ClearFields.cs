namespace Desktop.Models;

using System.Windows;

/// <summary>
/// Interaction logic 
/// for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Clears all input 
	/// fields in the form
	/// </summary>
	private void ClearFields()
	{
		NameField.Text = string.Empty;
		PriceField.Text = string.Empty;
		QuantityField.Text = string.Empty;
	}
}