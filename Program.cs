using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using WhatsAppBot.Models;

class Program
{
    static void Main(string[] args)
    {
        // Find your Account SID and Auth Token at twilio.cosm/console
        // and set the environment variables. See http://twil.io/secure

        // var test = new AuthenticateModel()
        // {
        //     TwilioAccountSID = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID"),
        //     TwilioAuthToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN")
        // };

        string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
        string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");

        TwilioClient.Init("ACa38908aeb81739ea6babd3fb0fa28a58", "9e78fa59e26288cdbe4ab6b4bbdd7a5e");

        var message = MessageResource.Create(
            body: "Hello there test fad!",
            from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"),
            to: new Twilio.Types.PhoneNumber("whatsapp:+6593395840")
        );

        Console.WriteLine(message.Sid);
    }
}