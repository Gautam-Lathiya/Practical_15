using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WindowsAuthentication.Models
{
    public class AuditLog
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string UrlAccessed { get; set; }
        public DateTime AccessTime { get; set; }
    }
}