namespace Desktop.Models;

using Microsoft.Win32;
using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Configures a save file 
	/// dialog for exporting 
	/// Excel files.
	/// </summary>
	private static SaveFileDialog CreateSaveFileDialog() =>
		new()
		{
			Filter = "Excel Files (*.xlsx)|*.xlsx",
			Title = "Salvar arquivo Excel",
			FileName = "QuickBuy.xlsx"
		};
}