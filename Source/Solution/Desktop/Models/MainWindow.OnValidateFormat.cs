namespace Desktop.Models;

using Application.Extensives;
using Domain.Exceptions;
using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Ensures that fields 
	/// contain valid formats
	/// </summary>
	private void OnValidateFormat()
	{
		if (!NameField.Text.IsMatch()) throw new UnsupportedPropertyException("O nome não pode ter caracteres especiais!");
		if (!PriceField.Text.ToDecimal().IsMatch()) throw new UnsupportedPropertyException("O preço deve ter apenas números!");
		if (!QuantityField.Text.ToShort().IsMatch()) throw new UnsupportedPropertyException("A quantidade deve ter apenas números!");
	}
}