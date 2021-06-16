using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_6
{
    interface DefaultGUIFactory : IGUIFactory
    {
        public IWindow CreateWindow() { return new DefaultWindow(); }
        public IButton CreateButton() { return new DefaultButton(); }
        public ITextBox CreateTextbox() { return new DefaultTextBox(); }

    }
}
