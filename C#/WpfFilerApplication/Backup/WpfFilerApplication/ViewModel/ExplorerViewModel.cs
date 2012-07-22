using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wankuma.Kazuki.Wpf;

namespace WpfFilerApplication.ViewModel
{
    public class ExplorerViewModel : ViewModelBase
    {
        private DriveViewModelCollection _drives;
        public DriveViewModelCollection Drives
        {
            get
            {
                if (_drives == null)
                {
                    _drives = ExplorerNodeViewModel.GetDrives();
                }
                return _drives;
            }
        }
    }
}
