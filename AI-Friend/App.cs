﻿using Jamesnet.Wpf.Controls;
using System.Windows;

namespace AI_Friend;

internal class App : JamesApplication
{
    protected override Window CreateShell()
    {
        // Temporary Window instance
        return new Window();
    }
}
