namespace Desktop.Models;

using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Handles product deletion by name 
	/// and updates the UI accordingly.
	/// </summary>
	private void HandleProductDeletion(string productName)
	{
		_service.DeleteByName(productName);
		RefreshUI();
	}
}