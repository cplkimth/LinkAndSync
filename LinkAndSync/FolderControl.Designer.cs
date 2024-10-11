namespace LinkAndSync.Gui
{
    partial class FolderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txbBrowse = new TextBox();
            btnBrowse = new Button();
            fbdBrowse = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // txbBrowse
            // 
            txbBrowse.AllowDrop = true;
            txbBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbBrowse.Location = new Point(3, 3);
            txbBrowse.Name = "txbBrowse";
            txbBrowse.ReadOnly = true;
            txbBrowse.Size = new Size(505, 23);
            txbBrowse.TabIndex = 0;
            txbBrowse.DragDrop += txbBrowse_DragDrop;
            txbBrowse.DragEnter += txbBrowse_DragEnter;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowse.Location = new Point(514, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "&Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // FolderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBrowse);
            Controls.Add(txbBrowse);
            Name = "FolderControl";
            Size = new Size(592, 33);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbBrowse;
        private Button btnBrowse;
        private FolderBrowserDialog fbdBrowse;
    }
}
