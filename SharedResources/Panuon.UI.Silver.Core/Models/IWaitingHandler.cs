using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Panuon.UI.Silver.Core
{
    public interface IWaitingHandler
    {
        void Close();
    }

    public class WaitingHandler : IWaitingHandler
    {
        private Window _window;

        public WaitingHandler(Window window)
        {
            _window = window;
        }

        public void Close()
        {
            _window.Close();
        }
    }
}
