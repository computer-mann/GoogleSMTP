

using System;
using System.IO;
using System.Net.Mail;
using System.Threading.Tasks;
using Mail.Services.Interfaces;
using Mail.ViewModels;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class MailController : ControllerBase
{
    private readonly IMailService mailService;
    public MailController(IMailService mailService)
    {
        this.mailService = mailService;
    }
    [HttpPost("/send")]
    public async Task<IActionResult> SendMail([FromForm] MailRequest request)
    {
        try
        {
            await mailService.SendEmailAsync(request);
            return Ok();
        }
        catch (Exception)
        {
            throw;
        }

    }

}