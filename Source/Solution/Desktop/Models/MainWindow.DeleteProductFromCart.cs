namespace Desktop.Models;

using Domain.Entities;
using System.Windows;
using System.Windows.Controls;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Handles product deletion 
	/// when the remove button 
	/// is clicked.
	/// </summary>
	private void DeleteProductFromCart(object sender, RoutedEventArgs e)
	{
		if (sender is Button button && button.Tag is Product product)
			ConfirmAndDeleteProduct(product);
	}
}