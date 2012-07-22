using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;

namespace WindowsExplorer.ViewModel
{
    class ViewModelBase : INotifyPropertyChanged, IDataErrorInfo
    {
        #region INotifyPropertyChanged メンバ

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var h = PropertyChanged;
            if (h == null) return;

            h(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region IDataErrorInfo メンバ

        private Dictionary<string, string> _errors = new Dictionary<string, string>();

        public string Error
        {
            get
            {
                if (!HasError) return null;

                var sb = new StringBuilder();
                foreach (var name in _errors.Keys)
                {
                    sb.AppendLine(_errors[name]);
                }
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                string errorMessage = null;
                _errors.TryGetValue(columnName, out errorMessage);
                return errorMessage;
            }
        }

        protected void AddErrorMessage(string propertyName, string errorMessage)
        {
            _errors[propertyName] = errorMessage; ;
        }

        protected void ClearErrorMessage(string propertyName)
        {
            _errors.Remove(propertyName);
        }

        protected void ClearErrorMessage()
        {
            _errors.Clear();
        }

        #endregion

        public bool HasError
        {
            get
            {
                return ErrorCount != 0;
            }
        }

        public int ErrorCount
        {
            get
            {
                return _errors.Count;
            }
        }
    }
}
