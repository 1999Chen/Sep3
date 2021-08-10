using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Net.Mime;

namespace Sep3Tier3.Models
{
    public class Message
    {
        public string nameSend { set; get; }
        public string nameReceived { set; get; }
        [Key, NotNull] 
        public int id { set; get; }
        public string message { set; get; }
        public string date { set; get; }
        
       
    }
}