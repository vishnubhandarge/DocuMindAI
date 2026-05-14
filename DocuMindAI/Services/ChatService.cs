namespace DocuMindAI.Services
{
    public class ChatService
    {
        private readonly OllamaService _ollama;

        public ChatService(OllamaService ollama)
        {
            _ollama = ollama;
        }

        public async Task<string> AskAsync(string question)
        {
            var prompt = $@"
                You are DocuMind AI.

                Answer clearly and concisely.

                Question:
                {question}
                ";

            return await _ollama.GenerateAsync(prompt);
        }
    }
}
