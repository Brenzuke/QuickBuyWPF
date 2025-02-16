namespace Desktop.Views;

using System.Linq;
using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Calculates the total value 
	/// of all products in the cart
	/// </summary>
	private decimal CalculatedItem() =>
		_service.GetAll().Sum(CalculateProductTotal);
}