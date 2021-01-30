using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplate
{
    public class Profile
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Birth { get; set; }
    }

    public class ProfileList : List<Profile> { }
}
