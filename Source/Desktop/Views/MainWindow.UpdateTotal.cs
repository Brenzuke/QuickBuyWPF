namespace Desktop.Views;

using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Updates the total value 
	/// of the products in the cart
	/// </summary>
	private void UpdateTotal() =>
		TotalTextBlock.Text = $"R$ {CalculatedItem():N2}";
}
