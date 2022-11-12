using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhatsAppBot.Models
{
    public class AuthenticateModel
    {
        public string TwilioAccountSID { get; set; }
        public string TwilioAuthToken { get; set; }

        AuthenticateModel()
        {
            TwilioAccountSID = "";
            TwilioAuthToken = "";
        }
    }
}