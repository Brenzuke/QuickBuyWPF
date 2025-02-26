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
	private static MessageBoxResult NotificationWarning(string message, string caption, MessageBoxButton button) =>
		MessageBox.Show(message, caption, button, MessageBoxImage.Warning);
}