namespace Desktop.Views;

using Domain.Entities;
using System.Windows;
using System.Windows.Controls;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Triggers the event to remove a 
	/// selected product from the cart
	/// </summary>
	private void OnRemoveButtonClick(object sender, RoutedEventArgs e)
	{
		if (sender is Button button && button.CommandParameter is Product selectedProduct)
		{
			_service.DeleteByName(selectedProduct.Name);
			UpdateCartDisplay();
		}
	}
}