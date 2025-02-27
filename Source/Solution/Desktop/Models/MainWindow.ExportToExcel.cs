namespace Desktop.Models;

using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Exports data to an Excel 
	/// file when triggered by 
	/// the UI event.
	/// </summary>
	private async void ExportToExcel(object sender, RoutedEventArgs e)
	{
		if (ProductList.Items.Count != 0) await HandleFileExportAsync(CreateSaveFileDialog());
		else NotificationWarning("Não há dados para exportar!", "Erro ao importar", MessageBoxButton.OK);
	}
}