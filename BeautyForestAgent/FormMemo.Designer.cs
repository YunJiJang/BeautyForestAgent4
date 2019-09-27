namespace BeautyForestAgent
{
    partial class FormMemo
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
            this.Status = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRead = new System.Windows.Forms.TabPage();
            this.tpWrite = new System.Windows.Forms.TabPage();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.loadFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.txtLoadFile = new System.Windows.Forms.TextBox();
            this.txtLoadText = new System.Windows.Forms.TextBox();
            this.btnLoadFileSelect = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnSaveFileSelect = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.txtSaveFile = new System.Windows.Forms.TextBox();
            this.txtSaveText = new System.Windows.Forms.TextBox();
            this.Status.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpRead.SuspendLayout();
            this.tpWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.Status.Location = new System.Drawing.Point(0, 288);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(431, 22);
            this.Status.SizingGrip = false;
            this.Status.TabIndex = 0;
            this.Status.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRead);
            this.tabControl1.Controls.Add(this.tpWrite);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(431, 288);
            this.tabControl1.TabIndex = 1;
            // 
            // tpRead
            // 
            this.tpRead.Controls.Add(this.btnLoadFile);
            this.tpRead.Controls.Add(this.btnLoadFileSelect);
            this.tpRead.Controls.Add(this.txtLoadText);
            this.tpRead.Controls.Add(this.txtLoadFile);
            this.tpRead.Location = new System.Drawing.Point(4, 22);
            this.tpRead.Name = "tpRead";
            this.tpRead.Padding = new System.Windows.Forms.Padding(3);
            this.tpRead.Size = new System.Drawing.Size(423, 262);
            this.tpRead.TabIndex = 0;
            this.tpRead.Text = "파일 읽기";
            this.tpRead.UseVisualStyleBackColor = true;
            // 
            // tpWrite
            // 
            this.tpWrite.Controls.Add(this.txtSaveText);
            this.tpWrite.Controls.Add(this.txtSaveFile);
            this.tpWrite.Controls.Add(this.btnSaveFile);
            this.tpWrite.Controls.Add(this.btnSaveFileSelect);
            this.tpWrite.Location = new System.Drawing.Point(4, 22);
            this.tpWrite.Name = "tpWrite";
            this.tpWrite.Padding = new System.Windows.Forms.Padding(3);
            this.tpWrite.Size = new System.Drawing.Size(423, 262);
            this.tpWrite.TabIndex = 1;
            this.tpWrite.Text = "파일 쓰기";
            this.tpWrite.UseVisualStyleBackColor = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(168, 17);
            this.toolStripStatusLabel1.Text = "3116 장윤지 - 파일 읽고 쓰기";
            // 
            // loadFileDlg
            // 
            this.loadFileDlg.FileName = "openFileDialog1";
            this.loadFileDlg.Filter = "텍스트 파일(*.txt)|*.txt|모든파일 (*.*)|*.*";
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.Filter = "텍스트 파일(*.txt)|*.txt";
            // 
            // txtLoadFile
            // 
            this.txtLoadFile.Location = new System.Drawing.Point(6, 6);
            this.txtLoadFile.Name = "txtLoadFile";
            this.txtLoadFile.ReadOnly = true;
            this.txtLoadFile.Size = new System.Drawing.Size(251, 21);
            this.txtLoadFile.TabIndex = 0;
            // 
            // txtLoadText
            // 
            this.txtLoadText.Location = new System.Drawing.Point(6, 33);
            this.txtLoadText.Multiline = true;
            this.txtLoadText.Name = "txtLoadText";
            this.txtLoadText.ReadOnly = true;
            this.txtLoadText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLoadText.Size = new System.Drawing.Size(413, 223);
            this.txtLoadText.TabIndex = 1;
            // 
            // btnLoadFileSelect
            // 
            this.btnLoadFileSelect.Location = new System.Drawing.Point(263, 6);
            this.btnLoadFileSelect.Name = "btnLoadFileSelect";
            this.btnLoadFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFileSelect.TabIndex = 2;
            this.btnLoadFileSelect.Text = "파일 선택";
            this.btnLoadFileSelect.UseVisualStyleBackColor = true;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(344, 6);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 3;
            this.btnLoadFile.Text = "불러오기";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            // 
            // btnSaveFileSelect
            // 
            this.btnSaveFileSelect.Location = new System.Drawing.Point(259, 7);
            this.btnSaveFileSelect.Name = "btnSaveFileSelect";
            this.btnSaveFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFileSelect.TabIndex = 0;
            this.btnSaveFileSelect.Text = "파일 선택";
            this.btnSaveFileSelect.UseVisualStyleBackColor = true;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(340, 7);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 1;
            this.btnSaveFile.Text = "저장하기";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // txtSaveFile
            // 
            this.txtSaveFile.Location = new System.Drawing.Point(9, 7);
            this.txtSaveFile.Name = "txtSaveFile";
            this.txtSaveFile.ReadOnly = true;
            this.txtSaveFile.Size = new System.Drawing.Size(244, 21);
            this.txtSaveFile.TabIndex = 2;
            // 
            // txtSaveText
            // 
            this.txtSaveText.Location = new System.Drawing.Point(9, 34);
            this.txtSaveText.Multiline = true;
            this.txtSaveText.Name = "txtSaveText";
            this.txtSaveText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSaveText.Size = new System.Drawing.Size(406, 222);
            this.txtSaveText.TabIndex = 3;
            // 
            // FormMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 310);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMemo";
            this.Text = "FormMemo";
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpRead.ResumeLayout(false);
            this.tpRead.PerformLayout();
            this.tpWrite.ResumeLayout(false);
            this.tpWrite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRead;
        private System.Windows.Forms.TabPage tpWrite;
        private System.Windows.Forms.OpenFileDialog loadFileDlg;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.TextBox txtLoadText;
        private System.Windows.Forms.TextBox txtLoadFile;
        private System.Windows.Forms.Button btnLoadFileSelect;
        private System.Windows.Forms.TextBox txtSaveText;
        private System.Windows.Forms.TextBox txtSaveFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnSaveFileSelect;
    }
}