namespace Desktop.Models;

using Domain.Entities;
using System.Windows;

/// <summary>
/// Interaction logic 
/// for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Displays a warning notification 
	/// before deleting a product
	/// </summary>
	private void ConfirmAndDeleteProduct(Product product)
	{
		MessageBoxResult warning = NotificationWarning(
			$"Deseja remover '{product.Name}'?", "Aviso", MessageBoxButton.YesNo);
		if (warning != MessageBoxResult.Yes) return;
		else HandleProductDeletion(product.Name);
	}
}