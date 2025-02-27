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
	/// Ensures that numerical values 
	/// follow the expected constraints
	/// </summary>
	private void OnValidateConstraints()
	{
		if (PriceField.Text.ToDecimal().IsNegative()) throw new PropertyConstraintException("O preço não pode ser negativo!");
		if (QuantityField.Text.ToShort().IsNegative()) throw new PropertyConstraintException("A quantidade não pode ser negativa!");
	}
}