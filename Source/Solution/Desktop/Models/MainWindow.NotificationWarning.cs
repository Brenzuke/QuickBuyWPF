namespace Desktop.Models;

using System.Windows;

/// <summary>
/// Interaction logic 
/// for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Displays a warning 
	/// message to the user
	/// </summary>
	private void NotificationWarning(string message) =>
		MessageBox.Show(message, "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
}