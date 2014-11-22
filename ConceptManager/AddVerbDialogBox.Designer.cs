namespace ConceptManager
{
    partial class AddVerbDialogBox
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
            this.verbTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.linkingVerb = new System.Windows.Forms.RadioButton();
            this.actionVerb = new System.Windows.Forms.RadioButton();
            this.knownInformation = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.messageIcon = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.errorNoSelection = new System.Windows.Forms.ErrorProvider(this.components);
            this.verbTypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messageIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // verbTypeGroupBox
            // 
            this.verbTypeGroupBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.verbTypeGroupBox.Controls.Add(this.linkingVerb);
            this.verbTypeGroupBox.Controls.Add(this.actionVerb);
            this.verbTypeGroupBox.Location = new System.Drawing.Point(63, 142);
            this.verbTypeGroupBox.Name = "verbTypeGroupBox";
            this.verbTypeGroupBox.Size = new System.Drawing.Size(351, 48);
            this.verbTypeGroupBox.TabIndex = 0;
            this.verbTypeGroupBox.TabStop = false;
            this.verbTypeGroupBox.Text = "Verb Type";
            // 
            // linkingVerb
            // 
            this.linkingVerb.AutoSize = true;
            this.linkingVerb.Location = new System.Drawing.Point(184, 19);
            this.linkingVerb.Name = "linkingVerb";
            this.linkingVerb.Size = new System.Drawing.Size(65, 19);
            this.linkingVerb.TabIndex = 2;
            this.linkingVerb.TabStop = true;
            this.linkingVerb.Text = "Linking";
            this.linkingVerb.UseVisualStyleBackColor = true;
            this.linkingVerb.CheckedChanged += new System.EventHandler(this.linkingVerb_CheckedChanged);
            // 
            // actionVerb
            // 
            this.actionVerb.AutoSize = true;
            this.actionVerb.Location = new System.Drawing.Point(92, 19);
            this.actionVerb.Name = "actionVerb";
            this.actionVerb.Size = new System.Drawing.Size(58, 19);
            this.actionVerb.TabIndex = 0;
            this.actionVerb.TabStop = true;
            this.actionVerb.Text = "Action";
            this.actionVerb.UseVisualStyleBackColor = true;
            this.actionVerb.CheckedChanged += new System.EventHandler(this.actionVerb_CheckedChanged);
            // 
            // knownInformation
            // 
            this.knownInformation.BackColor = System.Drawing.SystemColors.HighlightText;
            this.knownInformation.Enabled = false;
            this.knownInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knownInformation.Location = new System.Drawing.Point(63, 53);
            this.knownInformation.Multiline = true;
            this.knownInformation.Name = "knownInformation";
            this.knownInformation.ReadOnly = true;
            this.knownInformation.Size = new System.Drawing.Size(351, 74);
            this.knownInformation.TabIndex = 1;
            this.knownInformation.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(103, 209);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(237, 209);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // messageIcon
            // 
            this.messageIcon.Location = new System.Drawing.Point(12, 53);
            this.messageIcon.Name = "messageIcon";
            this.messageIcon.Size = new System.Drawing.Size(38, 36);
            this.messageIcon.TabIndex = 14;
            this.messageIcon.TabStop = false;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(2, 11);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(112, 30);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Add a verb";
            this.headerLabel.UseCompatibleTextRendering = true;
            // 
            // errorNoSelection
            // 
            this.errorNoSelection.ContainerControl = this;
            // 
            // AddVerbDialogBox
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(425, 258);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.messageIcon);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.knownInformation);
            this.Controls.Add(this.verbTypeGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddVerbDialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.verbTypeGroupBox.ResumeLayout(false);
            this.verbTypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messageIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoSelection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox knownInformation;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton actionVerb;
        private System.Windows.Forms.RadioButton linkingVerb;
        private System.Windows.Forms.PictureBox messageIcon;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ErrorProvider errorNoSelection;
        private System.Windows.Forms.GroupBox verbTypeGroupBox;
    }
}