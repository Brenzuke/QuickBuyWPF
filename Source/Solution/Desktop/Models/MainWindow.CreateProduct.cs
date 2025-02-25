namespace Desktop.Models;

using Domain.Entities;
using System;
using System.Windows;

/// <summary>
/// Interaction logic 
/// for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Creates a new Product 
	/// instance based on the 
	/// form input fields
	/// </summary>
	private Product CreateProduct() =>
		new()
		{
			Name = NameField.Text,
			CreatedAt = DateTime.Now.Date,
			Price = Convert.ToDecimal(PriceField.Text),
			Quantity = Convert.ToInt16(QuantityField.Text)
		};
}