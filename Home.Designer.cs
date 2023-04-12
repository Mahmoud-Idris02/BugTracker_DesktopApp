namespace BugTracker
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.View_Bug = new System.Windows.Forms.Button();
            this.Add_Bug = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.View_Bug);
            this.panel1.Controls.Add(this.Add_Bug);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(21, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 365);
            this.panel1.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(533, 253);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(101, 91);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // View_Bug
            // 
            this.View_Bug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("View_Bug.BackgroundImage")));
            this.View_Bug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.View_Bug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.View_Bug.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.View_Bug.ForeColor = System.Drawing.Color.Black;
            this.View_Bug.Location = new System.Drawing.Point(298, 153);
            this.View_Bug.Name = "View_Bug";
            this.View_Bug.Size = new System.Drawing.Size(184, 158);
            this.View_Bug.TabIndex = 1;
            this.View_Bug.Text = "View Bug";
            this.View_Bug.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.View_Bug.UseVisualStyleBackColor = true;
            this.View_Bug.Click += new System.EventHandler(this.View_Bug_Click);
            // 
            // Add_Bug
            // 
            this.Add_Bug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_Bug.BackgroundImage")));
            this.Add_Bug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_Bug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Bug.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Add_Bug.ForeColor = System.Drawing.Color.Black;
            this.Add_Bug.Location = new System.Drawing.Point(54, 36);
            this.Add_Bug.Name = "Add_Bug";
            this.Add_Bug.Size = new System.Drawing.Size(213, 222);
            this.Add_Bug.TabIndex = 0;
            this.Add_Bug.Text = "Add Bug";
            this.Add_Bug.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Add_Bug.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Add_Bug.UseVisualStyleBackColor = true;
            this.Add_Bug.Click += new System.EventHandler(this.Add_Bug_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(45, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "BUG_It";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(21, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 45);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 41);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(825, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button Exit;
        private Button View_Bug;
        private Button Add_Bug;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}