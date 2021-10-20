using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solid_Principles._3_InterfaceSegregation.WrongImplementation
{
    class HpPrinter:IPrintTasks
    {
        //this printer does not contain printduplexcontent method
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
        public bool ScanContent(string content)
        {
            MessageBox.Show("Scan Done");
            return true;
        }
    }
}
