using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Views
{
    public sealed partial class MainView : BaseView
    {
        #region Private fields
        private readonly MainViewModel _model;
        #endregion

        #region Ctor
        public MainView(MainViewModel model = null)
        {
            if (model != null)
            {
                _model = model;
            }
            else
            {
                _model = new MainViewModel();
            }

            InitializeComponent();
            PerformBinding();
        }
        #endregion

        public sealed override void PerformBinding()
        {

        }
    }
}
