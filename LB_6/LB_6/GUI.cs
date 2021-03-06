using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_6
{
    public static class GUI
    {
        private class GUIFactoryGeneric<TWindow, TButton, TTextBox> : IGUIFactory
            where TWindow : IWindow, new()
            where TButton : IButton, new()
            where TTextBox : ITextBox, new()
        {
            public IWindow CreateWindow() { return new TWindow(); }
            public IButton CreateButton() { return new TButton(); }
            public ITextBox CreateTextbox() { return new TTextBox(); }
        }
        public enum Style { Default, Skinned }
        public static IGUIFactory GetFactory(Style guiStyle)
        {
            switch (guiStyle)
            {
                case Style.Default:
                    return new GUIFactoryGeneric<DefaultWindow, DefaultButton, DefaultTextBox>();
                case Style.Skinned:
                    return new GUIFactoryGeneric<SkinnedWindow, SkinnedButton, SkinnedTextBox>();
            }
            throw new ArgumentException("An invalid guiStyle:" + guiStyle.ToString());
        }
    }

}
