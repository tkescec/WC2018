using System.ComponentModel;
using System.Windows.Forms;
using WindowsFormsApp.Contracts;
using WindowsFormsApp.Events;
using WindowsFormsApp.Providers;

namespace WindowsFormsApp.Views
{
    [TypeDescriptionProvider(typeof(AbstractDescriptionProvider<BaseView, UserControl>))]
    public abstract class BaseView : UserControl, IView
    {
        public abstract void PerformBinding();

    }
}
