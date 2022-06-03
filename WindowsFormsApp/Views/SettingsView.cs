using DAL.DataTypes.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Events;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Views
{
    public sealed partial class SettingsView : BaseView
    {
        #region Private fields
        private readonly SettingsViewModel _model;
        #endregion

        #region Public fields
        public event CultureDelegate LangChange;
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

            cbSettingsLang.SelectedValueChanged += new EventHandler(SettingsLang_SelectedValueChanged);
            cbSettingsGender.SelectedValueChanged += new EventHandler(SettingsGender_SelectedValueChanged);
        }
        #endregion

        public sealed override void PerformBinding()
        {
            ComboBoxDataBindings(cbSettingsGender, _model.Genders, (int?)_model.SelectedGender);
            ComboBoxDataBindings(cbSettingsLang, _model.Languages, (int?)_model.SelectedLang);
        }

        #region Private Methods
        private void ComboBoxDataBindings(ComboBox control, IEnumerable<object> objects, int? selected)
        {
            control.DataSource = objects.ToList();
            control.DisplayMember = "Name";
            control.ValueMember = "Id";
            if (selected != null) control.SelectedIndex = (int)selected;
        }

        private void SettingsLang_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            _model.SelectedLang = (Lang)comboBox.SelectedValue;

            switch (_model.SelectedLang)
            {
                case Lang.English:
                    LangChange.Invoke(this, new CultureEventArgs { CultureName = "en" });
                    break;
                case Lang.Croatian:
                    LangChange.Invoke(this, new CultureEventArgs { CultureName = "hr" });
                    break;
                default:
                    LangChange.Invoke(this, new CultureEventArgs { CultureName = "en" });
                    break;
            }

        }

        private void SettingsGender_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            _model.SelectedGender = (Gender)comboBox.SelectedValue;
        }
        #endregion
    }
}
