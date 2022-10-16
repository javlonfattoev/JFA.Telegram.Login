using Telegram.Bot.Extensions.LoginWidget;

namespace JFA.Telegram.Login;

public interface ITelegramUser
{
    public bool Validate(TelegramUser user, out Authorization result, string? botToken = null);
}