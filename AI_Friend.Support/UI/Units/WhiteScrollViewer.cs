using System.Windows;
using System.Windows.Controls;

namespace AI_Friend.Support.UI.Units;

public class WhiteScrollViewer : ScrollViewer
{
    static WhiteScrollViewer()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(WhiteScrollViewer), new FrameworkPropertyMetadata(typeof(WhiteScrollViewer)));
    }
}
