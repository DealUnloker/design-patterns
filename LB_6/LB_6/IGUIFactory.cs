using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_6
{
    public interface IGUIFactory
    {
        IWindow CreateWindow();
        IButton CreateButton();
        ITextBox CreateTextbox();
    }
}
