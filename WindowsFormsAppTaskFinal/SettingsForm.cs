using System;
using System.Configuration;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTaskFinal
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private async void SettingsForm_Load_1(object sender, EventArgs e)
        {
            await LoadSettingsAsync();
        }

        private async Task LoadSettingsAsync()
        {
            await Task.Run(() =>
            {
                // Load the current settings and display them in the form

                // Dark Mode
                var darkModeSetting = GetDarkModeSetting();
                SetDarkModeSetting(darkModeSetting);

                // App Background Color
                var backgroundColor = DataModels.ThemeManager.BackgroundColor;
                SetBackgroundColor(backgroundColor);

                // Font Family
                var fontFamily = DataModels.ThemeManager.FontFamily;
                SetFontFamily(fontFamily);

                // Font Size
                var fontSize = DataModels.ThemeManager.FontSize;
                SetFontSize(fontSize);

                // Font Color
                var fontColor = DataModels.ThemeManager.FontColor;
                SetFontColor(fontColor);
            });
        }

        private bool GetDarkModeSetting()
        {
            var darkModeEnabled = false; // Default value if the setting is not found or cannot be parsed

            try
            {
                // Read the configuration value from your configuration file
                var darkModeSetting = ConfigurationManager.AppSettings["DarkModeEnabled"];

                // Parse the value to a boolean
                darkModeEnabled = bool.Parse(darkModeSetting);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during reading or parsing the value
                // You can log the error, display a message to the user, or use a default value
                // For this example, we simply print the exception message
                Console.WriteLine(@"Error reading Dark Mode setting: " + ex.Message);
            }

            return darkModeEnabled;
        }

        private async void saveButton_Click_1(object sender, EventArgs e)
        {
            await SaveSettingsAsync();
        }

        private async Task SaveSettingsAsync()
        {
            await Task.Run(() =>
            {
                // Save the settings when the user clicks the Save button

                // Background Color
                var selectedBackgroundColorName = backgroundColorComboBox.SelectedItem.ToString();
                var selectedBackgroundColor = Color.FromName(selectedBackgroundColorName);
                SaveBackgroundColorSetting(selectedBackgroundColor);

                // Font Family
                var selectedFontFamily = fontComboBox.SelectedItem.ToString();
                SaveFontFamilySetting(selectedFontFamily);

                // Font Size
                var selectedFontSize = int.Parse(fontSizeComboBox.SelectedItem.ToString());
                SaveFontSizeSetting(selectedFontSize);

                // Font Color
                var selectedFontColorName = fontColorComboBox.SelectedItem.ToString();
                var selectedFontColor = Color.FromName(selectedFontColorName);
                SaveFontColorSetting(selectedFontColor);

                // Dark Mode
                var darkModeEnabled = darkModeCheckBox.Checked;
                SaveDarkModeSetting(darkModeEnabled);

                // Apply the theme settings to all open forms
                DataModels.ThemeManager.ApplyThemeToAllForms();
            });

            // Close the settings form
            Hide();
        }

        private void SaveDarkModeSetting(bool darkModeEnabled)
        {
            // Save the dark mode setting to your application's configuration or storage
            ConfigurationManager.AppSettings["DarkModeEnabled"] = darkModeEnabled.ToString();
        }

        private void SaveFontFamilySetting(string selectedFontFamily)
        {
            // Save the font family setting to your application's configuration or storage
            DataModels.ThemeManager.FontFamily = selectedFontFamily;
        }

        private void SaveFontSizeSetting(int selectedFontSize)
        {
            // Save the font size setting to your application's configuration or storage
            DataModels.ThemeManager.FontSize = selectedFontSize;
        }

        private void SaveFontColorSetting(Color selectedFontColor)
        {
            // Save the font color setting to your application's configuration or storage
            DataModels.ThemeManager.FontColor = selectedFontColor;
        }

        private void SaveBackgroundColorSetting(Color selectedBackgroundColor)
        {
            // Save the background color setting to your application's configuration or storage
            DataModels.ThemeManager.BackgroundColor = selectedBackgroundColor;
        }

        private void SetDarkModeSetting(bool darkModeEnabled)
        {
            // Set the Dark Mode checkbox value on the form
            if (darkModeCheckBox.InvokeRequired)
            {
                darkModeCheckBox.Invoke(new Action(() => darkModeCheckBox.Checked = darkModeEnabled));
            }
            else
            {
                darkModeCheckBox.Checked = darkModeEnabled;
            }
        }

        private void SetBackgroundColor(Color backgroundColor)
        {
            // Set the selected background color on the form's combo box
            if (backgroundColorComboBox.InvokeRequired)
            {
                backgroundColorComboBox.Invoke(new Action(() =>
                {
                    backgroundColorComboBox.SelectedItem = backgroundColor.Name;
                }));
            }
            else
            {
                backgroundColorComboBox.SelectedItem = backgroundColor.Name;
            }
        }

        private void SetFontFamily(string fontFamily)
        {
            // Set the selected font family on the form's combo box
            if (fontComboBox.InvokeRequired)
            {
                fontComboBox.Invoke(new Action(() =>
                {
                    fontComboBox.SelectedItem = fontFamily;
                }));
            }
            else
            {
                fontComboBox.SelectedItem = fontFamily;
            }
        }

        private void SetFontSize(int fontSize)
        {
            // Set the selected font size on the form's combo box
            if (fontSizeComboBox.InvokeRequired)
            {
                fontSizeComboBox.Invoke(new Action(() =>
                {
                    fontSizeComboBox.SelectedItem = fontSize.ToString();
                }));
            }
            else
            {
                fontSizeComboBox.SelectedItem = fontSize.ToString();
            }
        }

        private void SetFontColor(Color fontColor)
        {
            // Set the selected font color on the form's combo box
            if (fontColorComboBox.InvokeRequired)
            {
                fontColorComboBox.Invoke(new Action(() =>
                {
                    fontColorComboBox.SelectedItem = fontColor.Name;
                }));
            }
            else
            {
                fontColorComboBox.SelectedItem = fontColor.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void darkModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Check if Dark Mode is enabled or disabled
            var darkModeEnabled = darkModeCheckBox.Checked;
            DataModels.ThemeManager.DarkModeEnabled = darkModeEnabled;
        }
    }
}