using System.Windows;
using System.Windows.Controls;

namespace AI_Friend.Support.UI.Units;

public class MaximizeButton : Button
{
    static MaximizeButton()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MaximizeButton), new FrameworkPropertyMetadata(typeof(MaximizeButton)));
    }
}
