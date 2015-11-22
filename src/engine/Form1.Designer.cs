namespace Snake_and_Ladder
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
            this.Player1Name = new System.Windows.Forms.TextBox();
            this.Player2Name = new System.Windows.Forms.TextBox();
            this.Play = new System.Windows.Forms.Button();
            this.Aboutus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Player1Name
            // 
            this.Player1Name.Location = new System.Drawing.Point(593, 599);
            this.Player1Name.Margin = new System.Windows.Forms.Padding(4);
            this.Player1Name.Multiline = true;
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(325, 42);
            this.Player1Name.TabIndex = 2;
            // 
            // Player2Name
            // 
            this.Player2Name.Location = new System.Drawing.Point(593, 678);
            this.Player2Name.Margin = new System.Windows.Forms.Padding(4);
            this.Player2Name.Multiline = true;
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(325, 42);
            this.Player2Name.TabIndex = 3;
            // 
            // Play
            // 
            this.Play.Image = ((System.Drawing.Image)(resources.GetObject("Play.Image")));
            this.Play.Location = new System.Drawing.Point(348, 502);
            this.Play.Margin = new System.Windows.Forms.Padding(4);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(290, 56);
            this.Play.TabIndex = 5;
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Aboutus
            // 
            this.Aboutus.Image = ((System.Drawing.Image)(resources.GetObject("Aboutus.Image")));
            this.Aboutus.Location = new System.Drawing.Point(667, 504);
            this.Aboutus.Margin = new System.Windows.Forms.Padding(4);
            this.Aboutus.Name = "Aboutus";
            this.Aboutus.Size = new System.Drawing.Size(260, 53);
            this.Aboutus.TabIndex = 6;
            this.Aboutus.UseVisualStyleBackColor = true;
            this.Aboutus.Click += new System.EventHandler(this.Aboutus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Snake_and_Ladder.Properties.Resources.unnamed1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1300, 733);
            this.Controls.Add(this.Aboutus);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.Player1Name);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Snake And Ladder Revisited";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox Player1Name;
        public System.Windows.Forms.TextBox Player2Name;
        public System.Windows.Forms.Button Play;
        public System.Windows.Forms.Button Aboutus;
        public System.Windows.Forms.PictureBox home;
    }
}

