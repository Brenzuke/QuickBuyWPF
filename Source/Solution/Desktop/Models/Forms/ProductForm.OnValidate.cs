namespace Desktop.Models.Forms;

using Application.Extensives;
using Domain.Exceptions;
using System;
using System.Windows.Controls;

/// <summary>
/// Interaction logic 
/// for ProductForm.xaml
/// </summary>
public partial class ProductForm : UserControl
{
	/// <summary>
	/// Validates the product data checks 
	/// for required fields and constraints
	/// </summary>
	private void OnValidate()
	{
		if (NameField.Text.IsNull())
			throw new PropertyRequiredException("O nome do produto é obrigatório!");

		if (PriceField.Text.IsNull())
			throw new PropertyRequiredException("O preço do produto é obrigatório!");

		if (QuantityField.Text.IsNull())
			throw new PropertyRequiredException("A quantidade do produto é obrigatório!");

		if (Convert.ToDecimal(PriceField.Text).IsNegative())
			throw new PropertyConstraintException("O preço não pode ser negativo!");

		if (Convert.ToInt16(QuantityField.Text).IsNegative())
			throw new PropertyConstraintException("A quantidade não pode ser negativa!");
	}
}