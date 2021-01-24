using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Binding
{
    /// <summary>
    /// DataContextBinding.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DataContextBinding : Window
    {
        public DataContextBinding()
        {
            InitializeComponent();

            this.DataContext = new Profile { Name = "MaJaeGeon", Age = 20, Birth = new DateTime(2002, 05, 17) };
        }
    }
}
