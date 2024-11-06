using System.Drawing;

namespace Trace_Quest {
    partial class MainMenuGUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.logoSubtext = new System.Windows.Forms.Label();
            this.mainMenuLogoPanel = new System.Windows.Forms.Panel();
            this.mainMenuLogo = new System.Windows.Forms.PictureBox();
            this.questPoster01Button = new System.Windows.Forms.Button();
            this.questPoster03 = new System.Windows.Forms.PictureBox();
            this.questPoster02 = new System.Windows.Forms.PictureBox();
            this.questPoster01 = new System.Windows.Forms.PictureBox();
            this.questPoster02Button = new System.Windows.Forms.Button();
            this.questPoster03Button = new System.Windows.Forms.Button();
            this.questPoster01Label = new System.Windows.Forms.Label();
            this.questPoster02Label = new System.Windows.Forms.Label();
            this.questPoster03Label = new System.Windows.Forms.Label();
            this.mainGUIParentPanel = new System.Windows.Forms.Panel();
            this.mainMenuLogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questPoster03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questPoster02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questPoster01)).BeginInit();
            this.mainGUIParentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoSubtext
            // 
            this.logoSubtext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoSubtext.AutoSize = true;
            this.logoSubtext.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoSubtext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoSubtext.Location = new System.Drawing.Point(95, 106);
            this.logoSubtext.Name = "logoSubtext";
            this.logoSubtext.Size = new System.Drawing.Size(311, 23);
            this.logoSubtext.TabIndex = 1;
            this.logoSubtext.Text = "Trace Code, Help the Realm";
            // 
            // mainMenuLogoPanel
            // 
            this.mainMenuLogoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainMenuLogoPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuLogoPanel.Controls.Add(this.logoSubtext);
            this.mainMenuLogoPanel.Controls.Add(this.mainMenuLogo);
            this.mainMenuLogoPanel.Location = new System.Drawing.Point(292, 56);
            this.mainMenuLogoPanel.Name = "mainMenuLogoPanel";
            this.mainMenuLogoPanel.Size = new System.Drawing.Size(500, 170);
            this.mainMenuLogoPanel.TabIndex = 2;
            // 
            // mainMenuLogo
            // 
            this.mainMenuLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenuLogo.Image = global::Trace_Quest.Properties.Resources.TraceQuestLogo_x5;
            this.mainMenuLogo.Location = new System.Drawing.Point(21, 14);
            this.mainMenuLogo.Name = "mainMenuLogo";
            this.mainMenuLogo.Size = new System.Drawing.Size(459, 97);
            this.mainMenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mainMenuLogo.TabIndex = 0;
            this.mainMenuLogo.TabStop = false;
            // 
            // questPoster01Button
            // 
            this.questPoster01Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questPoster01Button.BackColor = System.Drawing.Color.Transparent;
            this.questPoster01Button.BackgroundImage = global::Trace_Quest.Properties.Resources.AcceptButton_x4;
            this.questPoster01Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.questPoster01Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.questPoster01Button.FlatAppearance.BorderSize = 0;
            this.questPoster01Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.questPoster01Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.questPoster01Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questPoster01Button.Location = new System.Drawing.Point(162, 590);
            this.questPoster01Button.Name = "questPoster01Button";
            this.questPoster01Button.Size = new System.Drawing.Size(132, 67);
            this.questPoster01Button.TabIndex = 6;
            this.questPoster01Button.UseVisualStyleBackColor = false;
            this.questPoster01Button.Click += new System.EventHandler(this.questPoster01Button_Click);
            // 
            // questPoster03
            // 
            this.questPoster03.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questPoster03.BackColor = System.Drawing.Color.Transparent;
            this.questPoster03.Image = global::Trace_Quest.Properties.Resources.Quest_x7;
            this.questPoster03.Location = new System.Drawing.Point(724, 279);
            this.questPoster03.Name = "questPoster03";
            this.questPoster03.Size = new System.Drawing.Size(246, 293);
            this.questPoster03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.questPoster03.TabIndex = 5;
            this.questPoster03.TabStop = false;
            // 
            // questPoster02
            // 
            this.questPoster02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questPoster02.BackColor = System.Drawing.Color.Transparent;
            this.questPoster02.Image = global::Trace_Quest.Properties.Resources.Quest_x7;
            this.questPoster02.Location = new System.Drawing.Point(414, 279);
            this.questPoster02.Name = "questPoster02";
            this.questPoster02.Size = new System.Drawing.Size(246, 293);
            this.questPoster02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.questPoster02.TabIndex = 4;
            this.questPoster02.TabStop = false;
            // 
            // questPoster01
            // 
            this.questPoster01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questPoster01.BackColor = System.Drawing.Color.Transparent;
            this.questPoster01.Image = global::Trace_Quest.Properties.Resources.Quest_x7;
            this.questPoster01.Location = new System.Drawing.Point(115, 279);
            this.questPoster01.Name = "questPoster01";
            this.questPoster01.Size = new System.Drawing.Size(246, 293);
            this.questPoster01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.questPoster01.TabIndex = 3;
            this.questPoster01.TabStop = false;
            // 
            // questPoster02Button
            // 
            this.questPoster02Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questPoster02Button.BackColor = System.Drawing.Color.Transparent;
            this.questPoster02Button.BackgroundImage = global::Trace_Quest.Properties.Resources.AcceptButton_x4;
            this.questPoster02Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.questPoster02Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.questPoster02Button.FlatAppearance.BorderSize = 0;
            this.questPoster02Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.questPoster02Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.questPoster02Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questPoster02Button.Location = new System.Drawing.Point(476, 590);
            this.questPoster02Button.Name = "questPoster02Button";
            this.questPoster02Button.Size = new System.Drawing.Size(132, 67);
            this.questPoster02Button.TabIndex = 7;
            this.questPoster02Button.UseVisualStyleBackColor = false;
            this.questPoster02Button.Click += new System.EventHandler(this.questPoster02Button_Click);
            // 
            // questPoster03Button
            // 
            this.questPoster03Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questPoster03Button.BackColor = System.Drawing.Color.Transparent;
            this.questPoster03Button.BackgroundImage = global::Trace_Quest.Properties.Resources.AcceptButton_x4;
            this.questPoster03Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.questPoster03Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.questPoster03Button.FlatAppearance.BorderSize = 0;
            this.questPoster03Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.questPoster03Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.questPoster03Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questPoster03Button.Location = new System.Drawing.Point(789, 590);
            this.questPoster03Button.Name = "questPoster03Button";
            this.questPoster03Button.Size = new System.Drawing.Size(132, 67);
            this.questPoster03Button.TabIndex = 8;
            this.questPoster03Button.UseVisualStyleBackColor = false;
            this.questPoster03Button.Click += new System.EventHandler(this.questPoster03Button_Click);
            // 
            // questPoster01Label
            // 
            this.questPoster01Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questPoster01Label.AutoSize = true;
            this.questPoster01Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(210)))));
            this.questPoster01Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questPoster01Label.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questPoster01Label.Location = new System.Drawing.Point(160, 372);
            this.questPoster01Label.Name = "questPoster01Label";
            this.questPoster01Label.Size = new System.Drawing.Size(155, 162);
            this.questPoster01Label.TabIndex = 9;
            this.questPoster01Label.Text = "DEMON HUNTING\r\n\r\nA demon has been\r\ntrolling the nearby\r\nvillage of Scala Springs." +
    "\r\nTo banish it, you must\r\nknow its name.\r\n\r\nReward: 900 gold coins";
            this.questPoster01Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // questPoster02Label
            // 
            this.questPoster02Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questPoster02Label.AutoSize = true;
            this.questPoster02Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(210)))));
            this.questPoster02Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questPoster02Label.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questPoster02Label.Location = new System.Drawing.Point(457, 373);
            this.questPoster02Label.Name = "questPoster02Label";
            this.questPoster02Label.Size = new System.Drawing.Size(160, 162);
            this.questPoster02Label.TabIndex = 10;
            this.questPoster02Label.Text = "ARCHEOLOGY\r\n\r\nAn ancient vault\r\nwith valuable knowledge\r\ncan only be opened\r\nwith" +
    " a riddle. Accept\r\nquest if interested.\r\n\r\nReward: 100 gold coins";
            this.questPoster02Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // questPoster03Label
            // 
            this.questPoster03Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questPoster03Label.AutoSize = true;
            this.questPoster03Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(210)))));
            this.questPoster03Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questPoster03Label.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questPoster03Label.Location = new System.Drawing.Point(758, 371);
            this.questPoster03Label.Name = "questPoster03Label";
            this.questPoster03Label.Size = new System.Drawing.Size(179, 162);
            this.questPoster03Label.TabIndex = 11;
            this.questPoster03Label.Text = "WANTED THIEF\r\n\r\nRobin Dabank, infamous\r\nshadow thief.\r\nWarning: has mindbreaking\r" +
    "\nabilities, apprehend with\r\ncaution!\r\n\r\nReward: 500 gold coins";
            this.questPoster03Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainGUIParentPanel
            // 
            this.mainGUIParentPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainGUIParentPanel.Controls.Add(this.questPoster03Label);
            this.mainGUIParentPanel.Controls.Add(this.questPoster02Label);
            this.mainGUIParentPanel.Controls.Add(this.questPoster01Label);
            this.mainGUIParentPanel.Controls.Add(this.questPoster03Button);
            this.mainGUIParentPanel.Controls.Add(this.questPoster02Button);
            this.mainGUIParentPanel.Controls.Add(this.questPoster01Button);
            this.mainGUIParentPanel.Controls.Add(this.questPoster03);
            this.mainGUIParentPanel.Controls.Add(this.questPoster02);
            this.mainGUIParentPanel.Controls.Add(this.questPoster01);
            this.mainGUIParentPanel.Controls.Add(this.mainMenuLogoPanel);
            this.mainGUIParentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGUIParentPanel.Location = new System.Drawing.Point(0, 0);
            this.mainGUIParentPanel.Name = "mainGUIParentPanel";
            this.mainGUIParentPanel.Size = new System.Drawing.Size(1084, 701);
            this.mainGUIParentPanel.TabIndex = 12;
            // 
            // MainMenuGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Trace_Quest.Properties.Resources.Wooden_Wall_Dark_Wide;
            this.ClientSize = new System.Drawing.Size(1084, 701);
            this.Controls.Add(this.mainGUIParentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenuGUI";
            this.Text = "Trace Quest";
            this.mainMenuLogoPanel.ResumeLayout(false);
            this.mainMenuLogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questPoster03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questPoster02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questPoster01)).EndInit();
            this.mainGUIParentPanel.ResumeLayout(false);
            this.mainGUIParentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox mainMenuLogo;
        private System.Windows.Forms.Label logoSubtext;
        private System.Windows.Forms.Panel mainMenuLogoPanel;
        private System.Windows.Forms.PictureBox questPoster01;
        private System.Windows.Forms.PictureBox questPoster02;
        private System.Windows.Forms.PictureBox questPoster03;
        private System.Windows.Forms.Button questPoster01Button;
        private System.Windows.Forms.Button questPoster02Button;
        private System.Windows.Forms.Button questPoster03Button;
        private System.Windows.Forms.Label questPoster01Label;
        private System.Windows.Forms.Label questPoster02Label;
        private System.Windows.Forms.Label questPoster03Label;
        private System.Windows.Forms.Panel mainGUIParentPanel;
    }
}

