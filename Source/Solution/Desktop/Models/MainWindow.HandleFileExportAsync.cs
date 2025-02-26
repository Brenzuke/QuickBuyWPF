namespace Desktop.Models;

using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows;

/// <summary>
/// Interaction logic 
/// for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Handles the save file dialog 
	/// and exports data to the 
	/// specified file path.
	/// </summary>
	private async Task HandleFileExportAsync(SaveFileDialog saveFileDialog)
	{
		if (saveFileDialog.ShowDialog() == true)
		{
			string filePath = saveFileDialog.FileName;
			await _excelService.ExportAsync([.. _service.GetAll()], filePath);
			NotificationOk($"Arquivo salvo em: {filePath}", "Exportação Concluída");
		}
	}
}