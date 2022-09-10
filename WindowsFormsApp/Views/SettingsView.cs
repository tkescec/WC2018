using DAL.DataTypes.Enums;
using DAL.Properties;
using DAL.Repositories;
using DAL.Services;
using Loader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
        public event ViewDelegate ViewChange;
        public event DalDelegate InitDal;
        #endregion


        #region Ctor
        public SettingsView(SettingsViewModel model = null, Loading loading = null, IRepository repositiory = null)
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
            
        }
        #endregion

        #region Private Methods

        private void SettingsView_Load(object sender, EventArgs e)
        {
            SetCulture(_model.SelectedLang, this);
            PerformBinding();

            cbSettingsLang.SelectedValueChanged += new EventHandler(SettingsLang_SelectedValueChanged);
            cbSettingsGender.SelectedValueChanged += new EventHandler(SettingsGender_SelectedValueChanged);
        }

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
        }

        private void SettingsGender_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            _model.SelectedGender = (Gender)comboBox.SelectedValue;
        }

        private void SettingsNext_Click(object sender, EventArgs e)
        {
            InitDal?.Invoke(this, new DalEventArgs { SelectedGender = _model.SelectedGender });
            ViewChange?.Invoke(this, new ViewEventArgs { ViewName = TypeOfView.FavoritTeamView });
        }
        #endregion

        public sealed override void PerformBinding()
        {
            ComboBoxDataBindings(cbSettingsGender, _model.Genders, (int?)_model.SelectedGender);
            ComboBoxDataBindings(cbSettingsLang, _model.Languages, (int?)_model.SelectedLang);
        }
    }
}
