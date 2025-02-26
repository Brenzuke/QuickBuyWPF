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
	/// for managing products.
	/// </summary>
	private readonly ProductService _service = new();

	/// <summary>
	/// Responsible for generating 
	/// and saving Excel files.
	/// </summary>
	private readonly ExcelExportService _excelService = new();

	/// <summary>
	/// List of prepositions that 
	/// should remain lowercase.
	/// </summary>
	private readonly string[] _prepositions =
	[
		"de", "da", "do", "das", "dos",
		"e", "em", "a", "o",
		"as", "os"
	];

	/// <summary>
	/// Default Constructor.
	/// </summary>
	public MainWindow() =>
		InitializeComponent();
}