namespace Desktop.Models;

using System.Linq;
using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Updates UI with product list,
	/// clears fields and resets 
	/// total price.
	/// </summary>
	private void RefreshUI()
	{
		ProductList.ItemsSource = _service.GetAll().ToHashSet();
		UpdateTotal(_service.GetAll().ToHashSet());
		ClearFields();
	}
}