namespace NotepadCSharp
{
    partial class Blank
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.sbAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbWords = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sbKoma = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbVoskl = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbVopr = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbLiter = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbAbsac = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbProportinal = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbAmount,
            this.sbSpace,
            this.sbWords,
            this.sbKoma,
            this.sbVoskl,
            this.sbVopr,
            this.sbLiter,
            this.sbAbsac,
            this.sbProportinal,
            this.sbTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 442);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(525, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // sbAmount
            // 
            this.sbAmount.Name = "sbAmount";
            this.sbAmount.Size = new System.Drawing.Size(0, 17);
            // 
            // sbSpace
            // 
            this.sbSpace.Name = "sbSpace";
            this.sbSpace.Size = new System.Drawing.Size(0, 17);
            // 
            // sbWords
            // 
            this.sbWords.Name = "sbWords";
            this.sbWords.Size = new System.Drawing.Size(0, 17);
            // 
            // sbTime
            // 
            this.sbTime.Name = "sbTime";
            this.sbTime.Size = new System.Drawing.Size(0, 17);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(525, 442);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress_1);
            this.richTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyUp);
            // 
            // sbKoma
            // 
            this.sbKoma.Name = "sbKoma";
            this.sbKoma.Size = new System.Drawing.Size(0, 17);
            // 
            // sbVoskl
            // 
            this.sbVoskl.Name = "sbVoskl";
            this.sbVoskl.Size = new System.Drawing.Size(0, 17);
            // 
            // sbVopr
            // 
            this.sbVopr.Name = "sbVopr";
            this.sbVopr.Size = new System.Drawing.Size(0, 17);
            // 
            // sbLiter
            // 
            this.sbLiter.Name = "sbLiter";
            this.sbLiter.Size = new System.Drawing.Size(0, 17);
            // 
            // sbAbsac
            // 
            this.sbAbsac.Name = "sbAbsac";
            this.sbAbsac.Size = new System.Drawing.Size(0, 17);
            // 
            // sbProportinal
            // 
            this.sbProportinal.Name = "sbProportinal";
            this.sbProportinal.Size = new System.Drawing.Size(0, 17);
            // 
            // Blank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 464);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip);
            this.Name = "Blank";
            this.Text = "Blank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Blank_FormClosing);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel sbAmount;
        private System.Windows.Forms.ToolStripStatusLabel sbTime;
        private System.Windows.Forms.ToolStripStatusLabel sbSpace;
        private System.Windows.Forms.ToolStripStatusLabel sbWords;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripStatusLabel sbKoma;
        private System.Windows.Forms.ToolStripStatusLabel sbVoskl;
        private System.Windows.Forms.ToolStripStatusLabel sbVopr;
        private System.Windows.Forms.ToolStripStatusLabel sbLiter;
        private System.Windows.Forms.ToolStripStatusLabel sbAbsac;
        private System.Windows.Forms.ToolStripStatusLabel sbProportinal;
    }
}