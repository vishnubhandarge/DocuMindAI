namespace DocuMindAI.Models
{
    public class DocumentModel
    {
        public Guid Id { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
