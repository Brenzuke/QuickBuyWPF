namespace Desktop.Models.Forms;

using Application.Services;
using Domain.Entities;
using System;
using System.Windows;
using System.Windows.Controls;

/// <summary>
/// Interaction logic 
/// for ProductForm.xaml
/// </summary>
public partial class ProductForm : UserControl
{
	/// <summary>
	/// Default Constructor
	/// </summary>
	public ProductForm() =>
		InitializeComponent();

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
			ProductService service = new();
			service.Insert(new Product()
			{
				Name = NameField.Text,
				CreatedAt = DateTime.Now.Date,
				Price = Convert.ToDecimal(PriceField.Text),
				Quantity = Convert.ToInt16(QuantityField.Text)
			});

			MessageBox.Show("Produto adicionado com sucesso!", "Aviso", MessageBoxButton.OK);
		}
		catch (Exception ex) { MessageBox.Show(ex.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Warning); }
	}
}