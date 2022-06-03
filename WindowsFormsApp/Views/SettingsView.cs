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
    public sealed partial class SettingsView : BaseView
    {
        #region Private fields
        private readonly SettingsViewModel _model;
        #endregion

        #region Ctor
        public SettingsView(SettingsViewModel model = null)
        {
            if (model != null)
            {
                _model = model;
            }
            else
            {
                _model = new SettingsViewModel();
            }

            InitializeComponent();
            PerformBinding();
        }
        #endregion

        public sealed override void PerformBinding()
        {
            ComboBoxDataBindings(cbSettingsGender, _model.Genders);
            ComboBoxDataBindings(cbSettingsLang, _model.Languages);
        }

        private void ComboBoxDataBindings(ComboBox control, IEnumerable<object> objects)
        {
            control.DataSource = objects.ToList();
            control.DisplayMember = "Name";
            control.ValueMember = "Id";
        }
    }
}
