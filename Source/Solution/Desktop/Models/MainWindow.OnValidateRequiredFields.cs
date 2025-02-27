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
	/// Ensures that all required 
	/// fields are filled
	/// </summary>
	private void OnValidateRequiredFields()
	{
		if (NameField.Text.IsNull()) throw new PropertyRequiredException("O nome do produto é obrigatório!");
		if (PriceField.Text.IsNull()) throw new PropertyRequiredException("O preço do produto é obrigatório!");
		if (QuantityField.Text.IsNull()) throw new PropertyRequiredException("A quantidade do produto é obrigatória!");
	}
}