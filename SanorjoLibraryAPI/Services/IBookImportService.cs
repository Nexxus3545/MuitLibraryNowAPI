using SanorjoLibraryAPI.Models;

namespace SanorjoLibraryAPI.Services
{
    public interface IBookImportService
    {
        BookImportSummary Import(string? filePath = null);
    }
}
