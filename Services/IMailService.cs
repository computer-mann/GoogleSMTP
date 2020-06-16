

using System.Threading.Tasks;
using Mail.ViewModels;

namespace Mail.Services.Interfaces
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}