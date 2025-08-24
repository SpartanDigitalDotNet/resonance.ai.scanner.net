public class EnvironmentConfig
{
    public string DiscordWebhook { get; }
    //public double AbsVolumeMinUsd { get; }

    public EnvironmentConfig()
    {
        DiscordWebhook = Environment.GetEnvironmentVariable("DISCORD_WEBHOOK_URL")
            ?? throw new InvalidOperationException("Missing DISCORD_WEBHOOK env var.");

       
    }
}
