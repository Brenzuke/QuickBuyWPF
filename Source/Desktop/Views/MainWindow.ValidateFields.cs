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
		if (NameTextBox.Text.IsNull()) throw new PropertyRequiredException("Por favor, preencha o campo Nome.");
		if (PriceTextBox.Text.IsNull()) throw new PropertyRequiredException("Por favor, preencha o campo Preço.");
		if (QuantityTextBox.Text.IsNull()) throw new PropertyRequiredException("Por favor, preencha o campo Quantidade.");
	}
}