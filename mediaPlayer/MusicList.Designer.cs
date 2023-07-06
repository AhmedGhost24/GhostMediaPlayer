namespace mediaPlayer
{
    partial class MusicList
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Music_Lest = new System.Windows.Forms.ListBox();
            this.OpenFille = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.pictureBox1.Location = new System.Drawing.Point(676, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 618);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Music_Lest
            // 
            this.Music_Lest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Music_Lest.BackColor = System.Drawing.Color.Black;
            this.Music_Lest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Music_Lest.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Music_Lest.FormattingEnabled = true;
            this.Music_Lest.ItemHeight = 15;
            this.Music_Lest.Location = new System.Drawing.Point(12, 12);
            this.Music_Lest.Name = "Music_Lest";
            this.Music_Lest.Size = new System.Drawing.Size(646, 589);
            this.Music_Lest.TabIndex = 1;
            this.Music_Lest.SelectedIndexChanged += new System.EventHandler(this.Music_Lest_SelectedIndexChanged);
            // 
            // OpenFille
            // 
            this.OpenFille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFille.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.OpenFille.Location = new System.Drawing.Point(690, 77);
            this.OpenFille.Name = "OpenFille";
            this.OpenFille.Size = new System.Drawing.Size(115, 42);
            this.OpenFille.TabIndex = 2;
            this.OpenFille.Text = "Open";
            this.OpenFille.UseVisualStyleBackColor = true;
            this.OpenFille.Click += new System.EventHandler(this.OpenFille_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(690, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open player MP3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(817, 618);
            this.panelChildForm.TabIndex = 3;
            // 
            // MusicList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(817, 616);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OpenFille);
            this.Controls.Add(this.Music_Lest);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelChildForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicList";
            this.Text = "MusicList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox Music_Lest;
        private System.Windows.Forms.Button OpenFille;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelChildForm;
    }
}