using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public class ProfileList : List<Profile>
    {

    }

    /// <summary>
    /// ListBinding.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ListBinding : Window
    {
        public ListBinding()
        {
            InitializeComponent();
        }

        private ICollectionView GetList()
        {
            ProfileList profiles = (ProfileList)FindResource("profileList");
            return CollectionViewSource.GetDefaultView(profiles);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ICollectionView view = GetList();

            Profile profile = (Profile)view.CurrentItem;

            Console.WriteLine($"Name : {profile.Name}, Age : {profile.Age}, Birth : {profile.Birth}");
        }

        private void btnPre_Click(object sender, RoutedEventArgs e)
        {
            var view = GetList();
            view.MoveCurrentToPrevious();

            if (view.IsCurrentBeforeFirst) view.MoveCurrentToFirst();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            var view = GetList();
            view.MoveCurrentToNext();

            if (view.IsCurrentAfterLast) view.MoveCurrentToLast();
        }

        private void lb_Profiles_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine(lb_Profiles.SelectedItem.ToString());
        }
    }
}
