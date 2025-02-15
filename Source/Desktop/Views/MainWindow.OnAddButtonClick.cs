namespace Desktop.Views;

using Domain.Entities;
using Domain.Enumerations;
using System;
using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Dispara o salvamento do produto
	/// </summary>
	private void OnAddButtonClick(object sender, RoutedEventArgs e)
	{
		try
		{
			Product product = new()
			{
				Name = NameTextBox.Text,
				Store = StoreType.Supermarket,
				Price = Convert.ToDecimal(PriceTextBox.Text),
				Quantity = Convert.ToInt16(QuantityTextBox.Text)
			};

			_validator.OnValidate(product);
			_service.Insert(product);
			UpdateCartDisplay();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Erro de Validação", MessageBoxButton.OK, MessageBoxImage.Warning);
		}
	}
}