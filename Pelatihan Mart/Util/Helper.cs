using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelatihan_Mart.Util
{
    public static class Helper
    {
        public static User loggedUser;

        public static void ResetInputFields(Control controlGroup)
        {
            foreach (Control control in controlGroup.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Clear();
                }
                if (control is CheckBox)
                {
                    (control as CheckBox).Checked = false;
                }
                if (control is DateTimePicker)
                {
                    (control as DateTimePicker).Value = DateTime.Now;
                }
                if (control is ComboBox)
                {
                    (control as ComboBox).SelectedIndex = 0;
                }
            }
        }

        public static void IsNullOrEmpty(Control controlGroup)
        {
            bool isNullOrEmpty = false;
            isNullOrEmpty = (controlGroup.Controls.OfType<TextBox>().Where(x => string.IsNullOrEmpty(x.Text.ToString())).Count() == 0 &&
                             );
        }
    }
}
