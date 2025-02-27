namespace Desktop.Models;

using System;
using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Displays a error 
	/// message to the user
	/// </summary>
	private static void NotificationError(Exception ex) =>
		MessageBox.Show(ex.Message, "Erro de validação", MessageBoxButton.OK, MessageBoxImage.Error);
}