using DAL.DataTypes.Enums;
using DAL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL.Services
{
    public static class AlertBox
    {
        public static DialogResult Show(AlertType alertType)
        {
            DialogResult result;

            switch (alertType)
            {
                // TODO - implementirati alert box za success
                case AlertType.Success:
                    result = MessageBox.Show(
                        new Form { TopMost = true },
                        Messages.ErrorMessage.GetDescription(),
                        Messages.ErrorTitle.GetDescription(),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;
                case AlertType.Error:
                    result = MessageBox.Show(
                        new Form { TopMost = true },
                        Messages.ErrorMessage.GetDescription(),
                        Messages.ErrorTitle.GetDescription(),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;
                case AlertType.Warning:
                    result = MessageBox.Show(
                        new Form { TopMost = true },
                        Messages.WarrningMessage.GetDescription(),
                        Messages.WarrningTitle.GetDescription(),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    break;
                // TODO - implementirati alert box za info
                case AlertType.Information:
                    result = MessageBox.Show(
                        new Form { TopMost = true },
                        Messages.ErrorMessage.GetDescription(),
                        Messages.ErrorTitle.GetDescription(),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;
                default:
                    result = MessageBox.Show(
                        new Form { TopMost = true },
                        Messages.ErrorMessage.GetDescription(),
                        Messages.ErrorTitle.GetDescription(),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;
            }

            return result;

        }
    }
}
