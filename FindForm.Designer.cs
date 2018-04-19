namespace NotepadCSharp
{
    partial class FindForm
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
            this.txtFind = new System.Windows.Forms.TextBox();
            this.cbMatchCase = new System.Windows.Forms.CheckBox();
            this.cbMatchWhole = new System.Windows.Forms.CheckBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(12, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(211, 20);
            this.txtFind.TabIndex = 0;
            // 
            // cbMatchCase
            // 
            this.cbMatchCase.Location = new System.Drawing.Point(12, 44);
            this.cbMatchCase.Name = "cbMatchCase";
            this.cbMatchCase.Size = new System.Drawing.Size(116, 47);
            this.cbMatchCase.TabIndex = 1;
            this.cbMatchCase.Text = "Поиск текста с учетом регистра";
            this.cbMatchCase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbMatchCase.UseVisualStyleBackColor = true;
            // 
            // cbMatchWhole
            // 
            this.cbMatchWhole.Location = new System.Drawing.Point(134, 51);
            this.cbMatchWhole.Name = "cbMatchWhole";
            this.cbMatchWhole.Size = new System.Drawing.Size(89, 32);
            this.cbMatchWhole.TabIndex = 2;
            this.cbMatchWhole.Text = "Поиск всего слова";
            this.cbMatchWhole.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(235, 10);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "Ok";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(235, 53);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 99);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.cbMatchWhole);
            this.Controls.Add(this.cbMatchCase);
            this.Controls.Add(this.txtFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindForm";
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.CheckBox cbMatchCase;
        private System.Windows.Forms.CheckBox cbMatchWhole;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
    }
}