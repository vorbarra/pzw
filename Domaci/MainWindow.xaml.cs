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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Domaci.Controls;

namespace Domaci
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.LeftButton.Click += LeftButton_Click;
            this.RightButton.Click += RightButton_Click;

            RegisterUserDelete();
            RegisterCommentDelete();
        }

        private void RegisterUserDelete()
        {
            foreach (var child in this.LeftContainer.Children)
            {
                if (child is User)
                {
                    var user = (User)child;

                    user.Delete += user_Delete;
                }
            }
        }

        void user_Delete(object sender, RoutedEventArgs e)
        {
            if (!(sender is User)) { return; }

            User user = (User)sender;
            this.LeftContainer.Children.Remove(user);
        }

        private void RegisterCommentDelete()
        {
            foreach (var child in this.RightContainer.Children)
            {
                if (child is Comment)
                {
                    var comment = (Comment)child;

                    comment.Delete += comment_Delete;
                }
            }
        }

        void comment_Delete(object sender, RoutedEventArgs e)
        {
            if (!(sender is Comment)) { return; }

            Comment comment = (Comment)sender;
            this.RightContainer.Children.Remove(comment);
        }   

        void RightButton_Click(object sender, RoutedEventArgs e)
        {
            var comment = new Comment();

            this.RightContainer.Children.Add(comment);
        }

        void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            var user = new User();

            this.LeftContainer.Children.Add(user);
        }
  
    }
}
