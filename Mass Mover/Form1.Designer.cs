namespace FileMoverApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.labelLang = new System.Windows.Forms.Label();
            this.radioButtonCopy = new System.Windows.Forms.RadioButton();
            this.radioButtonMove = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.checkBoxOverwrite = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(100, 16);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(160, 21);
            this.comboBoxLanguage.TabIndex = 0;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = true;
            this.labelLang.Location = new System.Drawing.Point(20, 19);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(58, 13);
            this.labelLang.TabIndex = 1;
            this.labelLang.Text = "Language:";
            // 
            // radioButtonCopy
            // 
            this.radioButtonCopy.AutoSize = true;
            this.radioButtonCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCopy.Location = new System.Drawing.Point(23, 94);
            this.radioButtonCopy.Name = "radioButtonCopy";
            this.radioButtonCopy.Size = new System.Drawing.Size(49, 17);
            this.radioButtonCopy.TabIndex = 2;
            this.radioButtonCopy.TabStop = true;
            this.radioButtonCopy.Text = "Copy";
            this.radioButtonCopy.UseVisualStyleBackColor = true;
            // 
            // radioButtonMove
            // 
            this.radioButtonMove.AutoSize = true;
            this.radioButtonMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMove.Location = new System.Drawing.Point(23, 57);
            this.radioButtonMove.Name = "radioButtonMove";
            this.radioButtonMove.Size = new System.Drawing.Size(52, 17);
            this.radioButtonMove.TabIndex = 3;
            this.radioButtonMove.TabStop = true;
            this.radioButtonMove.Text = "Move";
            this.radioButtonMove.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(23, 134);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(237, 30);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(20, 183);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(38, 13);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Ready";
            // 
            // checkBoxOverwrite
            // 
            this.checkBoxOverwrite.AutoSize = true;
            this.checkBoxOverwrite.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxOverwrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxOverwrite.Location = new System.Drawing.Point(167, 68);
            this.checkBoxOverwrite.Name = "checkBoxOverwrite";
            this.checkBoxOverwrite.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxOverwrite.Size = new System.Drawing.Size(56, 31);
            this.checkBoxOverwrite.TabIndex = 6;
            this.checkBoxOverwrite.Text = "Overwrite";
            this.checkBoxOverwrite.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxOverwrite.UseVisualStyleBackColor = true;
            this.checkBoxOverwrite.CheckedChanged += new System.EventHandler(this.checkBoxOverwrite_CheckedChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 217);
            this.Controls.Add(this.checkBoxOverwrite);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.radioButtonMove);
            this.Controls.Add(this.radioButtonCopy);
            this.Controls.Add(this.labelLang);
            this.Controls.Add(this.comboBoxLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mass Mover v. 0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label labelLang;
        private System.Windows.Forms.RadioButton radioButtonCopy;
        private System.Windows.Forms.RadioButton radioButtonMove;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.CheckBox checkBoxOverwrite;
    }
}
