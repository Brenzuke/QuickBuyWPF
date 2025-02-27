namespace Desktop.Models;

using System;
using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Adds a product to cart 
	/// from input values.
	/// </summary>
	private void AddProductToCart(object sender, RoutedEventArgs e)
	{
		try
		{
			OnValidate();
			SaveProduct();
			RefreshUI();
			NotificationOk("Produto adicionado!", "Sucesso");
		}
		catch (Exception ex)
		{
			ClearFields();
			NotificationError(ex);
		}
	}
}