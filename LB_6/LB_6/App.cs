using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_6
{
    class App
    {
        public static string GetUserInput(IGUIFactory guiFactory)
        {
            // Create UI elements
            IWindow wndInput = guiFactory.CreateWindow();
            IButton btnOk = guiFactory.CreateButton();
            IButton btnCancel = guiFactory.CreateButton();
            ITextBox tbInput = guiFactory.CreateTextbox();

            // TODO: Setup the window and elements
            /*            wndInput.AddChild(btnOk);
                        wndInput.AddChild(btnCancel);
                        wndInput.AddChild(tbInput);*/

            // TODO: Show dialog
            // TODO: Get the result

            /*return tbInput.GetText();*/
            return null;
        }
    }
}
