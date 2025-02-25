namespace Desktop.Models;

using System.Windows;

/// <summary>
/// Interaction logic 
/// for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Displays an informational 
	/// message to the user
	/// </summary>
	private void NotificationOk(string message) =>
		MessageBox.Show(message, "Sucesso", MessageBoxButton.OK);
}