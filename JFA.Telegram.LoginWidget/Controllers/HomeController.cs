using JFA.Telegram.Login;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace JFA.Telegram.LoginWidget.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    [HttpGet]
    public IActionResult Login([FromQuery] TelegramUser user,
        [FromServices] ITelegramUser telegramUser,
        [FromServices] IOptions<TelegramOption> options)
    {
        if (telegramUser.Validate(user, out _, options.Value.LoginWidgetBotToken))
        {
            return Ok(user);
        }

        return Unauthorized();
    }

}