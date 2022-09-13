using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Contracts
{
    public interface IViewModel
    {
        void OnPropertyChanged(PropertyChangedEventArgs e);
    }
}
