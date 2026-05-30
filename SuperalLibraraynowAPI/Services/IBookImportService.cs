using SuperalLibraraynowAPI.Models;

namespace SuperalLibraraynowAPI.Services
{
    public interface IBookImportService
    {
        BookImportSummary Import(string? filePath = null);
    }
}
