using StardewModdingAPI.Utilities;

namespace LanguageStudyStardewValleyMod
{
    public sealed class ModConfig
    {
        public bool TranslationEnabled { get; set; } = true;

        // unbound by default; players bind them in GMCM or config.json. Avoid function keys as
        // defaults: on macOS they need Fn.
        public KeybindList ToggleTranslation { get; set; } = new();

        /// <summary>Locks the tooltip under the cursor on/off so individual words in it can be hovered.</summary>
        public KeybindList FreezeTooltip { get; set; } = new();

        /// <summary>Pins the tooltip under the cursor only for as long as this is held down.</summary>
        /// <remarks>Left-hand, since the right hand is on the mouse; Left Shift is vanilla's Run.</remarks>
        public KeybindList HoldFreezeTooltip { get; set; } = KeybindList.Parse("LeftAlt");

        /// <summary>
        /// Whether left-clicking a hovered word saves it as a flashcard. The click is
        /// swallowed when it lands on a word, so the game underneath never sees it.
        /// </summary>
        public bool ClickToSaveWords { get; set; } = true;

        /// <summary>The order the flashcards tab reviews cards in; changed from the tab itself.</summary>
        public CardOrder FlashcardOrder { get; set; } = CardOrder.NewestFirst;

        /// <summary>The language to translate into, as a locale code (e.g. "en"). Not yet exposed in the config UI.</summary>
        public string TargetLanguage { get; set; } = "en";
    }
}
