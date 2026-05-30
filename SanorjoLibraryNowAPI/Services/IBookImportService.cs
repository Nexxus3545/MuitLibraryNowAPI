using SanorjoLibraryNowAPI.Models;

namespace SanorjoLibraryNowAPI.Services
{
    public interface IBookImportService
    {
        BookImportSummary Import(string? filePath = null);
    }
}
