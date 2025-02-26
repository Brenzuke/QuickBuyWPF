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
	private static void NotificationOk(string message, string caption) =>
		MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Information);
}