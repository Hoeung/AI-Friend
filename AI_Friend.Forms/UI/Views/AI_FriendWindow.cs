using AI_Friend.Support.UI.Units;
using System.Windows;

namespace AI_Friend.Forms.UI.Views;

public class AI_FriendWindow : WhiteWindow
{
    static AI_FriendWindow()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(AI_FriendWindow), new FrameworkPropertyMetadata(typeof(AI_FriendWindow)));
    }
}
