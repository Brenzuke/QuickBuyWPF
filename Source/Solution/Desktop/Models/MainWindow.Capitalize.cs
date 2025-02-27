namespace Desktop.Models;

using Application.Extensives;
using System.Windows;
using System.Windows.Controls;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Capitalizes words 
	/// except prepositions.
	/// </summary>
	private void Capitalize(object sender, TextChangedEventArgs e)
	{
		if (NameField.Text.IsNull()) return;
		NameField.TextChanged -= Capitalize;
		NameField.Text = FormatName(SplitWords(NameField.Text));
		NameField.CaretIndex = NameField.Text.Length;
		NameField.TextChanged += Capitalize;
	}
}