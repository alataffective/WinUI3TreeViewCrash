using System.Collections.ObjectModel;
using Microsoft.UI.Xaml;

namespace WinUI3TreeViewCrash
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            TreeViewItems = new ObservableCollection<TreeNode>()
            {
                new TreeNode("One")
                {
                    Children =
                    {
                        new TreeNode("One One"),
                        new TreeNode("One Two")
                    }
                }
            };
        }

        public ObservableCollection<TreeNode> TreeViewItems { get; }
    }
}