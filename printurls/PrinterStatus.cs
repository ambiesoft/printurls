using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Printing;
using System.Drawing.Printing;
using System.Windows.Forms;
namespace printurls
{
    class PrinterStatus
    {
        static PrintServer _printServer;
        static PrintQueue _printQueue;

        static void prepare()
        {
            try
            {
                PrinterSettings settings = new PrinterSettings();
                _printServer = new PrintServer();
                _printQueue = _printServer.GetPrintQueue(settings.PrinterName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static bool IsBusy()
        {
            if(_printQueue==null)
                prepare();

            if(_printQueue==null)
                return false;

            return _printQueue.IsBusy;
        }
    }
}
