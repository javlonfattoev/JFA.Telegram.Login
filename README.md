# JFA.Telegram.Login
Service for Telegram login widget

# Steps
>0. Install package
```PM
NuGet\Install-Package JFA.Database.Sqlite -Version <VERSION>
```
#
>1. Add bot token to __appsettings.json__
```JSON
"TelegramOption": {
    "LoginWidgetBotToken": "<BOT_TOKEN>"
  }
```
#
>2. Add telegram auth services
```C#
builder.Services.AddScoped<ITelegramUser, TelegramUserValidator>();
builder.Services.Configure<TelegramOption>(builder.Configuration.GetSection(nameof(TelegramOption)));
```
#
>3. Add controller action
```C#
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
```
#
>4. Widget configuration
- Create a bot or use an existing one from @BotFather
- Link your website's domain to the bot
- Generate embed code. https://core.telegram.org/widgets/login
