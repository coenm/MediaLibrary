﻿namespace MediaLibrary
{
    partial class SlideShowForm
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.previousButton = new System.Windows.Forms.ToolStripButton();
            this.playPauseButton = new System.Windows.Forms.ToolStripButton();
            this.nextButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.preview = new MediaLibrary.PreviewControl();
            this.shuffleButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previousButton,
            this.playPauseButton,
            this.nextButton,
            this.toolStripSeparator2,
            this.shuffleButton,
            this.toolStripSeparator1,
            this.toolStripButton6});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // previousButton
            // 
            this.previousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.previousButton.Image = global::MediaLibrary.Properties.Resources.controls_previous;
            this.previousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(23, 22);
            this.previousButton.Text = "Previous";
            this.previousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // playPauseButton
            // 
            this.playPauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playPauseButton.Image = global::MediaLibrary.Properties.Resources.controls_play;
            this.playPauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(23, 22);
            this.playPauseButton.Text = "Play";
            this.playPauseButton.Click += new System.EventHandler(this.PlayPauseButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextButton.Image = global::MediaLibrary.Properties.Resources.controls_next;
            this.nextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(23, 22);
            this.nextButton.Text = "Next";
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::MediaLibrary.Properties.Resources.expand_full;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // preview
            // 
            this.preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview.Location = new System.Drawing.Point(0, 25);
            this.preview.Name = "preview";
            this.preview.PreviewItem = null;
            this.preview.Size = new System.Drawing.Size(800, 425);
            this.preview.TabIndex = 0;
            // 
            // shuffleButton
            // 
            this.shuffleButton.CheckOnClick = true;
            this.shuffleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shuffleButton.Image = global::MediaLibrary.Properties.Resources.button_shuffle;
            this.shuffleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(23, 22);
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.CheckedChanged += new System.EventHandler(this.ShuffleButton_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SlideShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.toolStrip);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SlideShowForm";
            this.ShowIcon = false;
            this.Text = "Slide Show";
            this.Click += new System.EventHandler(this.PlayPauseButton_Click);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SlideShowForm_PreviewKeyDown);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PreviewControl preview;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton previousButton;
        private System.Windows.Forms.ToolStripButton playPauseButton;
        private System.Windows.Forms.ToolStripButton nextButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton shuffleButton;
    }
}