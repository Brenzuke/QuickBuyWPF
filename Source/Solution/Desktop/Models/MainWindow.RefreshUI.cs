namespace Desktop.Models;

using System.Linq;
using System.Windows;

/// <summary>
/// Interaction logic 
/// for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Refreshes the UI to reflect 
	/// updated product list, clear 
	/// fields and total price
	/// </summary>
	private void RefreshUI()
	{
		ProductList.ItemsSource = _service.GetAll().ToHashSet();
		UpdateTotal(_service.GetAll());
		ClearFields();
	}
}