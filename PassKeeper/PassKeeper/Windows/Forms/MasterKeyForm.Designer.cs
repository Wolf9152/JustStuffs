namespace PassKeeper.Windows.Forms
{
    partial class MasterKeyForm
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
            this._textBoxMaster = new System.Windows.Forms.TextBox();
            this._buttonCommit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _textBoxMaster
            // 
            this._textBoxMaster.Location = new System.Drawing.Point(34, 21);
            this._textBoxMaster.Name = "_textBoxMaster";
            this._textBoxMaster.PasswordChar = '*';
            this._textBoxMaster.Size = new System.Drawing.Size(202, 20);
            this._textBoxMaster.TabIndex = 0;
            this._textBoxMaster.KeyDown += new System.Windows.Forms.KeyEventHandler(this._textBoxMaster_KeyDown);
            // 
            // _buttonCommit
            // 
            this._buttonCommit.Location = new System.Drawing.Point(98, 47);
            this._buttonCommit.Name = "_buttonCommit";
            this._buttonCommit.Size = new System.Drawing.Size(75, 23);
            this._buttonCommit.TabIndex = 1;
            this._buttonCommit.Text = "Ok";
            this._buttonCommit.UseVisualStyleBackColor = true;
            this._buttonCommit.Click += new System.EventHandler(this._buttonCommit_Click);
            // 
            // MasterKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 89);
            this.Controls.Add(this._buttonCommit);
            this.Controls.Add(this._textBoxMaster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MasterKeyForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mester kulcs...";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBoxMaster;
        private System.Windows.Forms.Button _buttonCommit;
    }
}