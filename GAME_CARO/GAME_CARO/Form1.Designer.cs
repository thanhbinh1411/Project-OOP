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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Mark_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LAN_btn = new System.Windows.Forms.Button();
            this.Time_pcb = new System.Windows.Forms.ProgressBar();
            this.LAN_txb = new System.Windows.Forms.TextBox();
            this.Player_txb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChessBoard_pnl = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mark_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Mark_pic);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.LAN_btn);
            this.panel2.Controls.Add(this.Time_pcb);
            this.panel2.Controls.Add(this.LAN_txb);
            this.panel2.Controls.Add(this.Player_txb);
            this.panel2.Location = new System.Drawing.Point(1160, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 475);
            this.panel2.TabIndex = 1;
            // 
            // Mark_pic
            // 
            this.Mark_pic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Mark_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mark_pic.Location = new System.Drawing.Point(215, 18);
            this.Mark_pic.Name = "Mark_pic";
            this.Mark_pic.Size = new System.Drawing.Size(192, 193);
            this.Mark_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mark_pic.TabIndex = 6;
            this.Mark_pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 in a line to Win";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(4, 301);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(403, 161);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // LAN_btn
            // 
            this.LAN_btn.Location = new System.Drawing.Point(4, 167);
            this.LAN_btn.Name = "LAN_btn";
            this.LAN_btn.Size = new System.Drawing.Size(204, 44);
            this.LAN_btn.TabIndex = 3;
            this.LAN_btn.Text = "LAN";
            this.LAN_btn.UseVisualStyleBackColor = true;
            // 
            // Time_pcb
            // 
            this.Time_pcb.Location = new System.Drawing.Point(4, 68);
            this.Time_pcb.Name = "Time_pcb";
            this.Time_pcb.Size = new System.Drawing.Size(204, 27);
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
            this.Player_txb.Location = new System.Drawing.Point(4, 18);
            this.Player_txb.Multiline = true;
            this.Player_txb.Name = "Player_txb";
            this.Player_txb.Size = new System.Drawing.Size(204, 43);
            this.Player_txb.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1161, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 347);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ChessBoard_pnl
            // 
            this.ChessBoard_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.ChessBoard_pnl.Location = new System.Drawing.Point(17, 4);
            this.ChessBoard_pnl.Name = "ChessBoard_pnl";
            this.ChessBoard_pnl.Size = new System.Drawing.Size(1141, 862);
            this.ChessBoard_pnl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 874);
            this.Controls.Add(this.ChessBoard_pnl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mark_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button LAN_btn;
        private System.Windows.Forms.ProgressBar Time_pcb;
        private System.Windows.Forms.TextBox LAN_txb;
        private System.Windows.Forms.TextBox Player_txb;
        private System.Windows.Forms.PictureBox Mark_pic;
        private System.Windows.Forms.Panel ChessBoard_pnl;
    }
}

