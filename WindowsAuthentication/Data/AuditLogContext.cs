using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WindowsAuthentication.Models;

namespace WindowsAuthentication.Data
{
    public class AuditLogContext : DbContext
    {
        public AuditLogContext() : base("DefaultConnection") { }

        public DbSet<AuditLog> AuditLogs { get; set; }
    }
}