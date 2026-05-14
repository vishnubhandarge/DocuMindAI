using DocuMindAI.Models;

namespace DocuMindAI.Data
{
    public static class InMemoryStore
    {
        public static List<DocumentModel> Documents { get; set; } = [];
        public static List<DocumentChunk> Chunks { get; set; } = [];
    }
}
