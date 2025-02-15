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
	/// Interface base para metodos de gerenciamentos
	/// </summary>
	private ProductService _service;

	/// <summary>
	/// Interface base para validações
	/// </summary>
	private ProductValidator _validator;

	/// <summary>
	/// Construtor padrão
	/// </summary>
	public MainWindow()
	{
		InitializeComponent();
		InitializeConstructor();
	}
}