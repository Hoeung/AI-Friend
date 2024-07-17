using Jamesnet.Wpf.Controls;
using System.Windows;

namespace AI_Friend.Support.UI.Units;

public class WhiteWindow : JamesWindow
{
    static WhiteWindow()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(WhiteWindow), new FrameworkPropertyMetadata(typeof(WhiteWindow)));
    }
}
