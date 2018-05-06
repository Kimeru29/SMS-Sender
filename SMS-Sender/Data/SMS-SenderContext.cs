using SMS_Sender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_Sender.Data
{
    public class SMS_SenderContext : ApplicationDbContext
    {
        
        public SMS_SenderContext()
            : base("SMS-SenderContext")
        {

        }
    }
}