namespace LinkAndSync.Gui
{
    partial class MainForm
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
            uscSource = new FolderControl();
            uscLink = new FolderControl();
            btnGo = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            bgwWorker = new System.ComponentModel.BackgroundWorker();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            prbProgress = new ToolStripProgressBar();
            tableLayoutPanel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // uscSource
            // 
            uscSource.Dock = DockStyle.Fill;
            uscSource.Location = new Point(3, 3);
            uscSource.Name = "uscSource";
            uscSource.Path = "";
            uscSource.Size = new Size(607, 31);
            uscSource.TabIndex = 0;
            // 
            // uscLink
            // 
            uscLink.Dock = DockStyle.Fill;
            uscLink.Location = new Point(686, 3);
            uscLink.Name = "uscLink";
            uscLink.Path = "";
            uscLink.Size = new Size(607, 31);
            uscLink.TabIndex = 1;
            // 
            // btnGo
            // 
            btnGo.Dock = DockStyle.Fill;
            btnGo.Location = new Point(616, 3);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(64, 31);
            btnGo.TabIndex = 2;
            btnGo.Text = "=>";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(uscSource, 0, 0);
            tableLayoutPanel1.Controls.Add(btnGo, 1, 0);
            tableLayoutPanel1.Controls.Add(uscLink, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1296, 57);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // bgwWorker
            // 
            bgwWorker.WorkerReportsProgress = true;
            bgwWorker.DoWork += bgwWorker_DoWork;
            bgwWorker.ProgressChanged += bgwWorker_ProgressChanged;
            bgwWorker.RunWorkerCompleted += bgwWorker_RunWorkerCompleted;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { prbProgress, lblStatus });
            statusStrip1.Location = new Point(0, 35);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1296, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 17);
            // 
            // prbProgress
            // 
            prbProgress.Name = "prbProgress";
            prbProgress.Size = new Size(100, 16);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 57);
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            Text = "Linc&Sync";
            tableLayoutPanel1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderControl uscSource;
        private FolderControl uscLink;
        private Button btnGo;
        private TableLayoutPanel tableLayoutPanel1;
        private System.ComponentModel.BackgroundWorker bgwWorker;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar prbProgress;
        private ToolStripStatusLabel lblStatus;
    }
}
