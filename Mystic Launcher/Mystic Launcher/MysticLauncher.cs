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

            Configuration Config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            //Checking for Vanilla directories. If they are empty or none existing the value of VanillaDir will be saved to Config.

            //Exception and Error Handling
            if (Config.AppSettings.Settings["VanillaPath"].Value == string.Empty)
            {
                Config.AppSettings.Settings.Add("VanillaPath", VanillaDir);
                Config.Save(ConfigurationSaveMode.Minimal);
            }
            if (Config.AppSettings.Settings["VanillaPath"].Value == null)
            {
                Config.AppSettings.Settings.Add("VanillaPath", VanillaDir);
                Config.Save(ConfigurationSaveMode.Minimal);
            }
            if (Config.AppSettings.Settings["VanillaPath"].Value == ",")
            {
                Config.AppSettings.Settings["VanillaPath"].Value = "";
                Config.AppSettings.Settings.Add("VanillaPath", VanillaDir);
                Config.Save(ConfigurationSaveMode.Minimal);
            }

            //Overwrite Currently Saved Directory
            Config.AppSettings.Settings["VanillaPath"].Value = "";
            Config.AppSettings.Settings.Add("VanillaPath", VanillaDir);
            Config.Save(ConfigurationSaveMode.Minimal);
        }

        private void SetTBCDir_Click(object sender, EventArgs e)
        {
            LoadWoWDir.ShowDialog();
            TBCDir = LoadWoWDir.FileName;

            Configuration Config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            //Checking for TBC directories. If they are empty or none existing the value of TBCDir will be saved to Config.

            //Exception and Error Handling
            if (Config.AppSettings.Settings["TBCPath"].Value == string.Empty)
            {
                Config.AppSettings.Settings.Add("TBCPath", TBCDir);
                Config.Save(ConfigurationSaveMode.Minimal);
            }
            if (Config.AppSettings.Settings["TBCPath"].Value == null)
            {
                Config.AppSettings.Settings.Add("TBCPath", TBCDir);
                Config.Save(ConfigurationSaveMode.Minimal);
            }
            if (Config.AppSettings.Settings["TBCPath"].Value == ",")
            {
                Config.AppSettings.Settings["TBCPath"].Value = "";
                Config.AppSettings.Settings.Add("TBCPath", TBCDir);
                Config.Save(ConfigurationSaveMode.Minimal);
            }

            //Overwrite Currently Saved Directory
            Config.AppSettings.Settings["TBCPath"].Value = "";
            Config.AppSettings.Settings.Add("TBCPath", TBCDir);
            Config.Save(ConfigurationSaveMode.Minimal);
        }

        private void SetWotLKDir_Click(object sender, EventArgs e)
        {
            LoadWoWDir.ShowDialog();
            WotLKDir = LoadWoWDir.FileName;

            Configuration Config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            //Checking for WotLK directories. If they are empty or none existing the value of WotLKDir will be saved to Config.

            //Exception and Error Handling
            if (Config.AppSettings.Settings["WotLKPath"].Value == string.Empty)
            {
                Config.AppSettings.Settings.Add("WotLKPath", WotLKDir);
                Config.Save(ConfigurationSaveMode.Minimal);
            }
            if (Config.AppSettings.Settings["WotLKPath"].Value == null)
            {
                Config.AppSettings.Settings.Add("WotLKPath", WotLKDir);
                Config.Save(ConfigurationSaveMode.Minimal);
            }
            if (Config.AppSettings.Settings["WotLKPath"].Value == ",")
            {
                Config.AppSettings.Settings["WotLKPath"].Value = "";
                Config.AppSettings.Settings.Add("WotLKPath", WotLKDir);
                Config.Save(ConfigurationSaveMode.Minimal);
            }
            
            //Overwrite Currently Saved Directory
            Config.AppSettings.Settings["WotLKPath"].Value = "";
            Config.AppSettings.Settings.Add("WotLKPath", WotLKDir);
            Config.Save(ConfigurationSaveMode.Minimal);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            //Set Realmlist Depending on Expansion chosen
            if (WoWVersionSelector.Text == "Vanilla")
            {
                VanillaDir = VanillaDir.Replace(",", "");
                string VanillaRealmListPath = VanillaDir.Replace("Wow.exe", "").Replace("WoW.exe", "").Replace("wow.exe", "");
                System.IO.File.WriteAllText(VanillaRealmListPath + "realmlist.wtf", "set realmlist " + ServerList.Text);
            }

            if (WoWVersionSelector.Text == "The Burning Crusade")
            {
                TBCDir = TBCDir.Replace(",", "");
                string TBCRealmListPath = TBCDir.Replace("Wow.exe", "").Replace("WoW.exe", "").Replace("wow.exe", "");
                System.IO.File.WriteAllText(TBCRealmListPath + "realmlist.wtf", "set realmlist " + ServerList.Text);
            }

            if (WoWVersionSelector.Text == "Wrath of the Lich King")
            {
                WotLKDir = WotLKDir.Replace(",", "");
                string WotLKRealmListPath = WotLKDir.Replace("Wow.exe","").Replace("WoW.exe", "").Replace("wow.exe", "");
                System.IO.File.WriteAllText(WotLKRealmListPath + @"Data\enUS\realmlist.wtf", "set realmlist "+ServerList.Text);
            }

            //Start WoW.exe based on the version selected using the ComboBox
            if (WoWVersionSelector.Text == "Vanilla")
            {
                VanillaDir = VanillaDir.Replace(",", ""); //Replacing commas added to directory when key is being added to config.
                System.Diagnostics.Process.Start(VanillaDir);
            }

            if (WoWVersionSelector.Text == "The Burning Crusade")
            {
                TBCDir = TBCDir.Replace(",", ""); //Replacing commas added to directory when key is being added to config.
                System.Diagnostics.Process.Start(TBCDir);
            }

            if (WoWVersionSelector.Text == "Wrath of the Lich King")
            {
                WotLKDir = WotLKDir.Replace(",", ""); //Replacing commas added to directory when key is being added to config.
                System.Diagnostics.Process.Start(WotLKDir);
            }

        }

        private void AddServer_Click(object sender, EventArgs e)
        {
            //Make sure there is text inputted into the textbox to avoid blank spaces.
            if (AddToServerList.Text == string.Empty)
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
