using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Name my name
/// </summary>
namespace Finalsample
{
   public class VM:INotifyPropertyChanged

    {
        public BindingList<Meal> Meals { get; set; } = new BindingList<Meal>()
        {
            new Meal{Name="Plan 7",Amount=20m},
            new Meal{Name="Plan 1",Amount=30m},
            new Meal{Name="Singal 40",Amount=7m},
            new Meal{Name="Luxury 4",Amount=40m},
            new Meal{Name="Standard",Amount=12m},
        };
        public BindingList<Dorm> Dorms { get; set; } = new BindingList<Dorm>()
        {
            new Dorm{Name="Allen Hall",Amount=1500m},
            new Dorm{Name="Pike Hall",Amount=1600m },
            new Dorm{Name="Mema Hall",Amount=1300m },
            new Dorm{Name="Lake Hall",Amount=2300m },
        };
        private bool notBoth = true;
        public bool NotBoth()
        {
            get{ return notBoth; }
            set{ notBoth = value;PropertyChange(); }
        }
        private bool bothSelected = false;
        public bool BothSelected
        {
            get { return bothSelected; }
            set { bothSelected = value;PropertyChange(); }
        }
        private Meal selectedMeal;
        public Meal SelectedMeal
        {
            get { return selectedMeal; }
            set { selectedMeal = value;PropertyChange(); }
        }
        private Dorm selectedDorm;
        public Dorm SelectedDorm
        {
            get { return selectedDorm; }
            set { selectedDorm = value; PropertyChange(); }
        }
        private decimal total;
        public decimal Total
        {
            get { return total; }
            set { total = value; PropertyChange(); }
        }
        public bool Calc()
        {
            bool isVaildTotal = false;
            if (SelectedDorm != null && SelectedMeal != null)
            {
                Total = SelectedDorm.Amount + SelectedMeal.Amount;
                isVaildTotal = true;
            }
            return isVaildTotal;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void PropertyChange([CallerMemberName]string property = "")
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(property));
        }
    }
}
