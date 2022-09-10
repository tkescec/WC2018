using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loader
{
    public class Loading
    {
        LoaderForm loaderForm;
        Thread loaderThread;

        public void Show()
        {
            loaderThread = new Thread(new ThreadStart(LoadingProcessEx));
            loaderThread.Start();
        }

        public void Show(Form parent)
        {
            loaderThread = new Thread(new ParameterizedThreadStart(LoadingProcessEx));
            loaderThread.Start(parent);
        }

        public void Close()
        {
            if (loaderForm != null)
            {
                loaderForm.BeginInvoke(new System.Threading.ThreadStart(loaderForm.CloseLoadingForm));
                loaderForm = null;
                loaderThread = null;
            }
        }

        private void LoadingProcessEx()
        {
            loaderForm = new LoaderForm();
            loaderForm.ShowDialog();
        }

        private void LoadingProcessEx(object parent)
        {
            Form Cparent = parent as Form;
            loaderForm = new LoaderForm(Cparent);
            loaderForm.ShowDialog();
        }
    }
}
