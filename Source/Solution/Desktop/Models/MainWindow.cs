namespace Desktop.Models;

using Application.Services;
using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Manages product-related operations.
	/// </summary>
	private readonly ProductService _service = new();

	/// <summary>
	/// Generates and saves Excel files.
	/// </summary>
	private readonly ExcelExportService _excelService = new();

	/// <summary>
	/// List of prepositions to remain lowercase.
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