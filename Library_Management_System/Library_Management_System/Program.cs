using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LibraryPanel(1,"Muhammad Jahanzaib","jahanzaibm29@gmail.com","222223","sargodha",50000));
            //Application.Run(new AdminProfile(1,"Muhammad Jahanzaib","jahanzaibm29@gmail.com","222223","bse","4b","sargodha"));
            Application.Run(new Login());
           //Application.Run(new LibraryPanel());



        }
    }
}
