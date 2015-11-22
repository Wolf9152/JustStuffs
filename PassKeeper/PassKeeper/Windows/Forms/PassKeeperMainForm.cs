using PassKeeper.Context;
using PassKeeper.Data;
using PassKeeper.Exceptions;
using PassKeeper.Model;
using PassKeeper.Utils;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PassKeeper.Windows.Forms
{
    public partial class PassKeeperMainForm : Form
    {
        public PassKeeperContext Context { get; private set; }

        private ModifyState _state;

        public ModifyState State
        {
            get
            {
                return _state;
            }
            set
            {
                _textBoxPassword.ReadOnly =
                    _textBoxProfileName.ReadOnly =
                    _textBoxUserName.ReadOnly =
                    value == ModifyState.View;

                if (value == ModifyState.Modify)
                {
                    _buttonCancel.Visible = true;
                    _buttonModifyAndCommit.Text = "Ok";
                }
                else
                {
                    _buttonCancel.Visible = false;
                    _buttonModifyAndCommit.Text = "Módosít";
                }
                this.RefreshListDataSource();
                _state = value;
            }
        }

        public PassKeeperMainForm()
        {
            InitializeComponent();
        }

        private void _toolStripMenuItemNewProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (State == ModifyState.Modify)
                    throw new PassException("Jelenleg módosítás alatt áll egy profil, előbb mentsd el a változtatásait!");
                var profile = Context.Passes.AddNewProfile();
                Context.SetSelectedPass(profile);
                State = ModifyState.Modify;
            }
            catch (Exception ex)
            {
                DialogUtils.ShowException(ex);
            }
        }

        private void PassKeeperMainForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.Context = new PassKeeperContext(this);
                if (!File.Exists(Constants.FileName))
                    DialogUtils.ShowWarrningMessage("Figyelem!", "A most beütött mester jelszó a későbbiek folyamán már nem módosítható és utólag nem visszakérhető!!!");

                String masterKey = MasterKeyForm.ShowMasterKeyForm();
                if (String.IsNullOrEmpty(masterKey))
                    throw new PassException("A mesterjelszó kitöltése kötelező!");
                Context.MasterKey = masterKey;
                Context.LoadPasses();
                this.RefreshListDataSource();
            }
            catch (Exception ex)
            {
                DialogUtils.ShowException(ex);
                Application.Exit();
            }
        }

        internal void LoadSelectedProfile()
        {
            if (Context.SelectedPass == null)
            {
                _buttonModifyAndCommit.Enabled = false;
                _textBoxProfileName.Text =
                _textBoxUserName.Text =
                _textBoxPassword.Text = String.Empty;
            }
            else
            {
                _buttonModifyAndCommit.Enabled = true;
                _textBoxProfileName.Text = Context.SelectedPass.Name;
                _textBoxUserName.Text = Context.SelectedPass.UserName;
                _textBoxPassword.Text = Context.SelectedPass.Password;
            }
        }

        private void _listBoxProfiles_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var pass = _listBoxProfiles.SelectedItem as PassProfileModel;
                if (pass == null)
                    return;

                Context.SetSelectedPass(pass);
            }
            catch (Exception ex)
            {
                DialogUtils.ShowException(ex);
            }
        }

        private void _listBoxProfiles_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            ListBox list = sender as ListBox;
            if (e.Index != -1 && list.Items.Count != 0)
            {
                var item = list.Items[e.Index];
                if (item is PassProfileModel &&
                    Context.SelectedPass != null &&
                    ((PassProfileModel)item).Id == Context.SelectedPass.Id)
                {
                    e.Graphics.DrawString(item.ToString(), new Font(e.Font, FontStyle.Bold | FontStyle.Underline), Brushes.Black, e.Bounds, StringFormat.GenericDefault);
                }
                else
                {
                    e.Graphics.DrawString(item.ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
                }
            }

            e.DrawFocusRectangle();
        }

        private void _buttonModifyAndCommit_Click(object sender, EventArgs e)
        {
            try
            {
                if (State == ModifyState.View)
                {
                    State = ModifyState.Modify;
                    _textBoxProfileName.Focus();
                }
                else
                {
                    Context.SelectedPass.Name = _textBoxProfileName.Text;
                    Context.SelectedPass.UserName = _textBoxUserName.Text;
                    Context.SelectedPass.Password = _textBoxPassword.Text;
                    Context.CommitSelectedPass();
                    State = ModifyState.View;
                }
            }
            catch (Exception ex)
            {
                DialogUtils.ShowException(ex);
            }
        }

        private void _buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                var pass = Context.Passes.SingleOrDefault(x => x.Id == Context.SelectedPass.Id);

                Context.SetSelectedPass(pass);
            }
            catch (Exception ex)
            {
                DialogUtils.ShowException(ex);
            }
        }

        private void _toolStripMenuItemSaveProfiles_Click(object sender, EventArgs e)
        {
            try
            {
                if (State == ModifyState.Modify)
                    throw new PassException("Jelenleg módosítás alatt ál egy profil, kérlek fejezd azt be előbb, majd azt követően próbálj menteni!");

                Context.SavePasses();
                DialogUtils.ShowInformationMessage("Mentés", "A mentés elkészült!");
            }
            catch (Exception ex)
            {
                DialogUtils.ShowException(ex);
            }
        }

        private void _toolStripMenuItemDeleteProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (State == ModifyState.Modify)
                    throw new PassException("Jelenleg módosítás alatt ál egy profil, kérlek fejezd azt be előbb, majd azt követően próbálj törölni!");

                var pass = _listBoxProfiles.SelectedItem as PassProfileModel;
                if (pass == null)
                    DialogUtils.ShowWarrningMessage("Törlés", "Nem választottál ki egyetlen sort sem!");

                var result = DialogUtils.ShowQuestionMessage("Törlés megerősítése!", String.Format("Biztosan törölni akarod a(z) '{0}' nevű profilodat?", pass.Name));
                if (result != System.Windows.Forms.DialogResult.Yes)
                    return;

                Context.DeletePass(pass);
                Context.SetSelectedPass(null);
                RefreshListDataSource();
            }
            catch (Exception ex)
            {
                DialogUtils.ShowException(ex);
            }
        }

        private void RefreshListDataSource()
        {
            _listBoxProfiles.Items.Clear();
            _listBoxProfiles.Items.AddRange(Context.Passes.ToArray());
        }
    }
}