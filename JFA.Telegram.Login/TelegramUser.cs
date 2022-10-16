namespace JFA.Telegram.Login;

public class TelegramUser
{
    public string? id { get; set; }
    public string? first_name { get; set; }
    public string? last_name { get; set; }
    public string? username { get; set; }
    public string? photo_url { get; set; }
    public string? auth_date { get; set; }
    public string? hash { get; set; }

    public SortedDictionary<string, string?> GetFields()
    {
        return new SortedDictionary<string, string?>
        {
            { nameof(id), id },
            { nameof(first_name), first_name },
            { nameof(last_name), last_name },
            { nameof(username), username },
            { nameof(photo_url), photo_url },
            { nameof(auth_date), auth_date },
            { nameof(hash), hash }
        };
    }
}

