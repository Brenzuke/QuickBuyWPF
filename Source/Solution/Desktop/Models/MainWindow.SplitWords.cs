namespace Desktop.Models;

using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Splits a string into 
	/// words in lowercase.
	/// </summary>
	private static string[] SplitWords(string input) =>
		input.ToLower().Split(' ');
}