using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using ComprehensionCheck.Base;

namespace ComprehensionCheck.ViewModel
{
    public class MainViewModel : NotifyPropertyChangedBase
    {
        private DataTable data = new DataTable();
        public DataTable Data
        {
            get
            {
                return this.data;
            }

            set
            {
                this.data = value;
                OnPropertyChanged("Data");
            }
        }
    }
}
