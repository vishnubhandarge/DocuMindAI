using DocuMindAI.Models;
using DocuMindAI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DocuMindAI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly ChatService _chatService;

        public ChatController(ChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpPost("ask")]
        public async Task<IActionResult> Ask(ChatRequest request)
        {
            var answer = await _chatService.AskAsync(request.Question);

            return Ok(new
            {
                answer
            });
        }
    }
}
