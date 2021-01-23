using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch01_01
{
    public class Cust : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void Notify(string propName)
        {
            if(this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name == value) return;

                name = value;
                Notify("Name");
            }
        }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (age == value) return;

                age = value;
                Notify("Age");
            }
        }

        public Cust(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
