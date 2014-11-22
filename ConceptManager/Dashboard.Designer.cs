namespace ConceptManager
{
    partial class Dashboard
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

        #region Windows VerbNumber Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.parseButton = new System.Windows.Forms.Button();
            this.pennTreeListBoxLabel = new System.Windows.Forms.Label();
            this.pennTreeListBox = new System.Windows.Forms.ListBox();
            this.signatureTextBoxLabel = new System.Windows.Forms.Label();
            this.signatureTextBox = new System.Windows.Forms.TextBox();
            this.sentenceTextBox = new System.Windows.Forms.TextBox();
            this.sentenceTextBoxLabel = new System.Windows.Forms.Label();
            this.sentenceError = new System.Windows.Forms.ErrorProvider(this.components);
            this.conceptTreeListBox = new System.Windows.Forms.ListBox();
            this.conceptTreeListboxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sentenceError)).BeginInit();
            this.SuspendLayout();
            // 
            // parseButton
            // 
            this.parseButton.Location = new System.Drawing.Point(57, 58);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(75, 23);
            this.parseButton.TabIndex = 1;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.parseButton_Click);
            // 
            // pennTreeListBoxLabel
            // 
            this.pennTreeListBoxLabel.AutoSize = true;
            this.pennTreeListBoxLabel.Enabled = false;
            this.pennTreeListBoxLabel.Location = new System.Drawing.Point(56, 159);
            this.pennTreeListBoxLabel.Name = "pennTreeListBoxLabel";
            this.pennTreeListBoxLabel.Size = new System.Drawing.Size(67, 15);
            this.pennTreeListBoxLabel.TabIndex = 1;
            this.pennTreeListBoxLabel.Text = "Parse Tree";
            // 
            // pennTreeListBox
            // 
            this.pennTreeListBox.FormattingEnabled = true;
            this.pennTreeListBox.Location = new System.Drawing.Point(57, 177);
            this.pennTreeListBox.Name = "pennTreeListBox";
            this.pennTreeListBox.Size = new System.Drawing.Size(294, 173);
            this.pennTreeListBox.TabIndex = 2;
            // 
            // signatureTextBoxLabel
            // 
            this.signatureTextBoxLabel.AutoSize = true;
            this.signatureTextBoxLabel.Enabled = false;
            this.signatureTextBoxLabel.Location = new System.Drawing.Point(58, 366);
            this.signatureTextBoxLabel.Name = "signatureTextBoxLabel";
            this.signatureTextBoxLabel.Size = new System.Drawing.Size(115, 15);
            this.signatureTextBoxLabel.TabIndex = 3;
            this.signatureTextBoxLabel.Text = "Sentence Signature";
            // 
            // signatureTextBox
            // 
            this.signatureTextBox.Location = new System.Drawing.Point(62, 385);
            this.signatureTextBox.Name = "signatureTextBox";
            this.signatureTextBox.Size = new System.Drawing.Size(234, 20);
            this.signatureTextBox.TabIndex = 4;
            // 
            // sentenceTextBox
            // 
            this.sentenceTextBox.Location = new System.Drawing.Point(57, 32);
            this.sentenceTextBox.Multiline = true;
            this.sentenceTextBox.Name = "sentenceTextBox";
            this.sentenceTextBox.Size = new System.Drawing.Size(234, 20);
            this.sentenceTextBox.TabIndex = 0;
            this.sentenceTextBox.Leave += new System.EventHandler(this.sentenceTextBox_Leave);
            this.sentenceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.sentenceTextBox_Validating);
            // 
            // sentenceTextBoxLabel
            // 
            this.sentenceTextBoxLabel.AutoSize = true;
            this.sentenceTextBoxLabel.Enabled = false;
            this.sentenceTextBoxLabel.Location = new System.Drawing.Point(54, 14);
            this.sentenceTextBoxLabel.Name = "sentenceTextBoxLabel";
            this.sentenceTextBoxLabel.Size = new System.Drawing.Size(59, 15);
            this.sentenceTextBoxLabel.TabIndex = 6;
            this.sentenceTextBoxLabel.Text = "Sentence";
            // 
            // sentenceError
            // 
            this.sentenceError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.sentenceError.ContainerControl = this;
            // 
            // conceptTreeListBox
            // 
            this.conceptTreeListBox.FormattingEnabled = true;
            this.conceptTreeListBox.Location = new System.Drawing.Point(386, 177);
            this.conceptTreeListBox.Name = "conceptTreeListBox";
            this.conceptTreeListBox.Size = new System.Drawing.Size(368, 173);
            this.conceptTreeListBox.TabIndex = 7;
            // 
            // conceptTreeListboxLabel
            // 
            this.conceptTreeListboxLabel.AutoSize = true;
            this.conceptTreeListboxLabel.Location = new System.Drawing.Point(383, 159);
            this.conceptTreeListboxLabel.Name = "conceptTreeListboxLabel";
            this.conceptTreeListboxLabel.Size = new System.Drawing.Size(58, 15);
            this.conceptTreeListboxLabel.TabIndex = 8;
            this.conceptTreeListboxLabel.Text = "Concepts";
            // 
            // Dashboard
            // 
            this.AcceptButton = this.parseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(766, 446);
            this.Controls.Add(this.conceptTreeListboxLabel);
            this.Controls.Add(this.conceptTreeListBox);
            this.Controls.Add(this.sentenceTextBoxLabel);
            this.Controls.Add(this.sentenceTextBox);
            this.Controls.Add(this.signatureTextBox);
            this.Controls.Add(this.signatureTextBoxLabel);
            this.Controls.Add(this.pennTreeListBox);
            this.Controls.Add(this.pennTreeListBoxLabel);
            this.Controls.Add(this.parseButton);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cell Manager Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.sentenceError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.Label pennTreeListBoxLabel;
        private System.Windows.Forms.ListBox pennTreeListBox;
        private System.Windows.Forms.Label signatureTextBoxLabel;
        private System.Windows.Forms.TextBox signatureTextBox;
        private System.Windows.Forms.TextBox sentenceTextBox;
        private System.Windows.Forms.Label sentenceTextBoxLabel;
        private System.Windows.Forms.ErrorProvider sentenceError;
        private System.Windows.Forms.Label conceptTreeListboxLabel;
        private System.Windows.Forms.ListBox conceptTreeListBox;
    }
}

