using DAL.DataTypes.Enums;
using DAL.Properties;
using DAL.Repositories;
using DAL.Services;
using Loader;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp.Contracts;
using WindowsFormsApp.Events;
using WindowsFormsApp.Providers;

namespace WindowsFormsApp.Views
{
    [TypeDescriptionProvider(typeof(AbstractDescriptionProvider<BaseView, UserControl>))]
    public abstract class BaseView : UserControl, IView
    {
        public Loading _loading;
        public IRepository _repository;
        public abstract void PerformBinding();

        public void SetCulture(Lang selectedLang, Control view)
        {
            Type viewType = view.GetType();

            try
            {
                string cultureName = GetCultureName(selectedLang);

                CultureInfo customCulture = new CultureInfo(cultureName);
                Thread.CurrentThread.CurrentUICulture = customCulture;
                Thread.CurrentThread.CurrentCulture = customCulture;
                EnumResources.Culture = customCulture;

                ApplyResourceToControl(view, new ComponentResourceManager(viewType), customCulture);
            }
            catch (Exception)
            {
                AlertBox.Show(AlertType.Error);
            }
        }

        private void ApplyResourceToControl(Control view, ComponentResourceManager componentResourceManager, CultureInfo customCulture)
        {
            componentResourceManager.ApplyResources(view, view.Name, customCulture);

            foreach (Control child in view.Controls)
            {
                ApplyResourceToControl(child, componentResourceManager, customCulture);
            }
        }

        private string GetCultureName(Lang lang)
        {
            string cultureName;

            switch (lang)
            {
                case Lang.English:
                    cultureName = "en-US";
                    break;
                case Lang.Croatian:
                    cultureName = "hr-HR";
                    break;
                default:
                    cultureName = "en-US";
                    break;
            }

            return cultureName;
        }

    }
}
