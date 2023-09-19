using System;
using System.Collections.ObjectModel;

namespace WinUI3TreeViewCrash;

public class TreeNode
{
    public TreeNode(string text)
    {
        Text = text;
    }

    public string Text { get; }

    public ObservableCollection<TreeNode> Children { get; } = new ObservableCollection<TreeNode>();
}