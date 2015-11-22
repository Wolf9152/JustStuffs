using PassKeeper.Exceptions;
using PassKeeper.Utils;
using System;
using System.Windows.Forms;

namespace PassKeeper.Windows.Forms
{
    public partial class MasterKeyForm : Form
    {
        public String MasterKey { get { return _textBoxMaster.Text; } }

        public MasterKeyForm()
        {
            InitializeComponent();
        }

        public static String ShowMasterKeyForm()
        {
            var dialog = new MasterKeyForm();
            dialog.ShowDialog();
            return dialog.MasterKey;
        }

        private void _buttonCommit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MasterKey.Length < 8)
                    throw new PassException("A mesterjelszó hossza legalább 8 karakter kell hogy legyen!");

                this.Close();
            }
            catch (Exception ex)
            {
                DialogUtils.ShowException(ex);
            }
        }

        private void _textBoxMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                _buttonCommit_Click(sender, EventArgs.Empty);
        }
    }
}