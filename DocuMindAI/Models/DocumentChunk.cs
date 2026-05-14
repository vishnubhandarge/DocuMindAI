namespace DocuMindAI.Models
{
    public class DocumentChunk
    {
        public Guid Id { get; set; }
        public Guid DocumentId { get; set; }
        public string ChunkText { get; set; } = string.Empty;
        public float[] Embedding { get; set; } = [];
    }
}
