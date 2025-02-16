namespace Desktop.Views;

using Application.Extensives;
using Domain.Exceptions;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
	/// <summary>
	/// Validates the fields of the interface 
	/// to ensure required properties are filled
	/// </summary>
	private void ValidateFields()
	{
		if (NameTextBox.Text.IsNull()) throw new PropertyRequiredException("O nome é obrigatório");
		if (PriceTextBox.Text.IsNull()) throw new PropertyRequiredException("O preço é obrigatório");
		if (QuantityTextBox.Text.IsNull()) throw new PropertyRequiredException("A quantidade é necessária");
	}
}