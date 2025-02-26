namespace Application.Services;

using Application.Interfaces;
using ClosedXML.Excel;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Service for exporting product data to Excel.
/// </summary>
public sealed class ExcelExportService : IExportService<Product>
{
	/// <summary>
	/// Exports the product list to an Excel file.
	/// </summary>
	public async Task ExportAsync(ISet<Product> products, string filePath) =>
		await Task.Run(() =>
		{
			using XLWorkbook workbook = CreateWorkbook(products);
			IXLWorksheet worksheet = workbook.Worksheets.First();
			SaveWorkbook(workbook, filePath);
		});

	/// <summary>
	/// Adds headers to the Excel worksheet.
	/// </summary>
	private static void AddHeaders(IXLWorksheet worksheet)
	{
		worksheet.Cell(1, 1).Value = "Nome";
		worksheet.Cell(1, 2).Value = "Preço";
		worksheet.Cell(1, 3).Value = "Quantidade";
		worksheet.Cell(1, 4).Value = "Criado em";
		worksheet.Cell(1, 5).Value = "Subtotal";
		worksheet.Cell(1, 6).Value = "Total";
	}

	/// <summary>
	/// Adds Fills to the Excel worksheet.
	/// </summary>
	private static void AddFillData(IXLWorksheet worksheet, IEnumerable<Product> products)
	{
		int row = 2;
		foreach (Product product in products)
		{
			worksheet.Cell(row, 1).Value = product.Name;
			worksheet.Cell(row, 2).Value = product.Price;
			worksheet.Cell(row, 3).Value = product.Quantity;
			worksheet.Cell(row, 4).Value = product.CreatedAt;
			worksheet.Cell(row, 5).Value = product.SubTotal;
			row++;
		}
		worksheet.Cell(2, 6).Value = products
			.Sum(product => product.SubTotal);
	}

	/// <summary>
	/// Creates and configures the workbook setup.
	/// </summary>
	private static XLWorkbook CreateWorkbook(ISet<Product> products)
	{
		XLWorkbook workbook = new();
		IXLWorksheet worksheet = workbook.Worksheets.Add("Produtos");
		PrepareWorksheet(worksheet, products);
		return workbook;
	}

	/// <summary>
	/// Prepares worksheet with headers, style, and data.
	/// </summary>
	private static void PrepareWorksheet(IXLWorksheet worksheet, ISet<Product> products)
	{
		ExcelStyleService _style = new(worksheet);
		AddHeaders(worksheet);
		AddFillData(worksheet, products);
		_style.ApplyStyle();
	}

	/// <summary>
	/// Saves the workbook to the specified path.
	/// </summary>
	private static void SaveWorkbook(XLWorkbook workbook, string filePath) =>
		workbook.SaveAs(filePath);
}