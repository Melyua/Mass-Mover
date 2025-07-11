using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Media;

namespace FileMoverApp
{
    public partial class Form1 : Form
    {
        Dictionary<string, Dictionary<string, string>> translations;
        string currentLanguage = "ru";

        public Form1()
        {
            InitializeComponent();
            InitTranslations();
            LoadLanguageSetting();
            ApplyTranslation();
        }

        private void InitTranslations()
        {
            translations = new Dictionary<string, Dictionary<string, string>>();

            translations["ru"] = new Dictionary<string, string>
            {
                { "copy", "Копировать" },
                { "move", "Переместить" },
                { "start", "Запустить" },
                { "status_ready", "Готов" },
                { "select_lang", "Язык:" },
                { "overwrite", "С заменой" },
                { "error", "Ошибка" }
            };
            translations["en"] = new Dictionary<string, string>
            {
                { "copy", "Copy" },
                { "move", "Move" },
                { "start", "Start" },
                { "status_ready", "Ready" },
                { "select_lang", "Language:" },
                { "overwrite", "Overwrite" },
                { "error", "Error" }
            };
            translations["uk"] = new Dictionary<string, string>
            {
                { "copy", "Копіювати" },
                { "move", "Перемістити" },
                { "start", "Запустити" },
                { "status_ready", "Готово" },
                { "select_lang", "Мова:" },
                { "overwrite", "З заміною" },
                { "error", "Помилка" }
            };
        }

        private void LoadLanguageSetting()
        {
            if (File.Exists("settings.ini"))
            {
                currentLanguage = File.ReadAllText("settings.ini").Trim();
            }

            comboBoxLanguage.Items.AddRange(new string[] { "Русский", "English", "Українська" });

            if (currentLanguage == "ru") comboBoxLanguage.SelectedIndex = 0;
            else if (currentLanguage == "en") comboBoxLanguage.SelectedIndex = 1;
            else if (currentLanguage == "uk") comboBoxLanguage.SelectedIndex = 2;
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLanguage.SelectedIndex == 0) currentLanguage = "ru";
            else if (comboBoxLanguage.SelectedIndex == 1) currentLanguage = "en";
            else if (comboBoxLanguage.SelectedIndex == 2) currentLanguage = "uk";

            File.WriteAllText("settings.ini", currentLanguage);
            ApplyTranslation();
        }

        private void ApplyTranslation()
        {
            radioButtonCopy.Text = translations[currentLanguage]["copy"];
            radioButtonMove.Text = translations[currentLanguage]["move"];
            buttonStart.Text = translations[currentLanguage]["start"];
            labelStatus.Text = translations[currentLanguage]["status_ready"];
            labelLang.Text = translations[currentLanguage]["select_lang"];
            checkBoxOverwrite.Text = translations[currentLanguage]["overwrite"];
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!File.Exists("config.txt"))
            {
                MessageBox.Show("config.txt not found!");
                return;
            }

            string[] lines = File.ReadAllLines("config.txt");
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) || line.TrimStart().StartsWith("#"))
                    continue;

                string[] parts = line.Split('|');
                if (parts.Length != 2) continue;

                string source = parts[0].Trim();
                string destinationFolder = parts[1].Trim();
                string fileName = Path.GetFileName(source);
                string destPath = Path.Combine(destinationFolder, fileName);

                try
                {
                    bool overwrite = checkBoxOverwrite.Checked;

                    // Создание папки назначения, если её нет
                    Directory.CreateDirectory(destinationFolder);

                    if (radioButtonCopy.Checked)
                    {
                        if (overwrite || !File.Exists(destPath))
                            File.Copy(source, destPath, overwrite);
                    }
                    else if (radioButtonMove.Checked)
                    {
                        if (overwrite && File.Exists(destPath))
                            File.Delete(destPath);

                        File.Move(source, destPath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{translations[currentLanguage]["error"]}: {ex.Message}");
                }
            }
            System.Media.SystemSounds.Asterisk.Play();
            labelStatus.Text = translations[currentLanguage]["status_ready"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxOverwrite_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
