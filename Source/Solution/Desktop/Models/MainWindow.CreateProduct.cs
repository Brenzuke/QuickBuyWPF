namespace Desktop.Models;

using Application.Extensives;
using Domain.Entities;
using System;
using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Creates a new product 
	/// from form inputs.
	/// </summary>
	private Product CreateProduct() =>
		new()
		{
			Name = NameField.Text,
			CreatedAt = DateTime.Now.Date.ToFormattedBrazilianDate(),
			Price = Convert.ToDecimal(PriceField.Text),
			Quantity = Convert.ToInt16(QuantityField.Text)
		};
}