namespace MyGarden.Models
{
    public class SiteOptions
    {
        public string FrontEndUrl { get; set; } = null!;

        public string[] AdminEmailAdresses { get; set; } = null!;

        public string ContactEmailAddress { get; set; } = null!;
    }
}
