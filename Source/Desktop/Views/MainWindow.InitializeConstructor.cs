namespace Desktop.Views;

using Application.Services;
using Application.Validations;
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
		InitializeComponent();
		StoreTypeCombo.SelectedIndex = 1;
		_service = new ProductService();
		_validator = new ProductValidator();
	}
}