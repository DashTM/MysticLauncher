using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Mystic_Launcher
{
    public partial class MysticLauncher : Form
    {
        string VanillaDir;
        string WotLKDir;
        string TBCDir;
       // string AddNewServer;

        public MysticLauncher()
        {
            InitializeComponent();
        }

        private void MysticLauncher_Load(object sender, EventArgs e)
        {
            Configuration Config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            VanillaDir = Config.AppSettings.Settings["VanillaPath"].Value;
            TBCDir = Config.AppSettings.Settings["TBCPath"].Value;
            WotLKDir = Config.AppSettings.Settings["WotLKPath"].Value;

            ServerList.Items.AddRange(ConfigurationManager.AppSettings["SavedServers"].Split(','));

        }

        private void SetVanillaDir_Click(object sender, EventArgs e)
        {
            LoadWoWDir.ShowDialog();
            VanillaDir = LoadWoWDir.FileName;

            SetDirectory("VanillaPath", VanillaDir);
        }

        private void SetTBCDir_Click(object sender, EventArgs e)
        {
            LoadWoWDir.ShowDialog();
            TBCDir = LoadWoWDir.FileName;

            SetDirectory("TBCPath", TBCDir);
        }

        private void SetWotLKDir_Click(object sender, EventArgs e)
        {
            LoadWoWDir.ShowDialog();
            WotLKDir = LoadWoWDir.FileName;

            SetDirectory("WotLKPath", WotLKDir);
        }

        private void SetDirectory(string expansionPath, string directory)
        {
            Configuration Config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            //Checking for directories. If they are empty or non existing the value of directory will be saved to Config.
            if (string.IsNullOrWhiteSpace(Config.AppSettings.Settings[expansionPath].Value))
            {
                Config.AppSettings.Settings.Add(expansionPath, directory);
                Config.Save(ConfigurationSaveMode.Minimal);
            }

            if (Config.AppSettings.Settings[expansionPath].Value == ",")
            {
                Config.AppSettings.Settings[expansionPath].Value = "";
                Config.AppSettings.Settings.Add(expansionPath, directory);
                Config.Save(ConfigurationSaveMode.Minimal);
            }

            //Overwrite Currently Saved Directory
            Config.AppSettings.Settings[expansionPath].Value = "";
            Config.AppSettings.Settings.Add(expansionPath, directory);
            Config.Save(ConfigurationSaveMode.Minimal);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            switch (WoWVersionSelector.Text)
            {
                //Set Realmlist and start wow.exe Depending on Expansion chosen
                case "Vanilla":
                    VanillaDir = VanillaDir.Replace(",", "");//Replacing commas added to directory when key is being added to config.
                    SetRealmList(VanillaDir);
                    System.Diagnostics.Process.Start(VanillaDir);
                    break;
                case "The Burning Crusade":
                    TBCDir = TBCDir.Replace(",", "");//Replacing commas added to directory when key is being added to config.
                    SetRealmList(TBCDir);
                    System.Diagnostics.Process.Start(TBCDir);
                    break;
                case "Wrath of the Lich King":
                    WotLKDir = WotLKDir.Replace(",", "");//Replacing commas added to directory when key is being added to config.
                    SetRealmList(WotLKDir, true);
                    System.Diagnostics.Process.Start(WotLKDir);
                    break;
            }
        }

        private void SetRealmList(string pathToWowExe, bool newRealmListPath = false)
        {
            string realmListPath = pathToWowExe.Remove(pathToWowExe.LastIndexOf(@"\") + 1);

            if (newRealmListPath)
                realmListPath += @"Data\enUS\realmlist.wtf";
            else
                realmListPath += "realmlist.wtf";

            File.WriteAllText(realmListPath, "set realmlist " + ServerList.Text);
        }

        private void AddServer_Click(object sender, EventArgs e)
        {
            //Make sure there is text inputted into the textbox to avoid blank spaces.
            if (string.IsNullOrWhiteSpace(AddToServerList.Text))
            {
                MessageBox.Show("Please enter the address for a server!", "MysticLauncher Error");
            }
            else
            {
                Configuration Config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

                //Add the current text to Server List.
                ServerList.Items.Add(AddToServerList.Text);

                //Save new entries to Server List to config file.
                Config.AppSettings.Settings.Add("SavedServers", AddToServerList.Text);

                Config.Save(ConfigurationSaveMode.Minimal);

                //Clear Textbox after adding new server.
                AddToServerList.Clear();

                //Let User know that desired server hass been added to Server List.
                MessageBox.Show("Server has been added successfully", "Mystic Launcher");
            }
        }
    }
}
