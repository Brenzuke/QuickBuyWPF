﻿namespace Desktop.Models;

using System;
using System.Globalization;
using System.Linq;
using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Capitalizes words except 
	/// non-initial prepositions.
	/// </summary>
	private string CapitalizeWord(string word, int index) =>
		_prepositions.Contains(word) && index > 0 ? word
			: CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word);
}