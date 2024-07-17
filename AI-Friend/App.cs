using AI_Friend.Support.UI.Units;
using Jamesnet.Wpf.Controls;
using System.Windows;

namespace AI_Friend;

internal class App : JamesApplication
{
    protected override Window CreateShell() => new WhiteWindow();
}
