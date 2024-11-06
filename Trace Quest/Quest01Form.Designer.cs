namespace Trace_Quest {
    partial class Quest01Form {
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
            this.ct01AnswerField = new System.Windows.Forms.PictureBox();
            this.textbox01Skin = new System.Windows.Forms.PictureBox();
            this.codeTracing01 = new System.Windows.Forms.PictureBox();
            this.codeTracing01TextBox = new System.Windows.Forms.TextBox();
            this.ct01AnswerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ct01AnswerField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textbox01Skin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTracing01)).BeginInit();
            this.SuspendLayout();
            // 
            // ct01AnswerField
            // 
            this.ct01AnswerField.BackColor = System.Drawing.Color.Transparent;
            this.ct01AnswerField.Image = global::Trace_Quest.Properties.Resources.Vertical_Answer_Poster;
            this.ct01AnswerField.Location = new System.Drawing.Point(553, 356);
            this.ct01AnswerField.Name = "ct01AnswerField";
            this.ct01AnswerField.Size = new System.Drawing.Size(238, 280);
            this.ct01AnswerField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ct01AnswerField.TabIndex = 3;
            this.ct01AnswerField.TabStop = false;
            // 
            // textbox01Skin
            // 
            this.textbox01Skin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(210)))));
            this.textbox01Skin.Image = global::Trace_Quest.Properties.Resources.Textbox_Skin_128;
            this.textbox01Skin.Location = new System.Drawing.Point(601, 389);
            this.textbox01Skin.Name = "textbox01Skin";
            this.textbox01Skin.Size = new System.Drawing.Size(142, 68);
            this.textbox01Skin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.textbox01Skin.TabIndex = 2;
            this.textbox01Skin.TabStop = false;
            // 
            // codeTracing01
            // 
            this.codeTracing01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeTracing01.Image = global::Trace_Quest.Properties.Resources.Demon_Hunting_Quest;
            this.codeTracing01.Location = new System.Drawing.Point(23, 356);
            this.codeTracing01.Name = "codeTracing01";
            this.codeTracing01.Size = new System.Drawing.Size(507, 313);
            this.codeTracing01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.codeTracing01.TabIndex = 0;
            this.codeTracing01.TabStop = false;
            // 
            // codeTracing01TextBox
            // 
            this.codeTracing01TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeTracing01TextBox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTracing01TextBox.Location = new System.Drawing.Point(613, 412);
            this.codeTracing01TextBox.Name = "codeTracing01TextBox";
            this.codeTracing01TextBox.Size = new System.Drawing.Size(118, 23);
            this.codeTracing01TextBox.TabIndex = 1;
            // 
            // ct01AnswerButton
            // 
            this.ct01AnswerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(210)))));
            this.ct01AnswerButton.BackgroundImage = global::Trace_Quest.Properties.Resources.GO_Button_128;
            this.ct01AnswerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ct01AnswerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ct01AnswerButton.FlatAppearance.BorderSize = 0;
            this.ct01AnswerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(210)))));
            this.ct01AnswerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(210)))));
            this.ct01AnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ct01AnswerButton.Location = new System.Drawing.Point(604, 480);
            this.ct01AnswerButton.Name = "ct01AnswerButton";
            this.ct01AnswerButton.Size = new System.Drawing.Size(132, 68);
            this.ct01AnswerButton.TabIndex = 4;
            this.ct01AnswerButton.UseVisualStyleBackColor = false;
            this.ct01AnswerButton.Click += new System.EventHandler(this.ct01AnswerButton_Click);
            // 
            // Quest01Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trace_Quest.Properties.Resources.Dungeon_wall_Dark1;
            this.ClientSize = new System.Drawing.Size(814, 701);
            this.Controls.Add(this.ct01AnswerButton);
            this.Controls.Add(this.codeTracing01TextBox);
            this.Controls.Add(this.codeTracing01);
            this.Controls.Add(this.textbox01Skin);
            this.Controls.Add(this.ct01AnswerField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Quest01Form";
            this.Text = "DEMON HUNTING QUEST";
            ((System.ComponentModel.ISupportInitialize)(this.ct01AnswerField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textbox01Skin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTracing01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ct01AnswerField;
        private System.Windows.Forms.PictureBox textbox01Skin;
        private System.Windows.Forms.PictureBox codeTracing01;
        private System.Windows.Forms.TextBox codeTracing01TextBox;
        private System.Windows.Forms.Button ct01AnswerButton;
    }
}