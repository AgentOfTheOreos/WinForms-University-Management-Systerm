using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppTaskFinal.DataModels
{
    public static class ThemeManager
    {
        // Theme settings
        public static bool DarkModeEnabled { get; set; }
        public static string FontFamily { get; set; }
        public static int FontSize { get; set; }
        public static Color FontColor { get; set; }
        public static Color BackgroundColor { get; set; }

        // Apply theme settings to a specific form
        private static void ApplyMode(Form form)
        {
            form.BackColor = DarkModeEnabled ? Color.FromArgb(30, 30, 30) : SystemColors.Control;
            form.ForeColor = DarkModeEnabled ? Color.White : SystemColors.ControlText;
            // Update other controls and elements on the form
        }

        private static void ApplyFontsAndColors(Form form)
        {
            form.Font = new Font(FontFamily, FontSize);
            form.ForeColor = FontColor;
            form.BackColor = BackgroundColor;
        }

        // Apply theme settings to all open forms
        public static void ApplyThemeToAllForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                ApplyMode(form);
                ApplyFontsAndColors(form);
            }
        }
    }

}