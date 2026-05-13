using System.Collections.Generic;

namespace ATOTIFY.Modeller
{
    public class Language
    {
        public int Id { get; set; }
        public string Code { get; set; } // e.g., "tr-TR", "en-US"
        public string Name { get; set; } // e.g., "Türkçe", "English"

        public ICollection<Translation> Translations { get; set; }
    }
}
