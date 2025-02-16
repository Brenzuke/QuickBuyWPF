namespace Desktop.Views;

using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Displays a notification to the user 
	/// interface when a validation error occurs
	/// </summary>
	private static void Notification(string message) =>
		MessageBox.Show(message, "Erro de validação", MessageBoxButton.OK, MessageBoxImage.Warning);
}