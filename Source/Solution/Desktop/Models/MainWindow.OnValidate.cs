namespace Desktop.Models;

using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Validates the product data checks 
	/// for required fields and constraints
	/// </summary>
	private void OnValidate()
	{
		OnValidateRequiredFields();
		OnValidateFormat();
		OnValidateConstraints();
	}
}