namespace Desktop.Models;

using Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

/// <summary>
/// Interaction logic 
/// for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Updates the total price 
	/// displayed in the UI
	/// </summary>
	private void UpdateTotal(ICollection<Product> products)
	{
		decimal total = products.Sum(product => product.Total);
		TotalPriceField.Text = $"Custo Total: R$ {total:F2}";
	}
}