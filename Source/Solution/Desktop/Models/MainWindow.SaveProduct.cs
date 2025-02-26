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
	/// Saves the product 
	/// using the service
	/// </summary>
	private void SaveProduct()
	{
		Product product = CreateProduct();
		_service.Insert(product);
	}
}