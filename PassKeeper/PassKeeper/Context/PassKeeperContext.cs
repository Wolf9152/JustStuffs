using PassKeeper.Data;
using PassKeeper.Exceptions;
using PassKeeper.Model;
using PassKeeper.Model.Collection;
using PassKeeper.Services;
using PassKeeper.Windows.Forms;
using System;
using System.IO;
using System.Linq;

namespace PassKeeper.Context
{
    public class PassKeeperContext
    {
        public PassKeeperMainForm View { get; private set; }

        public String MasterKey { get; set; }

        public PassProfileCollection Passes { get; set; }        

        public PassProfileModel SelectedPass { get; set; }

        public void SetSelectedPass(PassProfileModel model)
        {
            if (model == null)
            {
                SelectedPass = null;
            }
            else
            {
                SelectedPass = new PassProfileModel();
                SelectedPass.Id = model.Id;
                SelectedPass.Name = model.Name;
                SelectedPass.UserName = String.IsNullOrEmpty(model.UserName) ? model.UserName : EncryptorService.Decrypt(model.UserName, model.Id + MasterKey);
                SelectedPass.Password = String.IsNullOrEmpty(model.Password) ? model.Password : EncryptorService.Decrypt(model.Password, SelectedPass.UserName + model.Id + MasterKey);
            }
            View.LoadSelectedProfile();
        }

        public void CommitSelectedPass()
        {
            //Hiszen sajátmaga 1x biztos benne lesz, szóval ha már 2 van akkor van csak gáz...
            if (Passes.Count(x => x.Name == SelectedPass.Name) > 1)
                throw new PassException("Hiba!", String.Format("A(z) '{0}' névem már létezik profil, kérlek válasz másik nevet neki!", SelectedPass.Name));

            if (String.IsNullOrEmpty(SelectedPass.UserName))
                throw new PassException("Hiba!", "A Felhasználónév mező kitöltése kötelező!");

            if (String.IsNullOrEmpty(SelectedPass.Password))
                throw new PassException("Hiba!", "A Jelszó mező kitöltése kötelező!");

            PassProfileModel model = Passes.SingleOrDefault(x => x.Id == SelectedPass.Id);
            model.Name = SelectedPass.Name;
            model.UserName = EncryptorService.Encrypt(SelectedPass.UserName, SelectedPass.Id + MasterKey);
            model.Password = EncryptorService.Encrypt(SelectedPass.Password, SelectedPass.UserName + SelectedPass.Id + MasterKey);
        }

        public PassKeeperContext(PassKeeperMainForm view)
        {
            this.View = view;
        }

        internal void LoadPasses()
        {
            if (File.Exists(Constants.FileName))
            {
                String passesCoded = FileManagerService.ReadStringFromFile(Constants.FileName);
                String passesDecoded = EncryptorService.Decrypt(passesCoded, MasterKey);
                Passes = JsonParserService.ParseStringToObject<PassProfileCollection>(passesDecoded);
            }
            else
            {
                Passes = new PassProfileCollection();
            }
        }

        internal void SavePasses()
        {
            String jsonPasses = JsonParserService.ParseObjToString(Passes);
            String codedPasses = EncryptorService.Encrypt(jsonPasses, MasterKey);
            FileManagerService.WriteStringToFile(codedPasses, Constants.FileName);
        }

        internal void DeletePass(PassProfileModel pass)
        {
            if (Passes.Contains(pass))
                Passes.Remove(pass);
        }

        internal void RefreshSelectedName(String name)
        {
            var selectedInList = Passes.SingleOrDefault(x => x.Id == SelectedPass.Id);
            if (selectedInList == null)
                return;

            selectedInList.Name = name;
            View.RefreshProfiles();
        }
    }
}