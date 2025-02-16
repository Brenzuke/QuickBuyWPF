namespace Desktop.Views;

using Domain.Entities;
using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Calculates the total price for a 
	/// given product by multiplying 
	/// its price with its quantity
	/// </summary>
	private static decimal CalculateProductTotal(Product product) =>
		product.Price * product.Quantity;
}