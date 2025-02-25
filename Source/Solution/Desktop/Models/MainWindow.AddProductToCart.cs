namespace Desktop.Models;

using Domain.Entities;
using System;
using System.Linq;
using System.Windows;

/// <summary>
/// Interaction logic 
/// for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Adds the product to the shopping cart 
	/// by retrieving values from 
	/// the input fields
	/// </summary>
	private void AddProductToCart(object sender, RoutedEventArgs e)
	{
		try
		{
			OnValidate();
			Product product = CreateProduct();
			_service.Insert(product);
			ProductList.Items.Add(product);
			UpdateTotal([.. ProductList.Items.Cast<Product>()]);
			ClearFields();
			NotificationOk("Produto adicionado!");
		}
		catch (Exception ex) { NotificationWarning(ex.Message); }
	}
}