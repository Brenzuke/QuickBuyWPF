namespace Desktop.Views;

using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Inclui campos ou coisas necessário que deve ser initializada no construtor
	/// </summary>
	public void InitializeConstructor()
	{
		_service = new();
		_validator = new();
		StoreTypeCombo.SelectedIndex = 1;
	}
}