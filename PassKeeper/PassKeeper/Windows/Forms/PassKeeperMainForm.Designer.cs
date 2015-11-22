namespace PassKeeper.Windows.Forms
{
    partial class PassKeeperMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassKeeperMainForm));
            this._listBoxProfiles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this._textBoxProfileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._textBoxUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._textBoxPassword = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._toolStripMenuItemNewProfile = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripMenuItemSaveProfiles = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripMenuItemDeleteProfile = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._buttonModifyAndCommit = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this.passProfileModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passProfileModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _listBoxProfiles
            // 
            this._listBoxProfiles.Dock = System.Windows.Forms.DockStyle.Left;
            this._listBoxProfiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._listBoxProfiles.FormattingEnabled = true;
            this._listBoxProfiles.Location = new System.Drawing.Point(0, 24);
            this._listBoxProfiles.Name = "_listBoxProfiles";
            this._listBoxProfiles.Size = new System.Drawing.Size(216, 440);
            this._listBoxProfiles.TabIndex = 0;
            this._listBoxProfiles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this._listBoxProfiles_DrawItem);
            this._listBoxProfiles.DoubleClick += new System.EventHandler(this._listBoxProfiles_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // _textBoxProfileName
            // 
            this._textBoxProfileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxProfileName.Location = new System.Drawing.Point(312, 27);
            this._textBoxProfileName.Name = "_textBoxProfileName";
            this._textBoxProfileName.ReadOnly = true;
            this._textBoxProfileName.Size = new System.Drawing.Size(534, 20);
            this._textBoxProfileName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Felhasználónév:";
            // 
            // _textBoxUserName
            // 
            this._textBoxUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxUserName.Location = new System.Drawing.Point(312, 53);
            this._textBoxUserName.Name = "_textBoxUserName";
            this._textBoxUserName.ReadOnly = true;
            this._textBoxUserName.Size = new System.Drawing.Size(534, 20);
            this._textBoxUserName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Jelszó:";
            // 
            // _textBoxPassword
            // 
            this._textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxPassword.Location = new System.Drawing.Point(312, 79);
            this._textBoxPassword.Name = "_textBoxPassword";
            this._textBoxPassword.ReadOnly = true;
            this._textBoxPassword.Size = new System.Drawing.Size(534, 20);
            this._textBoxPassword.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripMenuItemNewProfile,
            this._toolStripMenuItemSaveProfiles,
            this._toolStripMenuItemDeleteProfile,
            this._toolStripMenuItemHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _toolStripMenuItemNewProfile
            // 
            this._toolStripMenuItemNewProfile.Name = "_toolStripMenuItemNewProfile";
            this._toolStripMenuItemNewProfile.Size = new System.Drawing.Size(30, 20);
            this._toolStripMenuItemNewProfile.Text = "Új";
            this._toolStripMenuItemNewProfile.Click += new System.EventHandler(this._toolStripMenuItemNewProfile_Click);
            // 
            // _toolStripMenuItemSaveProfiles
            // 
            this._toolStripMenuItemSaveProfiles.Name = "_toolStripMenuItemSaveProfiles";
            this._toolStripMenuItemSaveProfiles.Size = new System.Drawing.Size(58, 20);
            this._toolStripMenuItemSaveProfiles.Text = "Mentés";
            this._toolStripMenuItemSaveProfiles.Click += new System.EventHandler(this._toolStripMenuItemSaveProfiles_Click);
            // 
            // _toolStripMenuItemDeleteProfile
            // 
            this._toolStripMenuItemDeleteProfile.Name = "_toolStripMenuItemDeleteProfile";
            this._toolStripMenuItemDeleteProfile.Size = new System.Drawing.Size(47, 20);
            this._toolStripMenuItemDeleteProfile.Text = "Töröl";
            this._toolStripMenuItemDeleteProfile.Click += new System.EventHandler(this._toolStripMenuItemDeleteProfile_Click);
            // 
            // _toolStripMenuItemHelp
            // 
            this._toolStripMenuItemHelp.Name = "_toolStripMenuItemHelp";
            this._toolStripMenuItemHelp.Size = new System.Drawing.Size(46, 20);
            this._toolStripMenuItemHelp.Text = "Súgó";
            // 
            // _buttonModifyAndCommit
            // 
            this._buttonModifyAndCommit.Enabled = false;
            this._buttonModifyAndCommit.Location = new System.Drawing.Point(771, 105);
            this._buttonModifyAndCommit.Name = "_buttonModifyAndCommit";
            this._buttonModifyAndCommit.Size = new System.Drawing.Size(75, 23);
            this._buttonModifyAndCommit.TabIndex = 6;
            this._buttonModifyAndCommit.Text = "Módosít";
            this._buttonModifyAndCommit.UseVisualStyleBackColor = true;
            this._buttonModifyAndCommit.Click += new System.EventHandler(this._buttonModifyAndCommit_Click);
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Location = new System.Drawing.Point(690, 105);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 5;
            this._buttonCancel.Text = "Mégse";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Visible = false;
            this._buttonCancel.Click += new System.EventHandler(this._buttonCancel_Click);
            // 
            // passProfileModelBindingSource
            // 
            this.passProfileModelBindingSource.DataSource = typeof(PassKeeper.Model.PassProfileModel);
            // 
            // PassKeeperMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 464);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonModifyAndCommit);
            this.Controls.Add(this._textBoxPassword);
            this.Controls.Add(this._textBoxUserName);
            this.Controls.Add(this._textBoxProfileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._listBoxProfiles);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PassKeeperMainForm";
            this.Text = "PassKeeper";
            this.Load += new System.EventHandler(this.PassKeeperMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passProfileModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _listBoxProfiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _textBoxProfileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _textBoxUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _textBoxPassword;
        private System.Windows.Forms.BindingSource passProfileModelBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem _toolStripMenuItemNewProfile;
        private System.Windows.Forms.ToolStripMenuItem _toolStripMenuItemSaveProfiles;
        private System.Windows.Forms.ToolStripMenuItem _toolStripMenuItemDeleteProfile;
        private System.Windows.Forms.ToolStripMenuItem _toolStripMenuItemHelp;
        private System.Windows.Forms.Button _buttonModifyAndCommit;
        private System.Windows.Forms.Button _buttonCancel;
    }
}