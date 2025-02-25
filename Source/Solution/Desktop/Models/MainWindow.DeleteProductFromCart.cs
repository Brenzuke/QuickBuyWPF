namespace Desktop.Models;

using Domain.Entities;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

/// <summary>
/// Interaction logic 
/// for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	private void DeleteProductFromCart(object sender, RoutedEventArgs e)
	{
		if (sender is Button button && button.Tag is Product product)
		{
			string productName = product.Name;
			MessageBoxResult result = MessageBox.Show(
			$"Deseja remover {productName}?",
			"Confirmação",
			MessageBoxButton.YesNo,
			MessageBoxImage.Warning);

			if (result == MessageBoxResult.Yes)
			{
				_service.DeleteByName(productName);
				ProductList.ItemsSource = null;
				UpdateTotal(ProductList.Items.Cast<Product>().ToHashSet());
			}
		}
	}
}