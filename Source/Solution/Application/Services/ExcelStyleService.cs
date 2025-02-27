namespace Application.Services;

using Application.Interfaces;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Service responsible for Excel styling.
/// </summary>
public sealed class ExcelStyleService(IXLWorksheet worksheet) : IExportStyleService
{
	/// <summary>
	/// Applies header and data styles to worksheet.
	/// </summary>
	public void ApplyStyle()
	{
		ApplyHeaderRowStyle(worksheet);
		ApplyDataRowStyle(worksheet);
		ApplyHeaderFormatting(worksheet);
	}

	/// <summary>
	/// Applies style to the header row only.
	/// </summary>
	private static void ApplyHeaderRowStyle(IXLWorksheet worksheet)
	{
		foreach (IXLCell cell in GetRangeA1ToF1Cells(worksheet)) ApplyCellStyle
		(
			cell,
			cell => cell.Style.Font.SetBold(true),
			cell => cell.Style.Font.SetFontSize(12),
			cell => cell.Style.Font.SetFontColor(XLColor.White),
			cell => cell.Style.Fill.SetBackgroundColor(XLColor.FromArgb(0, 32, 96))
		);
	}

	/// <summary>
	/// Applies style to all data rows except header.
	/// </summary>
	private static void ApplyDataRowStyle(IXLWorksheet worksheet)
	{
		for (int row = 2; row <= GetLastUsedRow(worksheet); row++)
		{
			IXLRow sheetRow = worksheet.Row(row);
			for (int column = 1; column <= 6; column++)
			{
				IXLCell cell = sheetRow.Cell(column);
				FormatAndStyleCell(cell);
				ApplyCurrencyFormat(cell, column);
				ApplyHighlightStyle(cell, row, column);
			}
		}
	}

	/// <summary>
	/// Applies default and custom styles to a cell.
	/// </summary>
	private static void ApplyCellStyle(IXLCell cell, params Action<IXLCell>[] styleAction)
	{
		ApplyDefaultStyle(cell);
		foreach (Action<IXLCell> style in styleAction) style(cell);
	}

	/// <summary>
	/// Applies default borders and alignment styles.
	/// </summary>
	private static void ApplyDefaultStyle(IXLCell cell)
	{
		cell.Style.Border.SetTopBorder(XLBorderStyleValues.Thin);
		cell.Style.Border.SetLeftBorder(XLBorderStyleValues.Thin);
		cell.Style.Border.SetRightBorder(XLBorderStyleValues.Thin);
		cell.Style.Border.SetBottomBorder(XLBorderStyleValues.Thin);
		cell.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
		cell.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
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
	/// Applies a special highlight style to a specific cell.
	/// </summary>
	private static void ApplyHighlightStyle(IXLCell cell, int row, int column)
	{
		if (row is not 2 && column is 6) ApplyCellStyle
		(
			cell,
			cell => cell.Style.Border.SetTopBorder(XLBorderStyleValues.None),
			cell => cell.Style.Border.SetLeftBorder(XLBorderStyleValues.None),
			cell => cell.Style.Border.SetRightBorder(XLBorderStyleValues.None),
			cell => cell.Style.Border.SetBottomBorder(XLBorderStyleValues.None)
		);
	}

	/// <summary>
	/// Applies currency format to specific columns.
	/// </summary>
	private static void ApplyCurrencyFormat(IXLCell cell, int column)
	{
		if (IsCurrencyColumn(column)) ApplyCellStyle
		(
			cell,
			cell => cell.Style.NumberFormat.SetFormat("R$ #,##0.00"),
			cell => cell.Style.Font.SetFontColor(XLColor.FromArgb(255, 0, 0, 255))
		);
	}

	/// <summary>
	/// Applies formatting and styling to a specific cell.
	/// </summary>
	private static void FormatAndStyleCell(IXLCell cell) =>
		ApplyCellStyle
		(
			cell,
			cell => cell.Style.Font.SetFontSize(10),
			cell => cell.Style.Font.SetFontColor(XLColor.Black)
		);

	/// <summary>
	/// Gets the last used row number.
	/// </summary>
	private static int GetLastUsedRow(IXLWorksheet worksheet) =>
		worksheet
			.RowsUsed()
			.Last()
			.RowNumber();

	/// <summary>
	/// Checks if the column requires currency format.
	/// </summary>
	private static bool IsCurrencyColumn(int column) =>
		column is 2 or 5 or 6;

	/// <summary>
	/// Gets the range of cells from A1 to F1.
	/// </summary>
	private static IEnumerable<IXLCell> GetRangeA1ToF1Cells(IXLWorksheet worksheet) =>
		worksheet
			.Range("A1:F1")
			.Cells()
			.Cast<IXLCell>();
}