namespace Snake_Game
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnstart = new Button();
            btnstop = new Button();
            lblhighscore = new Label();
            lblscore = new Label();
            piccanvas = new PictureBox();
            proptimer = new System.Windows.Forms.Timer(components);
            btnresume = new Button();
            menuStrip1 = new MenuStrip();
            levelmen = new ToolStripMenuItem();
            easyToolStripMenuItem = new ToolStripMenuItem();
            mediumToolStripMenuItem = new ToolStripMenuItem();
            hardToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)piccanvas).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnstart
            // 
            btnstart.BackColor = Color.Red;
            btnstart.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnstart.ForeColor = SystemColors.ActiveCaptionText;
            btnstart.Location = new Point(1022, 74);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(112, 52);
            btnstart.TabIndex = 4;
            btnstart.Text = "Start";
            btnstart.UseVisualStyleBackColor = false;
            btnstart.Click += Startgame;
            // 
            // btnstop
            // 
            btnstop.BackColor = Color.Red;
            btnstop.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnstop.ForeColor = SystemColors.ActiveCaptionText;
            btnstop.Location = new Point(1022, 144);
            btnstop.Name = "btnstop";
            btnstop.Size = new Size(112, 52);
            btnstop.TabIndex = 3;
            btnstop.Text = "Stop";
            btnstop.UseVisualStyleBackColor = false;
            btnstop.Click += Stopgame;
            // 
            // lblhighscore
            // 
            lblhighscore.AutoSize = true;
            lblhighscore.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblhighscore.Location = new Point(1007, 353);
            lblhighscore.Name = "lblhighscore";
            lblhighscore.Size = new Size(166, 32);
            lblhighscore.TabIndex = 2;
            lblhighscore.Text = "High Score: 0";
            // 
            // lblscore
            // 
            lblscore.AutoSize = true;
            lblscore.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblscore.Location = new Point(1007, 400);
            lblscore.Name = "lblscore";
            lblscore.Size = new Size(112, 32);
            lblscore.TabIndex = 1;
            lblscore.Text = "Score : 0";
            // 
            // piccanvas
            // 
            piccanvas.BackColor = SystemColors.ActiveCaptionText;
            piccanvas.BorderStyle = BorderStyle.FixedSingle;
            piccanvas.Location = new Point(40, 55);
            piccanvas.Name = "piccanvas";
            piccanvas.Size = new Size(935, 613);
            piccanvas.TabIndex = 0;
            piccanvas.TabStop = false;
            piccanvas.Paint += Updatepicbox;
            // 
            // proptimer
            // 
            proptimer.Interval = 200;
            proptimer.Tick += Gametimerevent;
            // 
            // btnresume
            // 
            btnresume.BackColor = Color.Red;
            btnresume.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnresume.ForeColor = Color.Black;
            btnresume.Location = new Point(1022, 211);
            btnresume.Name = "btnresume";
            btnresume.Size = new Size(112, 60);
            btnresume.TabIndex = 5;
            btnresume.Text = "Resume";
            btnresume.UseVisualStyleBackColor = false;
            btnresume.Click += btnresume_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { levelmen });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1185, 40);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // levelmen
            // 
            levelmen.BackColor = Color.Red;
            levelmen.DropDownItems.AddRange(new ToolStripItem[] { easyToolStripMenuItem, mediumToolStripMenuItem, hardToolStripMenuItem });
            levelmen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            levelmen.ForeColor = SystemColors.Desktop;
            levelmen.Name = "levelmen";
            levelmen.Size = new Size(99, 36);
            levelmen.Text = "Levels";
            levelmen.Click += levelsToolStripMenuItem_Click;
            // 
            // easyToolStripMenuItem
            // 
            easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            easyToolStripMenuItem.Size = new Size(270, 40);
            easyToolStripMenuItem.Text = "Easy";
            easyToolStripMenuItem.Click += easyToolStripMenuItem_Click;
            // 
            // mediumToolStripMenuItem
            // 
            mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            mediumToolStripMenuItem.Size = new Size(270, 40);
            mediumToolStripMenuItem.Text = "Medium";
            mediumToolStripMenuItem.Click += mediumToolStripMenuItem_Click;
            // 
            // hardToolStripMenuItem
            // 
            hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            hardToolStripMenuItem.Size = new Size(270, 40);
            hardToolStripMenuItem.Text = "Hard";
            hardToolStripMenuItem.Click += hardToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 680);
            Controls.Add(btnresume);
            Controls.Add(piccanvas);
            Controls.Add(lblscore);
            Controls.Add(lblhighscore);
            Controls.Add(btnstop);
            Controls.Add(btnstart);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Load += Startgame;
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)piccanvas).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnstart;
        private Button btnstop;
        private Label lblhighscore;
        private Label lblscore;
        private PictureBox piccanvas;
        private System.Windows.Forms.Timer proptimer;
        private Button btnresume;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem levelmen;
        private ToolStripMenuItem easyToolStripMenuItem;
        private ToolStripMenuItem mediumToolStripMenuItem;
        private ToolStripMenuItem hardToolStripMenuItem;
    }
}
