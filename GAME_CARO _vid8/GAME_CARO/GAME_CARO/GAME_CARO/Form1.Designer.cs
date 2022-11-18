namespace GAME_CARO
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Mark_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LAN_btn = new System.Windows.Forms.Button();
            this.Time_pcb = new System.Windows.Forms.ProgressBar();
            this.LAN_txb = new System.Windows.Forms.TextBox();
            this.Player_txb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChessBoard_pnl = new System.Windows.Forms.Panel();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mark_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Mark_pic);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.LAN_btn);
            this.panel2.Controls.Add(this.Time_pcb);
            this.panel2.Controls.Add(this.LAN_txb);
            this.panel2.Controls.Add(this.Player_txb);
            this.panel2.Location = new System.Drawing.Point(1160, 557);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 340);
            this.panel2.TabIndex = 1;
            // 
            // Mark_pic
            // 
            this.Mark_pic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Mark_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mark_pic.Location = new System.Drawing.Point(214, 19);
            this.Mark_pic.Name = "Mark_pic";
            this.Mark_pic.Size = new System.Drawing.Size(192, 194);
            this.Mark_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mark_pic.TabIndex = 6;
            this.Mark_pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 in a line to Win";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LAN_btn
            // 
            this.LAN_btn.Location = new System.Drawing.Point(4, 167);
            this.LAN_btn.Name = "LAN_btn";
            this.LAN_btn.Size = new System.Drawing.Size(204, 44);
            this.LAN_btn.TabIndex = 3;
            this.LAN_btn.Text = "LAN";
            this.LAN_btn.UseVisualStyleBackColor = true;
            this.LAN_btn.Click += new System.EventHandler(this.LAN_btn_Click);
            // 
            // Time_pcb
            // 
            this.Time_pcb.Location = new System.Drawing.Point(4, 69);
            this.Time_pcb.Name = "Time_pcb";
            this.Time_pcb.Size = new System.Drawing.Size(204, 42);
            this.Time_pcb.TabIndex = 2;
            // 
            // LAN_txb
            // 
            this.LAN_txb.Location = new System.Drawing.Point(4, 117);
            this.LAN_txb.Multiline = true;
            this.LAN_txb.Name = "LAN_txb";
            this.LAN_txb.Size = new System.Drawing.Size(204, 43);
            this.LAN_txb.TabIndex = 1;
            // 
            // Player_txb
            // 
            this.Player_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_txb.Location = new System.Drawing.Point(4, 19);
            this.Player_txb.Multiline = true;
            this.Player_txb.Name = "Player_txb";
            this.Player_txb.Size = new System.Drawing.Size(204, 43);
            this.Player_txb.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1160, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 347);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ChessBoard_pnl
            // 
            this.ChessBoard_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.ChessBoard_pnl.Location = new System.Drawing.Point(12, 47);
            this.ChessBoard_pnl.Name = "ChessBoard_pnl";
            this.ChessBoard_pnl.Size = new System.Drawing.Size(1142, 850);
            this.ChessBoard_pnl.TabIndex = 3;
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.musicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1616, 42);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(97, 36);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(347, 44);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(347, 44);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(347, 44);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(97, 36);
            this.musicToolStripMenuItem.Text = "Music";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 942);
            this.Controls.Add(this.ChessBoard_pnl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mark_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LAN_btn;
        private System.Windows.Forms.ProgressBar Time_pcb;
        private System.Windows.Forms.TextBox LAN_txb;
        private System.Windows.Forms.TextBox Player_txb;
        private System.Windows.Forms.PictureBox Mark_pic;
        private System.Windows.Forms.Panel ChessBoard_pnl;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
    }
}

