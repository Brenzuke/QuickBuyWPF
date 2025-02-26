namespace Application.Services;

using Application.Interfaces;
using ClosedXML.Excel;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Service responsible for exporting 
/// product data to an Excel file.
/// </summary>
public sealed class ExcelExportService : IExportService<Product>
{
	/// <summary>
	/// Exports the product 
	/// list to an Excel file.
	/// </summary>
	public async Task ExportAsync(IList<Product> products, string filePath) =>
		await Task.Run(() =>
		{
			using XLWorkbook workbook = CreateWorkbook();
			IXLWorksheet worksheet = workbook.Worksheets.First();
			FillData(worksheet, products);
			CenterFilledData(worksheet, products);
			SaveWorkbook(workbook, filePath);
		});

	/// <summary>
	/// Adds the headers 
	/// to the Excel worksheet.
	/// </summary>
	private static void AddHeaders(IXLWorksheet worksheet)
	{
		worksheet.Cell(1, 1).Value = "Nome";
		worksheet.Cell(1, 2).Value = "Preço";
		worksheet.Cell(1, 3).Value = "Quantidade";
		worksheet.Cell(1, 4).Value = "Criado em";
		worksheet.Cell(1, 5).Value = "Total";

		FormatWorksheet(worksheet);
		ApplyHeaderFormatting(worksheet);
	}

	/// <summary>
	/// Sets the width for each column 
	/// in the worksheet header.
	/// </summary>
	private static void ApplyHeaderFormatting(IXLWorksheet worksheet)
	{
		const double columnWidth = 34.00;
		for (int column = 1; column <= worksheet.ColumnCount(); column++)
			worksheet.Column(column).Width = columnWidth;
	}

	/// <summary>
	/// Creates and configures 
	/// the workbook with the 
	/// required worksheet.
	/// </summary>
	private static XLWorkbook CreateWorkbook()
	{
		XLWorkbook workbook = new();
		IXLWorksheet worksheet = workbook.Worksheets.Add("Produtos");
		AddHeaders(worksheet);
		return workbook;
	}

	/// <summary>
	/// Centralizes the content
	/// of the filled data range.
	/// </summary>
	private static void CenterFilledData(IXLWorksheet worksheet, IList<Product> products) =>
		worksheet.Range($"A2:E{products.Count + 1}").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

	/// <summary>
	/// Fills the worksheet 
	/// with product data.
	/// </summary>
	private static void FillData(IXLWorksheet worksheet, IList<Product> products)
	{
		for (int index = 0; index < products.Count; index++)
		{
			Product product = products[index];
			worksheet.Cell(index + 2, 1).Value = product.Name;
			worksheet.Cell(index + 2, 2).Value = product.Price;
			worksheet.Cell(index + 2, 3).Value = product.Quantity;
			worksheet.Cell(index + 2, 4).Value = product.CreatedAtFormatted;
			worksheet.Cell(index + 2, 5).Value = product.Total;
			worksheet.Cell(index + 2, 6).Value = products.Sum(product => product.Total);
		}

		worksheet.Cell(products.Count + 2, 1);
		var totalCell = worksheet.Cell(products.Count + 2, 1); // Célula para o texto "Total"
		totalCell.Value = "Custo Total"; // Texto na célula
		totalCell.Style.Font.Bold = true;
	}

	/// <summary>
	/// Applies formatting to the worksheet, 
	/// including centering text 
	/// and making headers bold.
	/// </summary>
	private static void FormatWorksheet(IXLWorksheet worksheet)
	{
		IXLRange headerRange = worksheet.Range("A1:E1");
		headerRange.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
		headerRange.Style.Font.Bold = true;
		worksheet.RangeUsed().Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
	}

	/// <summary>
	/// Saves the workbook 
	/// to the specified file path.
	/// </summary>
	private static void SaveWorkbook(XLWorkbook workbook, string filePath) =>
		workbook.SaveAs(filePath);
}