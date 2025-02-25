namespace Desktop.Models;

using Application.Services;
using System.Windows;

/// <summary>
/// Interaction logic 
/// for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Provides operations 
	/// for managing products
	/// </summary>
	private ProductService _service = new();

	/// <summary>
	/// Default Constructor
	/// </summary>
	public MainWindow() =>
		InitializeComponent();
}