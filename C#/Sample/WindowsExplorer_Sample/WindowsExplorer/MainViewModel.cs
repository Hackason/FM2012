using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WindowsExplorer
{
    class MainViewModel
    {
        public MainViewModel()
        {
            ObservableCollection<File> files = new ObservableCollection<File>();
            for (int i = 0; i < 10; i++)
            {
                files.Add(new File() { Name = "Image.jpg", ImageSize = "256 × 256", Type = "JPEG イメージ", Size = "256 KB", CreateDate = "2011/11/11 11:11" });
            }
            Files = files;
            SelectedFile = files[0];
        }

            public ObservableCollection<File> Files { get; set; }
            
            private File selectedFile;
            
            public File SelectedFile
           {
                get
                {
                    return selectedFile;
                }
                set
                {
                    selectedFile = value;
                    //  NotifyPropertyChanged("SelectedFile");
                    NotifyPropertyChanged("SelectedFile");
                }
            }

               #region INotifyPropertyChanged

            public event PropertyChangedEventHandler PropertyChanged;

         private void NotifyPropertyChanged(String info)
           { 
            
             if (PropertyChanged != null)
             {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
             }

           }
               #endregion

        }
    }

