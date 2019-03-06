using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace SideKick.App.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Overridable method that can be used for initializing the page. Use this instead of constructor
        /// </summary>
        /// <param name="parameter">Object to be used for initialization</param>
        public virtual void InitPage(object parameter = null)
        {
        }

        protected void Set<U>(ref U backingStore, U value, [CallerMemberName]string propertyName = null, Action onChanged = null, Action<U> onChanging = null)
        {
            if (EqualityComparer<U>.Default.Equals(backingStore, value)) return;

            onChanging?.Invoke(value);

            OnPropertyChanging(propertyName);

            backingStore = value;

            onChanged?.Invoke();

            OnPropertyChanged(propertyName);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            if (PropertyChanged == null) return;

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
        public void OnPropertyChanging([CallerMemberName]string propertyName = null)
        {
            if (PropertyChanging == null) return;

            PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
        }
    }
}
