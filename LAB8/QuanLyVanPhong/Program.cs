using System;
using System.Windows.Forms;
using QuanLyVanPhong.Forms;

namespace QuanLyVanPhong
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
