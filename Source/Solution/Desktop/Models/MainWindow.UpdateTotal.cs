namespace Desktop.Models;

using Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Updates the total price 
	/// displayed in the UI
	/// </summary>
	private void UpdateTotal(ISet<Product> products)
	{
		decimal total = products.Sum(product => product.SubTotal);
		TotalPriceField.Inlines.Clear();
		TotalPriceField.Inlines.Add(new Run("Total: ") { Foreground = Brushes.Black });
		TotalPriceField.Inlines.Add(new Run($"R$ {total:F2}") { Foreground = Brushes.Blue });
	}
}