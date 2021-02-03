using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollection
{
    public class Profile
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Birth { get; set; }
    }

    public class ProfileList : ObservableCollection<Profile>
    {

    }
}