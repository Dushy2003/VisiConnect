using Microsoft.AspNetCore.Identity.UI.Services;

namespace VisiConnect.Implementations
{
    public class EmailService : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //throw new NotImplementedException();
            
        }
    }
}
