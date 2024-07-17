using AI_Friend.Forms.UI.Views;
using Jamesnet.Wpf.Controls;
using System.Windows;

namespace AI_Friend;

internal class App : JamesApplication
{
    protected override Window CreateShell() => new AI_FriendWindow();
}