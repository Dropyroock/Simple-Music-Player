namespace MusicPlayerApp
{
    partial class MusicPlayerApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            TopPanel = new Panel();
            minimizeBtn = new PictureBox();
            closeBtn = new PictureBox();
            lblLogo = new Label();
            listBoxSongs = new ListBox();
            selectSongsBtn = new Button();
            windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            lblFooter = new Label();
            saveSongBtn = new Button();
            deleteSongBtn = new Button();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimizeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)windowsMediaPlayer).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.Teal;
            TopPanel.Controls.Add(minimizeBtn);
            TopPanel.Controls.Add(closeBtn);
            TopPanel.Controls.Add(lblLogo);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(800, 51);
            TopPanel.TabIndex = 0;
            // 
            // minimizeBtn
            // 
            minimizeBtn.Image = (Image)resources.GetObject("minimizeBtn.Image");
            minimizeBtn.Location = new Point(720, 12);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(31, 30);
            minimizeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            minimizeBtn.TabIndex = 3;
            minimizeBtn.TabStop = false;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Image = (Image)resources.GetObject("closeBtn.Image");
            closeBtn.Location = new Point(757, 12);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(31, 30);
            closeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            closeBtn.TabIndex = 2;
            closeBtn.TabStop = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe MDL2 Assets", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(18, 12);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(136, 19);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Music Player App";
            // 
            // listBoxSongs
            // 
            listBoxSongs.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.ItemHeight = 17;
            listBoxSongs.Location = new Point(557, 57);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(231, 191);
            listBoxSongs.TabIndex = 1;
            listBoxSongs.SelectedIndexChanged += listBoxSongs_SelectedIndexChanged;
            // 
            // selectSongsBtn
            // 
            selectSongsBtn.BackColor = SystemColors.ActiveCaption;
            selectSongsBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectSongsBtn.Location = new Point(557, 261);
            selectSongsBtn.Name = "selectSongsBtn";
            selectSongsBtn.Size = new Size(231, 50);
            selectSongsBtn.TabIndex = 2;
            selectSongsBtn.Text = "Select Songs";
            selectSongsBtn.UseVisualStyleBackColor = false;
            selectSongsBtn.Click += selectSongsBtn_Click;
            // 
            // windowsMediaPlayer
            // 
            windowsMediaPlayer.Enabled = true;
            windowsMediaPlayer.Location = new Point(18, 57);
            windowsMediaPlayer.Name = "windowsMediaPlayer";
            windowsMediaPlayer.OcxState = (AxHost.State)resources.GetObject("windowsMediaPlayer.OcxState");
            windowsMediaPlayer.Size = new Size(522, 366);
            windowsMediaPlayer.TabIndex = 3;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.ForeColor = SystemColors.ControlDark;
            lblFooter.Location = new Point(18, 426);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(125, 15);
            lblFooter.TabIndex = 4;
            lblFooter.Text = "Developped By: Resley";
            // 
            // saveSongBtn
            // 
            saveSongBtn.BackColor = Color.Green;
            saveSongBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveSongBtn.Location = new Point(557, 317);
            saveSongBtn.Name = "saveSongBtn";
            saveSongBtn.Size = new Size(231, 50);
            saveSongBtn.TabIndex = 5;
            saveSongBtn.Text = "Save Songs";
            saveSongBtn.UseVisualStyleBackColor = false;
            saveSongBtn.Click += saveSongBtn_Click;
            // 
            // deleteSongBtn
            // 
            deleteSongBtn.BackColor = Color.Red;
            deleteSongBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSongBtn.Location = new Point(557, 373);
            deleteSongBtn.Name = "deleteSongBtn";
            deleteSongBtn.Size = new Size(231, 50);
            deleteSongBtn.TabIndex = 6;
            deleteSongBtn.Text = "Delete Songs";
            deleteSongBtn.UseVisualStyleBackColor = false;
            deleteSongBtn.Click += deleteSongBtn_Click;
            // 
            // MusicPlayerApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteSongBtn);
            Controls.Add(saveSongBtn);
            Controls.Add(lblFooter);
            Controls.Add(windowsMediaPlayer);
            Controls.Add(selectSongsBtn);
            Controls.Add(listBoxSongs);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MusicPlayerApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Player App";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minimizeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)windowsMediaPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Label lblLogo;
        private PictureBox closeBtn;
        private ListBox listBoxSongs;
        private Button selectSongsBtn;
        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer;
        private Label lblFooter;
        private Button saveSongBtn;
        private Button deleteSongBtn;
        private PictureBox minimizeBtn;
    }
}
