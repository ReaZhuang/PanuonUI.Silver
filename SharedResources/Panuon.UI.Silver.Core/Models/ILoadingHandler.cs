using System;
using System.Collections.Generic;
using System.Text;

namespace Panuon.UI.Silver.Core
{
    public interface ILoadingHandler
    {
        event EventHandler Closed;

        void Close();
    }

    public interface ICancelableLoadingHandler : ILoadingHandler
    {
        event EventHandler Canceled;
    }


    internal class LoadingHandler : ICancelableLoadingHandler
    {
        #region Identifier
        private Action _closeAction;
        #endregion

        #region Constructor
        public LoadingHandler(Action closeAction)
        {
            _closeAction = closeAction;
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
        #endregion

    }

}
