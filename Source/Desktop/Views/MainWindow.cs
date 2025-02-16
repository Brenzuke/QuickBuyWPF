namespace Desktop.Views;

using Application.Services;
using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Base service for managing 
	/// product-related operations
	/// </summary>
	private ProductService _service;

	/// <summary>
	/// Default constructor
	/// </summary>
	public MainWindow()
	{
		InitializeComponent();
		InitializeConstructor();
	}
}