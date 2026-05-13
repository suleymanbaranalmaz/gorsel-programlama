using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATOTIFY.Veritabani;
using Microsoft.EntityFrameworkCore;

namespace ATOTIFY.Servisler
{
    public class LocalizationService
    {
        private readonly AppDbContext _context;
        private int _currentLanguageId;
        private Dictionary<string, string> _translations;

        public LocalizationService(AppDbContext context, int defaultLanguageId = 1)
        {
            _context = context;
            _currentLanguageId = defaultLanguageId;
            LoadTranslations();
        }

        public void SetLanguage(int languageId)
        {
            _currentLanguageId = languageId;
            LoadTranslations();
        }

        private void LoadTranslations()
        {
            _translations = _context.Translations
                .Where(t => t.LanguageId == _currentLanguageId)
                .ToDictionary(t => t.ResourceKey, t => t.TranslatedText);
        }

        public string GetString(string key)
        {
            if (_translations != null && _translations.TryGetValue(key, out var text))
            {
                return text;
            }
            return $"[{key}]"; // Fallback to show missing key
        }

        // Helper to translate controls recursively
        public void TranslateForm(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                // We use the control's Tag property to store the ResourceKey
                if (control.Tag != null && control.Tag is string resourceKey && !string.IsNullOrWhiteSpace(resourceKey))
                {
                    control.Text = GetString(resourceKey);
                }

                if (control.HasChildren)
                {
                    TranslateForm(control);
                }
            }

            // Also translate the Form title if it's a Form and has a Tag
            if (parentControl is Form form && form.Tag != null && form.Tag is string formResourceKey && !string.IsNullOrWhiteSpace(formResourceKey))
            {
                form.Text = GetString(formResourceKey);
            }
        }
    }
}
