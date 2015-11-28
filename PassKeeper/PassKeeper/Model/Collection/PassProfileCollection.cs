using System;
using System.Collections.Generic;
using System.Linq;

namespace PassKeeper.Model.Collection
{
    public class PassProfileCollection : List<PassProfileModel>
    {
        public PassProfileModel AddNewProfile()
        {
            var newProfile = new PassProfileModel();
            if (this.Count == 0)
                newProfile.Id = 1;
            else
                newProfile.Id = this.Max(x => x.Id) + 1;

            this.Add(newProfile);
            return newProfile;
        }

        public String Filter { get; set; }

        public PassProfileModel[] FilteredCollection
        {
            get
            {
                if (String.IsNullOrEmpty(this.Filter))
                    return this.ToArray();

                var filteredList = this.FindAll(x => x.Name.Contains(this.Filter));
                return filteredList.ToArray();
            }
        }
    }
}