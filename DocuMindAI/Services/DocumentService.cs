using DocuMindAI.Data;
using DocuMindAI.Models;
using UglyToad.PdfPig;

namespace DocuMindAI.Services
{
    public class DocumentService
    {
        public async Task<DocumentModel> UploadAsync(IFormFile file)
        {
            using var stream = file.OpenReadStream();

            using var pdf = PdfDocument.Open(stream);

            var text = "";

            foreach (var page in pdf.GetPages())
            {
                text += page.Text;
            }

            var document = new DocumentModel
            {
                Id = Guid.NewGuid(),
                FileName = file.FileName,
                Content = text
            };

            InMemoryStore.Documents.Add(document);

            return document;
        }
    }
}
