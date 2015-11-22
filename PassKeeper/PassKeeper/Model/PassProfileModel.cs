using System;

namespace PassKeeper.Model
{
    public class PassProfileModel
    {
        public Int32 Id { get; set; }

        public String Name { get; set; }

        public String UserName { get; set; }

        public String Password { get; set; }

        public PassProfileModel()
        {
            Name = UserName = Password = String.Empty;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}