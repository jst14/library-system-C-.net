using System.Drawing;

namespace LibrarySystem
{
    /// <summary>
    /// Library System Color Scheme
    /// Inspired by warm wooden tones and vintage book colors
    /// </summary>
    public static class ColorScheme
    {
        // Primary Colors - Warm Wood Tones
        public static readonly Color PrimaryDarkWood = Color.FromArgb(58, 45, 32);      // Dark wood (#3A2D20)
        public static readonly Color PrimaryWood = Color.FromArgb(120, 81, 44);         // Medium wood (#785128)
        public static readonly Color AccentGolden = Color.FromArgb(184, 134, 11);       // Golden (#B8860B)

        // Secondary Colors - Vintage Book Tones
        public static readonly Color VintageMaroon = Color.FromArgb(128, 0, 32);        // Vintage red (#800020)
        public static readonly Color VintageGreen = Color.FromArgb(34, 84, 60);         // Library green (#225C3C)
        public static readonly Color VintageOrange = Color.FromArgb(204, 85, 0);        // Book spine orange (#CC5500)

        // Neutral Colors - Page & Background
        public static readonly Color CreamWhite = Color.FromArgb(245, 243, 237);        // Cream (#F5F3ED)
        public static readonly Color LightParchment = Color.FromArgb(250, 248, 245);    // Light parchment (#FAF8F5)
        public static readonly Color DarkText = Color.FromArgb(40, 30, 20);             // Dark text (#281E14)

        // Accent Colors
        public static readonly Color SuccessGreen = Color.FromArgb(76, 153, 76);        // Success (#4C994C)
        public static readonly Color WarningOrange = Color.FromArgb(255, 153, 0);       // Warning (#FF9900)
        public static readonly Color ErrorRed = Color.FromArgb(204, 0, 0);              // Error (#CC0000)
        public static readonly Color InfoBlue = Color.FromArgb(0, 102, 204);            // Info (#0066CC)

        // Border Colors
        public static readonly Color BrandBorder = Color.FromArgb(99, 65, 35);          // Border (#634123)
        public static readonly Color SoftBorder = Color.FromArgb(200, 180, 160);        // Soft border (#C8B4A0)

        // UI Element Colors
        public static readonly Color HoverHighlight = Color.FromArgb(255, 200, 124);    // Hover gold (#FFC87C)
        public static readonly Color DisabledGray = Color.FromArgb(169, 169, 169);      // Disabled (#A9A9A9)
        public static readonly Color SelectionBlue = Color.FromArgb(70, 130, 180);      // Selection (#4682B4)
    }
}
