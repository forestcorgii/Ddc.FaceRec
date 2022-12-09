using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ddc.FaceRecApp.FrontEnd.Shared
{
    public static class MessageBoxes
    {
        public static void Error(string message, string title = "") =>
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void Prompt(string message, string title = "") =>
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static bool Inquire(string message, string title = "") =>
                MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    }
}
