namespace Mystic_Launcher
{
    partial class MysticLauncher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MysticLauncher));
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.AddServer = new DarkUI.Controls.DarkButton();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.ServerList = new DarkUI.Controls.DarkComboBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.WoWVersionSelector = new DarkUI.Controls.DarkComboBox();
            this.SetTBCDir = new DarkUI.Controls.DarkButton();
            this.SetVanillaDir = new DarkUI.Controls.DarkButton();
            this.SetWotLKDir = new DarkUI.Controls.DarkButton();
            this.PlayButton = new DarkUI.Controls.DarkButton();
            this.MysticHeroImage = new System.Windows.Forms.PictureBox();
            this.darkDockPanel1 = new DarkUI.Docking.DarkDockPanel();
            this.LoadWoWDir = new System.Windows.Forms.OpenFileDialog();
            this.AddToServerList = new DarkUI.Controls.DarkTextBox();
            this.darkSectionPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MysticHeroImage)).BeginInit();
            this.SuspendLayout();
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.BackColor = System.Drawing.Color.Transparent;
            this.darkSectionPanel1.Controls.Add(this.AddToServerList);
            this.darkSectionPanel1.Controls.Add(this.AddServer);
            this.darkSectionPanel1.Controls.Add(this.darkLabel2);
            this.darkSectionPanel1.Controls.Add(this.ServerList);
            this.darkSectionPanel1.Controls.Add(this.darkLabel1);
            this.darkSectionPanel1.Controls.Add(this.WoWVersionSelector);
            this.darkSectionPanel1.Controls.Add(this.SetTBCDir);
            this.darkSectionPanel1.Controls.Add(this.SetVanillaDir);
            this.darkSectionPanel1.Controls.Add(this.SetWotLKDir);
            this.darkSectionPanel1.Controls.Add(this.PlayButton);
            this.darkSectionPanel1.Controls.Add(this.MysticHeroImage);
            this.darkSectionPanel1.Controls.Add(this.darkDockPanel1);
            this.darkSectionPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkSectionPanel1.Location = new System.Drawing.Point(0, 0);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = null;
            this.darkSectionPanel1.Size = new System.Drawing.Size(453, 432);
            this.darkSectionPanel1.TabIndex = 0;
            // 
            // AddServer
            // 
            this.AddServer.Location = new System.Drawing.Point(302, 227);
            this.AddServer.Name = "AddServer";
            this.AddServer.Padding = new System.Windows.Forms.Padding(5);
            this.AddServer.Size = new System.Drawing.Size(139, 36);
            this.AddServer.TabIndex = 10;
            this.AddServer.Text = "Add Server";
            this.AddServer.Click += new System.EventHandler(this.AddServer_Click);
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(11, 321);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(259, 17);
            this.darkLabel2.TabIndex = 9;
            this.darkLabel2.Text = "Which Server would you like to play on?";
            // 
            // ServerList
            // 
            this.ServerList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ServerList.FormattingEnabled = true;
            this.ServerList.Location = new System.Drawing.Point(274, 318);
            this.ServerList.Name = "ServerList";
            this.ServerList.Size = new System.Drawing.Size(165, 23);
            this.ServerList.TabIndex = 8;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(11, 285);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(261, 17);
            this.darkLabel1.TabIndex = 7;
            this.darkLabel1.Text = "Which expansion would you like to play?";
            // 
            // WoWVersionSelector
            // 
            this.WoWVersionSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WoWVersionSelector.FormattingEnabled = true;
            this.WoWVersionSelector.Items.AddRange(new object[] {
            "Vanilla",
            "The Burning Crusade",
            "Wrath of the Lich King"});
            this.WoWVersionSelector.Location = new System.Drawing.Point(274, 282);
            this.WoWVersionSelector.Name = "WoWVersionSelector";
            this.WoWVersionSelector.Size = new System.Drawing.Size(165, 23);
            this.WoWVersionSelector.TabIndex = 6;
            // 
            // SetTBCDir
            // 
            this.SetTBCDir.Location = new System.Drawing.Point(157, 167);
            this.SetTBCDir.Name = "SetTBCDir";
            this.SetTBCDir.Padding = new System.Windows.Forms.Padding(5);
            this.SetTBCDir.Size = new System.Drawing.Size(139, 41);
            this.SetTBCDir.TabIndex = 5;
            this.SetTBCDir.Text = "Set TBC Directory";
            this.SetTBCDir.Click += new System.EventHandler(this.SetTBCDir_Click);
            // 
            // SetVanillaDir
            // 
            this.SetVanillaDir.Location = new System.Drawing.Point(12, 167);
            this.SetVanillaDir.Name = "SetVanillaDir";
            this.SetVanillaDir.Padding = new System.Windows.Forms.Padding(5);
            this.SetVanillaDir.Size = new System.Drawing.Size(139, 41);
            this.SetVanillaDir.TabIndex = 4;
            this.SetVanillaDir.Text = "Set Vanilla Directory";
            this.SetVanillaDir.Click += new System.EventHandler(this.SetVanillaDir_Click);
            // 
            // SetWotLKDir
            // 
            this.SetWotLKDir.Location = new System.Drawing.Point(302, 167);
            this.SetWotLKDir.Name = "SetWotLKDir";
            this.SetWotLKDir.Padding = new System.Windows.Forms.Padding(5);
            this.SetWotLKDir.Size = new System.Drawing.Size(139, 41);
            this.SetWotLKDir.TabIndex = 3;
            this.SetWotLKDir.Text = "Set WoTLK Directory";
            this.SetWotLKDir.Click += new System.EventHandler(this.SetWotLKDir_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(12, 359);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Padding = new System.Windows.Forms.Padding(5);
            this.PlayButton.Size = new System.Drawing.Size(429, 60);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "PLAY";
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // MysticHeroImage
            // 
            this.MysticHeroImage.Image = global::Mystic_Launcher.Properties.Resources.Mystic_Launcher;
            this.MysticHeroImage.Location = new System.Drawing.Point(172, 28);
            this.MysticHeroImage.Name = "MysticHeroImage";
            this.MysticHeroImage.Size = new System.Drawing.Size(100, 100);
            this.MysticHeroImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MysticHeroImage.TabIndex = 0;
            this.MysticHeroImage.TabStop = false;
            // 
            // darkDockPanel1
            // 
            this.darkDockPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkDockPanel1.Location = new System.Drawing.Point(12, 152);
            this.darkDockPanel1.Name = "darkDockPanel1";
            this.darkDockPanel1.Size = new System.Drawing.Size(440, 201);
            this.darkDockPanel1.TabIndex = 2;
            // 
            // AddToServerList
            // 
            this.AddToServerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.AddToServerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddToServerList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.AddToServerList.Location = new System.Drawing.Point(14, 235);
            this.AddToServerList.Name = "AddToServerList";
            this.AddToServerList.Size = new System.Drawing.Size(282, 22);
            this.AddToServerList.TabIndex = 11;
            // 
            // MysticLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(453, 432);
            this.Controls.Add(this.darkSectionPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MysticLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mystic Launcher";
            this.Load += new System.EventHandler(this.MysticLauncher_Load);
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MysticHeroImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private System.Windows.Forms.PictureBox MysticHeroImage;
        private DarkUI.Controls.DarkButton PlayButton;
        private DarkUI.Docking.DarkDockPanel darkDockPanel1;
        private DarkUI.Controls.DarkButton SetTBCDir;
        private DarkUI.Controls.DarkButton SetVanillaDir;
        private DarkUI.Controls.DarkButton SetWotLKDir;
        private System.Windows.Forms.OpenFileDialog LoadWoWDir;
        private DarkUI.Controls.DarkComboBox WoWVersionSelector;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkButton AddServer;
        private DarkUI.Controls.DarkTextBox AddToServerList;
        private DarkUI.Controls.DarkComboBox ServerList;
    }
}

