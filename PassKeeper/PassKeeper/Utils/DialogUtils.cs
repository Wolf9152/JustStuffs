using PassKeeper.Exceptions;
using System;
using System.Windows.Forms;

namespace PassKeeper.Utils
{
    public static class DialogUtils
    {
        public static void ShowException(Exception ex)
        {
            if (ex is PassException)
            {
                var mex = ex as PassException;
                ShowExceptionMessage(mex.Caption, mex.Message);
            }
            else
            {
                ShowExceptionMessage("ERROR: " + ex.Message, ex.ToString());
            }
        }

        public static void ShowExceptionMessage(String caption, String message)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInformationMessage(String caption, String message)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowWarrningMessage(String caption, String message)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowQuestionMessage(String caption, String message)
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}