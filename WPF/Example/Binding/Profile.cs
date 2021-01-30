using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding
{
    public class Profile
    {
        public string   Name    { get; set; }
        public int      Age     { get; set; }
        public DateTime Birth   { get; set; }

        public override string ToString()
        {
            return string.Format("이름 : {0}, 나이 : {1}, 생일 : {2}", Name, Age, Birth);
        }
    }
}
