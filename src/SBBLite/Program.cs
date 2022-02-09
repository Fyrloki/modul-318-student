using Common;
using SwissTransport.Core;

namespace SBBLite
{
    internal static class Program
    {
        /// <summary>
        ///  Entry point of the app
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm(new Transport()));
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    Constants.EXCEPTION_APEARED + ex.Message,
                    Constants.FAILURE_CAPTION,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}