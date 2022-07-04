using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace lab12T.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChangued([CallerMemberName] string propertyName =null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;  
            if (handler !=null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));  
            }
        }
    }
}
