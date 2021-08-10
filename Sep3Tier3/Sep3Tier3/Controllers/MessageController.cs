using System;
using Microsoft.AspNetCore.Mvc;

using Sep3Tier3.Data;
using Sep3Tier3.Models;

namespace Sep3Sep3Sep3Tier3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessagesController:ControllerBase
    {
        private readonly IMessageService MessageService;

        public MessagesController(IMessageService MessageService)
        {
            this.MessageService = MessageService;
        }
        // [HttpPost("Messages")]
        // public IActionResult storeMessage([FromBody] Message Message)
        // {
        //     userService.storeMessage(Message);
        //     return Ok();
        // }

        [HttpGet]
        public IActionResult getAllMessages()
        {
            return Ok(MessageService.getAllMessages());
        }

        [HttpGet("GetMessages/{username1};{username2}")]
        public IActionResult getMessages(string username1, string username2)
        {
            Console.WriteLine("Sep3Sep3Tier3 get msg controller");
            return Ok(MessageService.GetMessages(username1, username2));
        }

        [HttpPost("SendMessage")]
        public IActionResult sendMessage([FromBody]Message Message)
        {
            Console.WriteLine("Sep3Sep3Tier3 controller send msg");
         
            return Ok(MessageService.sendMessage(Message));


        }
        
        
        
    }
}