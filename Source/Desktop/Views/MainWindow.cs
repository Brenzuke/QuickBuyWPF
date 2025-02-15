#pragma warning disable IDE0079
#pragma warning disable CA1859
namespace Desktop.Views;

using Domain.Entities;
using Domain.Interfaces;
using System.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Interface base para metodos de gerenciamentos
	/// </summary>
	private IUnitOfWork<Product> _service;

	/// <summary>
	/// Interface base para validações
	/// </summary>
	private IEntityValidator<Product> _validator;

	/// <summary>
	/// Construtor padrão
	/// </summary>
	public MainWindow() =>
		InitializeConstructor();
}