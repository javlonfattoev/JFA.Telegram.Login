using Authorization = Telegram.Bot.Extensions.LoginWidget.Authorization;
using LoginWidget = Telegram.Bot.Extensions.LoginWidget.LoginWidget;

namespace JFA.Telegram.Login;

public class TelegramUserValidator : ITelegramUser
{
    public string? BotToken { private get; set; }

    public void SetBotToken(string botToken) => BotToken = botToken;

    public bool Validate(TelegramUser user, out Authorization result, string? botToken = null)
    {
        result = new LoginWidget(botToken ?? BotToken).CheckAuthorization(user.GetFields());
        return result == Authorization.Valid;
    }
}