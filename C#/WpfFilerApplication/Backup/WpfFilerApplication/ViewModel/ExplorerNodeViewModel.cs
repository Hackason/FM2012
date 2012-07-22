using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wankuma.Kazuki.Wpf;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;

namespace WpfFilerApplication.ViewModel
{
    public class ExplorerNodeViewModel : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (Equals(_name, value)) return;
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private ExplorerNodeViewModel _parent;
        public ExplorerNodeViewModel Parent
        {
            get { return _parent; }
            internal set
            {
                if (Equals(_parent, value)) return;

                _parent = value;

                // 親が変わるとフルパスも変わる
                _fullPath = null;
                OnPropertyChanged("Parent");
                OnPropertyChanged("FullPath");
            }
        }

        private string _fullPath;
        public string FullPath
        {
            get
            {
                if (_fullPath == null)
                {
                    var sb = new StringBuilder();
                    if (this.Parent != null)
                    {
                        sb.Append(this.Parent.FullPath).Append('\\');
                    }
                    sb.Append(this.Name);
                    _fullPath = sb.ToString();
                }
                return _fullPath;
            }
        }

        public static DriveViewModelCollection GetDrives()
        {
            var drives = DriveInfo.GetDrives().Select(d =>
                new DriveNodeViewModel { Name = d.Name });
            var result = new DriveViewModelCollection();
            foreach (var drive in drives)
            {
                result.Add(drive);
            }
            return result;
        }
    }

    public class FileNodeViewModel : ExplorerNodeViewModel
    {
        private long _size;
        public long Size
        {
            get { return _size; }
            set
            {
                if (Equals(_size, value)) return;

                _size = value;
                OnPropertyChanged("Size");
            }
        }
    }

    public class DirectoryNodeViewModel : ExplorerNodeViewModel
    {
        private DirectoryViewModelCollection _childDirectories;
        public DirectoryViewModelCollection ChildDirectories
        {
            get
            {
                if (_childDirectories == null)
                {
                    _childDirectories = new DirectoryViewModelCollection(this);
                    var directories = Directory.GetDirectories(this.FullPath).Select(name =>
                        new DirectoryNodeViewModel { Name = Path.GetFileName(name) });
                    foreach (var dir in directories)
                    {
                        _childDirectories.Add(dir);
                    }
                }
                return _childDirectories;
            }
        }

        private FileNodeViewModelCollection _childFiles;
        public FileNodeViewModelCollection ChildFiles
        {
            get
            {
                if (_childFiles == null)
                {
                    _childFiles = new FileNodeViewModelCollection();
                    var files = Directory.GetFiles(this.FullPath).Select(name =>
                        new FileNodeViewModel
                        {
                            Name = Path.GetFileName(name),
                            Size = new FileInfo(name).Length
                        });
                    foreach (var file in files)
                    {
                        _childFiles.Add(file);
                    }
                }
                return _childFiles;
            }
        }
    }

    public class DriveNodeViewModel : DirectoryNodeViewModel { }

    public abstract class ExplorerNodeViewModelCollectionBase<T> : ObservableCollection<T>
        where T : ExplorerNodeViewModel
    {
        private ExplorerNodeViewModel _parent;
        public ExplorerNodeViewModelCollectionBase(ExplorerNodeViewModel parent)
        {
            _parent = parent;
        }
        public ExplorerNodeViewModelCollectionBase()
            : this(null)
        {
        }

        protected override void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            base.OnCollectionChanged(e);
            if (e.OldItems != null)
            {
                SetParents(e.OldItems.Cast<T>(), null);
            }
            if (e.NewItems != null)
            {
                SetParents(e.NewItems.Cast<T>(), _parent);
            }
        }

        private static void SetParents(IEnumerable<T> items, ExplorerNodeViewModel parent)
        {
            foreach (var item in items)
            {
                item.Parent = parent;
            }
        }
    }

    public class ExplorerNodeViewModelCollection : ExplorerNodeViewModelCollectionBase<ExplorerNodeViewModel>
    {
        public ExplorerNodeViewModelCollection()
        {
        }
        public ExplorerNodeViewModelCollection(ExplorerNodeViewModel parent) : base(parent)
        {
        }
    }

    public class FileNodeViewModelCollection : ExplorerNodeViewModelCollectionBase<FileNodeViewModel>
    {
        public FileNodeViewModelCollection()
        {
        }
        public FileNodeViewModelCollection(ExplorerNodeViewModel parent) : base(parent)
        {
        }
    }

    public class DirectoryViewModelCollection : ExplorerNodeViewModelCollectionBase<DirectoryNodeViewModel>
    {
        public DirectoryViewModelCollection()
        {
        }
        public DirectoryViewModelCollection(ExplorerNodeViewModel parent) : base(parent)
        {
        }
    }

    public class DriveViewModelCollection : ExplorerNodeViewModelCollectionBase<DriveNodeViewModel>
    {
        public DriveViewModelCollection()
        {
        }
        public DriveViewModelCollection(ExplorerNodeViewModel parent) : base(parent)
        {
        }
    }
}
