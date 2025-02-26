namespace Desktop.Models;

using System;
using System.Windows;

/// <summary>
/// Interaction logic 
/// for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Adds a product to the 
	/// cart using input 
	/// field values.
	/// </summary>
	private void AddProductToCart(object sender, RoutedEventArgs e)
	{
		try
		{
			OnValidate();
			SaveProduct();
			RefreshUI();
			NotificationOk();
		}
		catch (Exception ex)
		{
			ClearFields();
			NotificationError(ex);
		}
	}
}