using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using WpfFilerApplication.ViewModel;
using System.Reflection;

namespace WpfFilerApplication.Converters
{
    /*
    　アイコン関係のクラス
      ここはそんなにいじらなくてもいいはずだ。
    */
    public class ExplorerNodeToIconConverter : IValueConverter
    {
        private const string DRIVE_ICON = "WpfFilerApplication.Icons.DiskDrive.ico";
        private const string DIRECTORY_ICON = "WpfFilerApplication.Icons.Folder.ico";
        private const string FILE_ICON = "WpfFilerApplication.Icons.File.ico";

        private Dictionary<Type, BitmapImage> _icons = new Dictionary<Type, BitmapImage>();

        public ExplorerNodeToIconConverter()
        {
            RegisterIcon(typeof(DriveNodeViewModel), DRIVE_ICON);
            RegisterIcon(typeof(DirectoryNodeViewModel), DIRECTORY_ICON);
            RegisterIcon(typeof(FileNodeViewModel), FILE_ICON);
        }

        private void RegisterIcon(Type key, string path)
        {
            var assm = Assembly.GetExecutingAssembly();
            var icon = new BitmapImage();
            icon.BeginInit();
            icon.StreamSource = assm.GetManifestResourceStream(path);
            icon.EndInit();
            _icons[key] = icon;
        }

        #region IValueConverter メンバ

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null) return null;

            BitmapImage icon = null;
            _icons.TryGetValue(value.GetType(), out icon);
            return icon;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
