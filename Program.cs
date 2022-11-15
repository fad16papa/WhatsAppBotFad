using System;
using Microsoft.Extensions.Configuration;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


class Program
{
    static void Main(string[] args)
    {
        // Find your Account SID and Auth Token at twilio.com/console
        // and set the environment variables. See http://twil.io/secure
        // string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
        // string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");

        string accountSid = "ACa38908aeb81739ea6babd3fb0fa28a58";
        string authToken = "6bf2957e120eacd0fad4666e140e906c";

        TwilioClient.Init(accountSid, authToken);

        var message = MessageResource.Create(
            body: "Hello there mic test 123!",
            from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"),
            to: new Twilio.Types.PhoneNumber("whatsapp:+6593395840")
        );

        Console.WriteLine(message.Sid);
    }
}