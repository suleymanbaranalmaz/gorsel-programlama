namespace ATOTIFY.Modeller
{
    public class Translation
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string ResourceKey { get; set; } // e.g., "BtnPlay"
        public string TranslatedText { get; set; } // e.g., "Oynat"

        public Language Language { get; set; }
    }
}
