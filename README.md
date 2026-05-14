# 🧠 DocuMind AI

DocuMind AI is an AI-powered Document Q&A and Summarization platform built using RAG (Retrieval-Augmented Generation), Ollama, and .NET 8 Web API.

The system allows users to upload PDF documents, ask contextual questions, retrieve semantic answers, and generate summaries using locally running Large Language Models (LLMs).

---

# 🚀 Features

- 📄 Upload PDF documents
- 🔍 Extract text from PDFs
- 🧠 AI-powered question answering
- 📚 RAG-based semantic retrieval
- ✨ Document summarization
- ⚡ Local LLM inference using Ollama
- 🔎 Embedding-based semantic search
- 🏗️ Built with .NET 8 Web API

---

# 🧠 Tech Stack

| Technology | Usage |
|---|---|
| .NET 8 Web API | Backend API |
| Ollama | Local AI runtime |
| Mistral | Text generation model |
| nomic-embed-text | Embedding model |
| OllamaSharp | Ollama .NET client |
| PdfPig | PDF text extraction |
| Swagger | API testing |

---

# 🏗️ Architecture

```text
User
  ↓
.NET Web API
  ↓
PDF Upload
  ↓
Text Extraction
  ↓
Chunking
  ↓
Embeddings Generation
  ↓
Vector Similarity Search
  ↓
Relevant Context Retrieval
  ↓
Mistral LLM
  ↓
Final AI Response
```

---

# 📂 Project Structure

```text
DocuMindAI/
│
├── Controllers/
│   ├── ChatController.cs
│   ├── DocumentController.cs
│
├── Services/
│   ├── OllamaService.cs
│   ├── ChatService.cs
│   ├── DocumentService.cs
│
├── Models/
│   ├── ChatRequest.cs
│   ├── DocumentModel.cs
│   ├── DocumentChunk.cs
│
├── Data/
│   ├── InMemoryStore.cs
│
├── Program.cs
│
└── README.md
```

---

# ⚙️ Prerequisites

Before running the project, install:

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [Ollama](https://ollama.com)

---

# 🤖 Install Required AI Models

Run the following commands:

```bash
ollama pull mistral
ollama pull nomic-embed-text
```

---

# 📦 Install Dependencies

```bash
dotnet add package OllamaSharp
dotnet add package UglyToad.PdfPig
dotnet add package Swashbuckle.AspNetCore
```

---

# ▶️ Run the Project

```bash
dotnet run
```

Swagger UI:

```text
https://localhost:xxxx/swagger
```

---

# 📡 API Endpoints

## 💬 Ask Questions

```http
POST /api/chat/ask
```

### Request

```json
{
  "question": "Explain dependency injection"
}
```

---

## 📄 Upload PDF

```http
POST /api/document/upload
```

Upload a PDF file using form-data.

---

# 🧠 Future Enhancements

- Vector database integration
- Persistent storage
- Multi-document search
- Streaming AI responses
- Authentication & authorization
- Frontend UI
- Conversation memory
- Hybrid search

---

# 🎯 Learning Goals

This project demonstrates:

- RAG architecture
- Embeddings & semantic search
- Local LLM integration
- AI-powered document intelligence
- .NET AI backend development

---

# 📜 License

This project is licensed under the MIT License.

---

# 👨‍💻 Author

Developed by Vishnu Bhandarge.
