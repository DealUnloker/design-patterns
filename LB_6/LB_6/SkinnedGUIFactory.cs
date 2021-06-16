using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_6
{
    public class SkinnedGUIFactory : IGUIFactory
    {
        public IWindow CreateWindow() { return new SkinnedWindow(); }
        public IButton CreateButton() { return new SkinnedButton(); }
        public ITextBox CreateTextbox() { return new SkinnedTextBox(); }
    }

}
