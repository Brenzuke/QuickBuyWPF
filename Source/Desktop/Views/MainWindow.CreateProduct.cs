namespace Desktop.Views;

using Domain.Enumerations;
using System;
using System.Windows;
using System.Windows.Controls;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Creates a new product using the 
	/// data entered in the UI and inserts 
	/// it into the product service
	/// </summary>
	private void CreateProduct() =>
		_service.Insert(new()
		{
			Name = NameTextBox.Text,
			Price = Convert.ToDecimal(PriceTextBox.Text),
			Quantity = Convert.ToInt16(QuantityTextBox.Text),
			Store = Enum.Parse<StoreType>(((ComboBoxItem)StoreTypeCombo.SelectedItem).Tag.ToString())
		});
}