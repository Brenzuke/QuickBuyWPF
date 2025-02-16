namespace Desktop.Views;

using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Performs the necessary validation and
	/// processing steps to add a product 
	/// to the shopping cart
	/// </summary>
	private void AddProductToCart()
	{
		ValidateFields();
		CreateProduct();
		ClearFields();
		UpdateTotal();
		UpdateCartDisplay();
	}
}