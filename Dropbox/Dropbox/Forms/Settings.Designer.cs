namespace Dropbox.Forms
{
    partial class Settings
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
            this.settingsLabel = new System.Windows.Forms.Label();
            this.musicSettings = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.difficultySettings = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.difficultyBox = new System.Windows.Forms.TextBox();
            this.minWidthBox = new System.Windows.Forms.TextBox();
            this.maxWidthBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.musicSettings.SuspendLayout();
            this.difficultySettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.ForeColor = System.Drawing.Color.Snow;
            this.settingsLabel.Location = new System.Drawing.Point(0, 0);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(113, 31);
            this.settingsLabel.TabIndex = 0;
            this.settingsLabel.Text = "Settings";
            // 
            // musicSettings
            // 
            this.musicSettings.Controls.Add(this.checkBox2);
            this.musicSettings.Controls.Add(this.checkBox1);
            this.musicSettings.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicSettings.ForeColor = System.Drawing.Color.White;
            this.musicSettings.Location = new System.Drawing.Point(12, 239);
            this.musicSettings.Name = "musicSettings";
            this.musicSettings.Size = new System.Drawing.Size(175, 112);
            this.musicSettings.TabIndex = 2;
            this.musicSettings.TabStop = false;
            this.musicSettings.Text = "Music";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(6, 67);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 24);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Shuffle";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(6, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Enabled";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // difficultySettings
            // 
            this.difficultySettings.Controls.Add(this.label3);
            this.difficultySettings.Controls.Add(this.label2);
            this.difficultySettings.Controls.Add(this.label1);
            this.difficultySettings.Controls.Add(this.difficultyBox);
            this.difficultySettings.Controls.Add(this.minWidthBox);
            this.difficultySettings.Controls.Add(this.maxWidthBox);
            this.difficultySettings.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultySettings.ForeColor = System.Drawing.Color.Snow;
            this.difficultySettings.Location = new System.Drawing.Point(6, 56);
            this.difficultySettings.Name = "difficultySettings";
            this.difficultySettings.Size = new System.Drawing.Size(294, 177);
            this.difficultySettings.TabIndex = 3;
            this.difficultySettings.TabStop = false;
            this.difficultySettings.Text = "Difficulty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Starting Speed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Min Length:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max Length:";
            // 
            // difficultyBox
            // 
            this.difficultyBox.Location = new System.Drawing.Point(146, 125);
            this.difficultyBox.MaxLength = 2;
            this.difficultyBox.Name = "difficultyBox";
            this.difficultyBox.Size = new System.Drawing.Size(50, 38);
            this.difficultyBox.TabIndex = 0;
            this.difficultyBox.TextChanged += new System.EventHandler(this.difficultyBox_TextChanged);
            // 
            // minWidthBox
            // 
            this.minWidthBox.Location = new System.Drawing.Point(114, 81);
            this.minWidthBox.MaxLength = 3;
            this.minWidthBox.Name = "minWidthBox";
            this.minWidthBox.Size = new System.Drawing.Size(100, 38);
            this.minWidthBox.TabIndex = 0;
            this.minWidthBox.TextChanged += new System.EventHandler(this.minWidthBox_TextChanged);
            // 
            // maxWidthBox
            // 
            this.maxWidthBox.Location = new System.Drawing.Point(114, 37);
            this.maxWidthBox.Name = "maxWidthBox";
            this.maxWidthBox.Size = new System.Drawing.Size(100, 38);
            this.maxWidthBox.TabIndex = 0;
            this.maxWidthBox.TextChanged += new System.EventHandler(this.maxWidthBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameInput);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(6, 37);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(188, 38);
            this.nameInput.TabIndex = 0;
            this.nameInput.Text = "User";
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(214, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 91);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Theme";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Water",
            "Space"});
            this.comboBox1.Location = new System.Drawing.Point(7, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 39);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "None";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(400, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.difficultySettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.musicSettings);
            this.Controls.Add(this.settingsLabel);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.musicSettings.ResumeLayout(false);
            this.musicSettings.PerformLayout();
            this.difficultySettings.ResumeLayout(false);
            this.difficultySettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.GroupBox musicSettings;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox difficultySettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minWidthBox;
        private System.Windows.Forms.TextBox maxWidthBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox difficultyBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}