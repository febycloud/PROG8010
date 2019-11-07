using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isprime
{
    public class PropertyChangedBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }

   
    public class VM: PropertyChangedBase
    {
        private int targetNum;
        public int TargetNum
        {
            set { targetNum = value;OnPropertyChanged("TargetNum"); }
            get { return targetNum; }
        }
    }
}
