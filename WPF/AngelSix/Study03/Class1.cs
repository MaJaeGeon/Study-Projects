using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace Study03
{
    public class Class1 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public string Test { get; set; } = "My Property";

        public Class1()
        {
            Task.Run(async () =>
            {
                int i = 0;
                while(true)
                {
                    await Task.Delay(200);
                    Test = (i++).ToString();

                    PropertyChanged(this, new PropertyChangedEventArgs("Test"));
                }
            });
        }

        public override string ToString()
        {
            return "Hello World";
        }
    }
}
