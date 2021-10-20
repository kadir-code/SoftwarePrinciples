using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solid_Principles._3_InterfaceSegregation.WrongImplementation
{
    class CanonPrinter : IPrintTasks
    {
        public bool FaxContent(string content)
        {
            MessageBox.Show("Fax Done");
            return true;
        }
        public bool PhotoCopyContent(string content)
        {
            MessageBox.Show("PhotoCopy Done");
            return true;

        }
        public bool PrintContent(string content)
        {
            MessageBox.Show("Print Done");
            return true;

        }
        public bool PrintDuplexContent(string content)
        {
            MessageBox.Show("Print Duplex Done");
            return true;
        }
        public bool ScanContent(string content)
        {
            MessageBox.Show("Scan Done");
            return true;
        }
    }
}
