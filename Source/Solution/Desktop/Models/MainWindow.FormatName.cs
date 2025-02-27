namespace Desktop.Models;

using System.Linq;
using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Formats input text to 
	/// capitalize words, 
	/// except prepositions.
	/// </summary>
	private string FormatName(string[] words) =>
		string.Join(" ", words.Select(CapitalizeWord));
}