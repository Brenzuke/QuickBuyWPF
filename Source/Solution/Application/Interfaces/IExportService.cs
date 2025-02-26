namespace Application.Interfaces;

using System.Collections.Generic;
using System.Threading.Tasks;

/// <summary>
/// Defines a contract for exporting
/// data to different formats.
/// </summary>
public interface IExportService<T>
{
	/// <summary>
	/// Exports a list of data.
	/// </summary>
	Task ExportAsync(IList<T> data, string filePath);
}