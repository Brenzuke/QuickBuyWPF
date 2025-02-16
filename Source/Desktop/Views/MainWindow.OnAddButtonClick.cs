namespace Desktop.Views;

using System;
using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Handles the click event for 
	/// adding a product to the cart
	/// </summary>
	private void OnAddButtonClick(object sender, RoutedEventArgs e)
	{
		try { AddProductToCart(); }
		catch (Exception ex) { Notification(ex.Message); }
	}
}