namespace HuffmanWordCompression
{
    partial class HuffmanWordsForm
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
            this.lblEnterRaw = new System.Windows.Forms.Label();
            this.tbRawText = new System.Windows.Forms.TextBox();
            this.tbEncoded = new System.Windows.Forms.TextBox();
            this.tbDecoded = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterRaw
            // 
            this.lblEnterRaw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEnterRaw.AutoSize = true;
            this.lblEnterRaw.Location = new System.Drawing.Point(6, 7);
            this.lblEnterRaw.Name = "lblEnterRaw";
            this.lblEnterRaw.Size = new System.Drawing.Size(81, 13);
            this.lblEnterRaw.TabIndex = 0;
            this.lblEnterRaw.Text = "Enter Raw &Text";
            // 
            // tbRawText
            // 
            this.tbRawText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbRawText.Location = new System.Drawing.Point(6, 25);
            this.tbRawText.Multiline = true;
            this.tbRawText.Name = "tbRawText";
            this.tbRawText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRawText.Size = new System.Drawing.Size(766, 205);
            this.tbRawText.TabIndex = 1;
            this.tbRawText.TextChanged += new System.EventHandler(this.tbRawText_TextChanged);
            // 
            // tbEncoded
            // 
            this.tbEncoded.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbEncoded.Location = new System.Drawing.Point(6, 236);
            this.tbEncoded.Multiline = true;
            this.tbEncoded.Name = "tbEncoded";
            this.tbEncoded.ReadOnly = true;
            this.tbEncoded.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEncoded.Size = new System.Drawing.Size(374, 205);
            this.tbEncoded.TabIndex = 2;
            // 
            // tbDecoded
            // 
            this.tbDecoded.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDecoded.Location = new System.Drawing.Point(398, 236);
            this.tbDecoded.Multiline = true;
            this.tbDecoded.Name = "tbDecoded";
            this.tbDecoded.ReadOnly = true;
            this.tbDecoded.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDecoded.Size = new System.Drawing.Size(374, 205);
            this.tbDecoded.TabIndex = 3;
            // 
            // btnEncode
            // 
            this.btnEncode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEncode.Enabled = false;
            this.btnEncode.Location = new System.Drawing.Point(697, 447);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 4;
            this.btnEncode.Text = "&Encode!";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(697, 1);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // HuffmanWordsForm
            // 
            this.AcceptButton = this.btnEncode;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(778, 475);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.tbDecoded);
            this.Controls.Add(this.tbEncoded);
            this.Controls.Add(this.tbRawText);
            this.Controls.Add(this.lblEnterRaw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HuffmanWordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Compressor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterRaw;
        private System.Windows.Forms.TextBox tbRawText;
        private System.Windows.Forms.TextBox tbEncoded;
        private System.Windows.Forms.TextBox tbDecoded;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnReset;
    }
}

