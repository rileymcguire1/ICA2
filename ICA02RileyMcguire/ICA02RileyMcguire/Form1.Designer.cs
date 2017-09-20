namespace ICA02RileyMcguire
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
            this._btnOpenFile = new System.Windows.Forms.Button();
            this._btnSaveFile = new System.Windows.Forms.Button();
            this._txtbox1 = new System.Windows.Forms.TextBox();
            this._dialOpen = new System.Windows.Forms.OpenFileDialog();
            this._dialSave = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // _btnOpenFile
            // 
            this._btnOpenFile.Location = new System.Drawing.Point(13, 13);
            this._btnOpenFile.Name = "_btnOpenFile";
            this._btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this._btnOpenFile.TabIndex = 0;
            this._btnOpenFile.Text = "Open File";
            this._btnOpenFile.UseVisualStyleBackColor = true;
            this._btnOpenFile.Click += new System.EventHandler(this._btnOpenFile_Click);
            // 
            // _btnSaveFile
            // 
            this._btnSaveFile.Location = new System.Drawing.Point(13, 43);
            this._btnSaveFile.Name = "_btnSaveFile";
            this._btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this._btnSaveFile.TabIndex = 1;
            this._btnSaveFile.Text = "Save File";
            this._btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // _txtbox1
            // 
            this._txtbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtbox1.Location = new System.Drawing.Point(124, 15);
            this._txtbox1.Multiline = true;
            this._txtbox1.Name = "_txtbox1";
            this._txtbox1.Size = new System.Drawing.Size(209, 239);
            this._txtbox1.TabIndex = 2;
            this._txtbox1.TextChanged += new System.EventHandler(this._txtbox1_TextChanged);
            // 
            // _dialOpen
            // 
            this._dialOpen.FileName = "openFileDialog1";
            this._dialOpen.FileOk += new System.ComponentModel.CancelEventHandler(this._dialOpen_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 266);
            this.Controls.Add(this._txtbox1);
            this.Controls.Add(this._btnSaveFile);
            this.Controls.Add(this._btnOpenFile);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnOpenFile;
        private System.Windows.Forms.Button _btnSaveFile;
        private System.Windows.Forms.TextBox _txtbox1;
        private System.Windows.Forms.OpenFileDialog _dialOpen;
        private System.Windows.Forms.SaveFileDialog _dialSave;
    }
}

