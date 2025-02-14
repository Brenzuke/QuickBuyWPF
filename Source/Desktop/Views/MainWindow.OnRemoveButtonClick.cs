namespace UI;

using Domain.Entities;
using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Dispara o evento de remoção
	/// </summary>
	private void OnRemoveButtonClick(object sender, RoutedEventArgs e)
	{
		if (CartListBox.SelectedItem is Product selectedProduct)
		{
			_service.DeleteByName(selectedProduct.Name);
			UpdateCartDisplay();
		}
	}
}