using System;
using System.Collections.Generic;
using System.Text;

namespace Panuon.UI.Silver.Core
{
    public interface IPendingHandler
    {
        event EventHandler Closed;

        event EventHandler Canceled;

        void Close();

        void UpdateMessage(string message);
    }

    internal class PendingHandler : IPendingHandler
    {
        #region Identifier
        private Action _closeAction;
        private Action<string> _updateMessageAction;
        #endregion

        #region Constructor
        public PendingHandler(Action closeAction, Action<string> updateMessageAction)
        {
            _closeAction = closeAction;
            _updateMessageAction = updateMessageAction;
        }
        #endregion

        #region 
        public event EventHandler Closed;
        public event EventHandler Canceled;

        public void Close()
        {
            _closeAction();
        }
        #endregion

        #region Calling Methods
        public void RaiseClosedEvent(object sender, EventArgs e)
        {
            Closed?.Invoke(sender, e);
        }

        public void RaiseCanceledEvent(object sender, EventArgs e)
        {
            Canceled?.Invoke(sender, e);
        }

        public void UpdateMessage(string message)
        {
            _updateMessageAction(message);
        }
        #endregion

    }

}
