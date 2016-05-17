using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClickJacking_Detector
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {

                Application.Run(new Form1());
            }
            catch(Exception s ) {MessageBox.Show("\r\n plz report this error to gersy.ch2@gmail.com\r\n"+s.Message,"error"); }

        }
        public static bool IsUrl(string uriName)
        {
            Uri uriResult;
            return Uri.TryCreate(uriName, UriKind.Absolute, out uriResult)
                && uriResult.Scheme == Uri.UriSchemeHttp;

        }
    }
}
