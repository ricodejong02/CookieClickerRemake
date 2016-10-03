namespace Kaziklikker {
    partial class Wiki {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wiki));
            this.navigationWindow = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.Level = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // navigationWindow
            // 
            this.navigationWindow.BackColor = System.Drawing.Color.Ivory;
            this.navigationWindow.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationWindow.FormattingEnabled = true;
            this.navigationWindow.ItemHeight = 18;
            this.navigationWindow.Items.AddRange(new object[] {
            "Home",
            "The Basics",
            "The Shop",
            "The Upgrades",
            "The Lottery",
            "The Bank",
            "Experience",
            "List of large numbers",
            "Cheats",
            "Changelog",
            "Credits"});
            this.navigationWindow.Location = new System.Drawing.Point(12, 12);
            this.navigationWindow.Name = "navigationWindow";
            this.navigationWindow.Size = new System.Drawing.Size(146, 418);
            this.navigationWindow.TabIndex = 0;
            this.navigationWindow.SelectedIndexChanged += new System.EventHandler(this.navigationWindow_SelectedIndexChanged);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.Ivory;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(163, 40);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(330, 395);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "Welcome to the wiki, the place to learn! to navigate to a page, just click on one" +
    " of the pages on the left.\n";
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.Ivory;
            this.titleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(164, 12);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(277, 31);
            this.titleBox.TabIndex = 2;
            this.titleBox.Text = "Home";
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.BackColor = System.Drawing.Color.White;
            this.Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level.Location = new System.Drawing.Point(447, 16);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(16, 20);
            this.Level.TabIndex = 3;
            this.Level.Text = "*";
            // 
            // Wiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::Kaziklikker.Properties.Resources.WikiMenu;
            this.ClientSize = new System.Drawing.Size(508, 448);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.navigationWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Wiki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wiki";
            this.Load += new System.EventHandler(this.Wiki_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox navigationWindow;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label Level;
    }
}