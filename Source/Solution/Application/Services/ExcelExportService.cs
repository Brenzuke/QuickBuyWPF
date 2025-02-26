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
		worksheet.Cell(1, 5).Value = "Total";
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
			worksheet.Cell(row, 4).Value = product.CreatedAtFormatted;
			worksheet.Cell(row, 5).Value = product.Total;
			row++;
		}
	}

	/// <summary>
	/// Applies complete style to the header.
	/// </summary>
	private static void ApplyHeaderStyle(IXLWorksheet worksheet)
	{
		IXLRange headerRange = worksheet.RangeUsed();
		headerRange.Style.Font.SetBold(true);
		headerRange.Style.Font.SetFontSize(12);
		headerRange.Style.Font.SetFontColor(XLColor.White);
		headerRange.Style.Border.SetTopBorder(XLBorderStyleValues.Thin);
		headerRange.Style.Border.SetLeftBorder(XLBorderStyleValues.Thin);
		headerRange.Style.Border.SetRightBorder(XLBorderStyleValues.Thin);
		headerRange.Style.Border.SetBottomBorder(XLBorderStyleValues.Thin);
		headerRange.Style.Fill.SetBackgroundColor(XLColor.FromArgb(0, 32, 96));
		headerRange.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
		headerRange.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
	}

	/// <summary>
	/// Applies formatting to rows and columns.
	/// </summary>
	private static void ApplyHeaderFormatting(IXLWorksheet worksheet)
	{
		foreach (IXLRow row in worksheet.RowsUsed()) row.Height = 34.00;
		foreach (IXLColumn column in worksheet.ColumnsUsed()) column.Width = 34.00;
	}

	/// <summary>
	/// Creates and configures the workbook setup.
	/// </summary>
	private static XLWorkbook CreateWorkbook(ISet<Product> products)
	{
		XLWorkbook workbook = new();
		IXLWorksheet worksheet = workbook.Worksheets.Add("Produtos");
		AddHeaders(worksheet);
		AddFillData(worksheet, products);
		ApplyHeaderStyle(worksheet);
		ApplyHeaderFormatting(worksheet);
		return workbook;
	}

	/// <summary>
	/// Saves the workbook to the specified path.
	/// </summary>
	private static void SaveWorkbook(XLWorkbook workbook, string filePath) =>
		workbook.SaveAs(filePath);
}